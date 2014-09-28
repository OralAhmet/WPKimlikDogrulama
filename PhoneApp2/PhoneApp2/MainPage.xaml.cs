using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp2.Resources;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Windows.Data;
using Microsoft.Phone.Tasks;
using Microsoft.Xna.Framework.Media;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Net.NetworkInformation;

namespace PhoneApp2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ShellTile tile = ShellTile.ActiveTiles.First();
            if (null != tile)
            {
                //ÖnYüz
                StandardTileData data = new StandardTileData();
                data.BackgroundImage = new Uri(@"/Assets/ApplicationIcon.png", UriKind.Relative);
                //Arka Yüz
                data.BackTitle = "T.C. Kimlik";
                data.BackContent = "T.C. Kimlik";
                tile.Update(data);

            }
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        private void btnSorgula_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SystemTray.ProgressIndicator.Text = "İşleminiz yapılıyor...";
                SetProgressIndicator(true);

                if (TCNoKontrolu(txtTC.Text))
                {
                    KPS.KPSPublicSoapClient client = new KPS.KPSPublicSoapClient();
                    client.TCKimlikNoDogrulaAsync(Convert.ToInt64(txtTC.Text), txtAd.Text.ToUpper(), txtSoyad.Text.ToUpper(), Convert.ToInt32(txtDogum.Text));
                    client.TCKimlikNoDogrulaCompleted += client_TCKimlikNoDogrulaCompleted;
                }
                else
                {
                    MessageBox.Show("Tc kimlik numarası yanlış");
                    SetProgressIndicator(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {

            }
        }
        void client_TCKimlikNoDogrulaCompleted(object sender, KPS.TCKimlikNoDogrulaCompletedEventArgs e)
        {
            if (e.Result == true)
            {
                MessageBox.Show("Kimlik numaranız doğrulandı");
            }
            else
            {
                MessageBox.Show("Kimlik numaranız doğrulanmadı.Lütfen bilgilerinizi kontrol ederek tekrar deneyiniz");
            }
            SetProgressIndicator(false);
        }

        //Tc kimlik no format kontrolü
        public static bool TCNoKontrolu(string TCNo)
        {

            int[] TC = new int[11];

            for (int i = 0; i < 11; i++)
            {

                string a = TCNo[i].ToString();

                TC[i] = Convert.ToInt32(a);
            }

            int tekler = 0;
            int ciftler = 0;
            for (int k = 0; k < 9; k++)
            {
                if (k % 2 == 0)
                    tekler += TC[k];
                else if (k % 2 != 0)
                    ciftler += TC[k];

            }
            int t1 = (tekler * 3) + ciftler;

            int c1 = (10 - (t1 % 10)) % 10;

            int t2 = c1 + ciftler;

            int t3 = (t2 * 3) + tekler;

            int c2 = (10 - (t3 % 10)) % 10;

            if (c1 == TC[9] && c2 == TC[10])
                return true;
            else
                return false;
        }
        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
            appBarButton.Text = AppResources.AppBarButtonText;
            ApplicationBar.Buttons.Add(appBarButton);

            // Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
            ApplicationBar.MenuItems.Add(appBarMenuItem);
        }

        //İnternet bağlantısı kontrolü
        public static bool checkNetworkConnection()
        {
            var ni = NetworkInterface.NetworkInterfaceType;
            bool IsConnected = false;
            if ((ni == NetworkInterfaceType.Wireless80211) || (ni == NetworkInterfaceType.MobileBroadbandCdma) || (ni == NetworkInterfaceType.MobileBroadbandGsm))
                IsConnected = true;
            else if (ni == NetworkInterfaceType.None)
                IsConnected = false;
            return IsConnected;
        }

        public static void SetProgressIndicator(bool value)
        {
            SystemTray.ProgressIndicator.IsIndeterminate = value;
            SystemTray.ProgressIndicator.IsVisible = value;
        }
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            ProgressIndicator pI = new ProgressIndicator();
            SystemTray.SetProgressIndicator(this, pI);
        }


    }
}