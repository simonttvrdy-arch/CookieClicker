using System.Diagnostics;
using System.Formats.Nrbf;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CookieClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal upgrady;
        decimal aktualnyPocetCookies = 10;
        decimal UPGRkurzor = 10;
        decimal UPGRbabka = 100;
        private void OpenYouTubePopup()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=lG2phD59-hM",
                UseShellExecute = true
            });
        }







        DispatcherTimer gameTimer;
        public MainWindow()
        {
            InitializeComponent();
            gameTimer = new DispatcherTimer();

            gameTimer.Interval = TimeSpan.FromSeconds(1);
            gameTimer.Tick += KlikniNaCookie;

            gameTimer.Start();
        }

        private void KlikniNaCookie(object? sender, EventArgs e)
        {
            aktualnyPocetCookies += upgrady;
            pocetSekund.Text = aktualnyPocetCookies.ToString();
        }



        private void CookieBTN_Click(object sender, RoutedEventArgs e)
        {
            aktualnyPocetCookies++;
            pocetSekund.Text = aktualnyPocetCookies.ToString();
        }



        private void KurzorKupitBTN_Click(object sender, RoutedEventArgs e)
        {
            if(aktualnyPocetCookies - UPGRkurzor >= 0)
            {
                aktualnyPocetCookies -= UPGRkurzor;
                pocetSekund.Text = aktualnyPocetCookies.ToString();
                upgrady += 0.10m;
                
            }
            else
            {
            OpenYouTubePopup();
               // MessageBox.Show("Nemas dostatok Cookies");67 toto je dobre
            }

        }//cursor 10ck +10% za kazdy dalej cena hore, babka 100 + 20%, bana 1000 + 15%



        private void BabkaKupitBTN_Click(object sender, RoutedEventArgs e)
        {
            if (aktualnyPocetCookies - UPGRbabka >=0)
            {
                aktualnyPocetCookies -= UPGRbabka;
                pocetSekund.Text = aktualnyPocetCookies.ToString();
                upgrady += 1m;
                UPGRbabka = UPGRbabka * 0.20m;
            }
            else
            {
                MessageBox.Show("Nemas dostatok Cookies");
            }
        }



        private void BanaKupitBTN_Click(object sender, RoutedEventArgs e)
        {
            if (aktualnyPocetCookies - UPGRbabka >= 0)
            {
                aktualnyPocetCookies -= UPGRbabka;
                pocetSekund.Text = aktualnyPocetCookies.ToString();
                upgrady += 1m;
                UPGRbabka = UPGRbabka * 0.15m;
            }
            else
            {
                MessageBox.Show("Nemas dostatok Cookies");
            }
        }
    }
}

//pridaj stats = celkovy zarobok + bubak co karadne