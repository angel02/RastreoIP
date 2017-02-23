using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using System.Net;
using System.IO;

namespace Maps
{
    public partial class Form1 : Form
    {
        public Form1() {InitializeComponent();}

        public struct Information {
            public bool Success;
            public string Country;
            public string Country_Code;
            public string Region_Code;
            public string Region_Name;
            public string City;
            public string Zip_Code;
            public double Latitude;
            public double Longitude;
            public string Time_Zone;
            public string Isp;
            public string Organization_Name;
            public string As_Number_Name;
            public string Ip_Address_Used;
        }

        /*
             0: success
             1: COUNTRY
             2: COUNTRY CODE
             3: REGION CODE
             4: REGION NAME
             5: CITY
             6: ZIP CODE
             7: LATITUDE
             8: LONGITUDE
             9: TIME ZONE
            10: ISP NAME
            11: ORGANIZATION NAME
            12: AS NUMBER / NAME
            13: IP ADDRESS USED FOR QUERY
        */
        public void MostrarDatos(Information Data) {

            Map.Position = new PointLatLng(Data.Latitude, Data.Longitude);

            /*double lat = Map.Position.Lat
                 , lng = Map.Position.Lng
                 , count = 1;

            bool state = true;

            while (state) {
                if (Data.Latitude  > lat) lat += count;
                if (Data.Longitude > lng) lng += count;

                if (Data.Latitude  < lat) lat -= count;
                if (Data.Longitude < lng) lng -= count;

                Map.Position = new PointLatLng(lat, lng);

                if (Data.Longitude == lng && Data.Latitude == lat) break;
                if (Math.Sqrt(Math.Pow(Data.Latitude - lat, 2) + Math.Pow(Data.Longitude - lng, 2)) < 1)
                    count = 0.00001;
            }*/
            


            for (var i = Map.Zoom; i <= 10; i++)
            {
                Map.Zoom = i;
                Thread.Sleep(100);
            }

            lbl_country.Text    = Data.Country;
            lbl_region.Text     = Data.Region_Name;
            lbl_city.Text       = Data.City;
            lbl_latitude.Text   = Data.Latitude.ToString();
            lbl_longitude.Text  = Data.Longitude.ToString();
            lbl_isp.Text        = Data.Isp;
            lbl_ip.Text         = Data.Ip_Address_Used;
        }

        public Information Localizar(string ip)
        {
            string[] Datos = Net.HttpRequest("http://ip-api.com/line/" + ip+"?lan=es");
            Information info = new Information();


            if (Datos[0] == "success")
            {
                info.Success        = (Datos[0] == "success")? true : false;
                info.Country        = Datos[1];
                info.Country_Code   = Datos[2];
                info.Region_Code    = Datos[3];
                info.Region_Name    = Datos[4];
                info.City           = Datos[5];
                info.Zip_Code       = Datos[6];
                info.Latitude       = Convert.ToDouble(Datos[7]);
                info.Longitude      = Convert.ToDouble(Datos[8]);
                info.Time_Zone      = Datos[9];
                info.Isp            = Datos[10];
                info.Organization_Name  = Datos[11];
                info.As_Number_Name     = Datos[12];
                info.Ip_Address_Used    = Datos[13];

            }
            else if (Datos[0] == "fail")
            {
                MessageBox.Show("Dirección " + ip + " no encontrada.");
            }
            else {
                MessageBox.Show("Ocurrió un problema, intente nuevamente.");
            }

            return info;
        }

        // Para cuando sea por IP y se tenga toda la informacion
        private void Marcador(ref GMapControl MAP, Information info) {
            // Creamos una capa de superposición para los marcadores
            GMapOverlay Superposicion = new GMapOverlay("markers");

            GMarkerGoogle marcador = new GMarkerGoogle(new PointLatLng(info.Latitude, info.Longitude), GMarkerGoogleType.green);

            //Agregamos la información al marcador
            marcador.Tag = info;

            Superposicion.Markers.Add(marcador);
            Map.Overlays.Add(Superposicion);
        }

        // Para los casos en los que se indiquen coordenadas
        private void Marcador(ref GMapControl MAP, double Latitud, double Longitud)
        {
            // Creamos una capa de superposición para los marcadores
            GMapOverlay Superposicion = new GMapOverlay("markers");

            GMarkerGoogle marcador = new GMarkerGoogle(new PointLatLng(Latitud, Longitud), GMarkerGoogleType.green);

            //Agregamos la información al marcador
            marcador.Tag = null;

            Superposicion.Markers.Add(marcador);
            Map.Overlays.Add(Superposicion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] direcciones = txt_ip.Lines.ToArray();
            Information info = new Information();
            Map.Overlays.Clear();

            StreamWriter writer = new StreamWriter("log.txt", true);


            foreach (var direccion in direcciones)
            {

                if (direccion.Contains(','))
                {
                    int posicion = direccion.IndexOf(',');

                    double latitud, longitud;

                    latitud = Convert.ToDouble(direccion.Substring(0, posicion));
                    longitud = Convert.ToDouble(direccion.Substring(posicion + 1));

                    Marcador(ref Map, latitud, longitud);
                }
                else
                {
                    info = Localizar(direccion);
                    Marcador(ref Map, info);
                    writer.WriteLine("{0}\tLat: {1}\tLon: {2}\tRegion: {3}\t\tCity: {4}\t\tIsp:{5}", info.Ip_Address_Used, info.Latitude, info.Longitude, info.Region_Name, info.City, info.As_Number_Name);

                }

                Map.Zoom += 0.01;
                Map.Zoom -= 0.01;
            }

            Map.OnMarkerClick += new MarkerClick(Markers_EnventHandler);

            writer.Close();

            if (txt_ip.Lines.Count() == 1)      MostrarDatos(info);
        }


        private void Markers_EnventHandler(GMapMarker item, MouseEventArgs e) {
            object identityData = item.Tag;

            if(identityData != null && e.Button == MouseButtons.Left)
            {
                //markerMenu.Show(Map, e.Location);
                MostrarDatos((Information)identityData);

            }


        }

        private void cmbox_mapas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbox_mapas.Text) {
                case "Google Mapa":
                    Map.MapProvider = GMapProviders.GoogleMap;
                    break;
                case "Google Satélite":
                    Map.MapProvider = GMapProviders.GoogleSatelliteMap;
                    break;
                case "Google Mapa Híbrido":
                    Map.MapProvider = GMapProviders.GoogleHybridMap; ;
                    break;
                case "Google Mapa China":
                    Map.MapProvider = GMapProviders.GoogleChinaMap;
                    break;
                case "Google Satélite China":
                    Map.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
                    break;
                case "Bing Satélite":
                    Map.MapProvider = GMapProviders.BingSatelliteMap;
                    break;
                case "Bing Mapa":
                    Map.MapProvider = GMapProviders.BingMap;
                    break;
                case "Yahoo Mapa":
                    Map.MapProvider = GMapProviders.YahooMap;
                    break;
                case "Yahoo Satélite":
                    Map.MapProvider = GMapProviders.YahooSatelliteMap;
                    break;
                case "Yahoo Mapa Hibrído":
                    Map.MapProvider = GMapProviders.YandexHybridMap;
                    break;
                case "Open Street Map":
                    Map.MapProvider = GMapProviders.OpenStreetMap;
                    break;
                case "Open Clycle Map":
                    Map.MapProvider = GMapProviders.OpenCycleMap;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbox_mapas.Text = "Bing Satélite";

            //Iniciamos el mapa
            Map.DragButton = MouseButtons.Left;
            Map.CanDragMap = true;

            //Map.MapProvider = GMapProviders.BingMap;
            Map.Position = new PointLatLng(0, 0);
            Map.MinZoom = 2;
            Map.MaxZoom = 25;
            Map.Zoom = 2.5;
            Map.AutoScroll = true;

            
        }


    }
}
