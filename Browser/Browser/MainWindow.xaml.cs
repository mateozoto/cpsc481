using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Browser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        int openTab = 1;
        WebBrowser curTab;
        string curUrl = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void games_Click(object sender, RoutedEventArgs e)
        {

        }

        private void videos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void music_Click(object sender, RoutedEventArgs e)
        {

        }

        private void learning_Click(object sender, RoutedEventArgs e)
        {

        }

        private void home_Click(object sender, RoutedEventArgs e)
        {

        }

        private void urlbar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void go_Click(object sender, RoutedEventArgs e)
        {

        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void go_Click_1(object sender, RoutedEventArgs e)
        {
            if (welcomeScreen.IsVisible)
            {
                welcomeScreen.Visibility = Visibility.Collapsed;
                //browserScroll.Visibility = Visibility.Visible;
                home.Visibility = Visibility.Visible;

                //open the tab
                if (openTab == 1)
                {
                    tab1.Visibility = Visibility.Visible;
                    tab1.Navigate(urlbar.Text);
                    tab1.Width = 1007;
                    tab1.Height = 473;
                    tab1.Margin = new Thickness(0, 42, 0, 0);
                }
            }
        }

        private void urlbar_GotFocus(object sender, RoutedEventArgs e)
        {
            urlbar.Text = "";
        }

        private void urlbar_LostFocus(object sender, RoutedEventArgs e)
        {
            //urlbar.Text = "Search or enter a URL here";
        }

        private void urlbar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void home_Click_1(object sender, RoutedEventArgs e)
        {
            welcomeScreen.Visibility = Visibility.Visible;
            //browser.Visibility = Visibility.Collapsed;
            browserScroll.Visibility = Visibility.Collapsed;
            home.Visibility = Visibility.Collapsed;
            tab1but.Visibility = Visibility.Visible;

            if (tab1.IsVisible)
            {
                welcome.Visibility = Visibility.Collapsed;
                message1.Visibility = Visibility.Collapsed;

                tab1.Margin = new Thickness(139, 92, 0, 0);
                tab1.Height = 200;
                tab1.Width = 343;
            }
        }

        private void browser_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            urlbar.Text = e.Uri.ToString();
            curUrl = e.Uri.ToString();
        }

        private void tab1but_Click(object sender, RoutedEventArgs e)
        {
            welcomeScreen.Visibility = Visibility.Collapsed;
            home.Visibility = Visibility.Visible;

            tab1.Width = 1007;
            tab1.Height = 473;
            tab1.Margin = new Thickness(0, 42, 0, 0);
        }
    }
}
