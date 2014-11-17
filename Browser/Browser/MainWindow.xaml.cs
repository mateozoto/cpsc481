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
using System.IO;

namespace Browser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        int currentTab = 0;
        int openTab = 1;
        int bookmarkcount = 0;
        string curUrl = "";
        String homepage = "http://google.ca";

        public MainWindow()
        {
            InitializeComponent();
            string[] lines = System.IO.File.ReadAllLines("bookmarks.txt");
            if (lines.Length != 0)
            {
                foreach (string line in lines)
                {
                    String bookmark = urlbar.Text;
                    Button newBookmark = new Button();
                    newBookmark.Height = 30;
                    newBookmark.Width = 100;
                    newBookmark.Content = line;
                    newBookmark.Click += newBookmark_Click;
                    nobookmarks.Text = "";
                    newBookmark.VerticalAlignment = VerticalAlignment.Top;
                    newBookmark.HorizontalAlignment = HorizontalAlignment.Left;
                    int bookmarkplace = (bookmarkcount * 101) + 5;
                    newBookmark.Margin = new Thickness(bookmarkplace, 5, 0, 0);
                    welcomeScreen.Children.Add(newBookmark);
                    bookmarkcount++;
                }
            }
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

        private void settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            if (welcomeScreen.IsVisible)
            {
                welcomeScreen.Visibility = Visibility.Collapsed;
                //browserScroll.Visibility = Visibility.Visible;
                home.Visibility = Visibility.Visible;
            }
            //open the tab
            if (openTab == 1)
            {
                String query = urlbar.Text;

                if (!(query.Contains(".com") || query.Contains(".ca") || query.Contains(".net") || query.Contains(".org") || query.Contains(".tv")))
                {
                    query = "https://www.google.ca/#q=" + query;
                    urlbar.Text = query;
                }

                else if (!(query.StartsWith("http://") || query.StartsWith("https://")))
                {
                    query = "http://" + query;
                    urlbar.Text = query;
                }
                                      
                tab1.Visibility = Visibility.Visible;
                tab1.Navigate(urlbar.Text);
                tab1.Width = 1007;
                tab1.Height = 473;
                tab1.Margin = new Thickness(0, 42, 0, 0);
               
            }
        }

        private void urlbar_GotFocus(object sender, RoutedEventArgs e)
        {
            if (urlbar.Text == "Search or enter a URL here")
            {
                urlbar.Text = "";
            }
        }

        private void urlbar_LostFocus(object sender, RoutedEventArgs e)
        {
            urlbar.Text = "Search or enter a URL here";
        }

        private void urlbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                go_Click(sender, e);
        }

        void newBookmark_Click(object sender, RoutedEventArgs e)
        {
            Button clicked = (Button)sender;
            if (welcomeScreen.IsVisible)
            {
                welcomeScreen.Visibility = Visibility.Collapsed;
                //browserScroll.Visibility = Visibility.Visible;
                home.Visibility = Visibility.Visible;

                //open the tab
                if (openTab == 1)
                {
                    tab1.Visibility = Visibility.Visible;
                    tab1.Width = 1007;
                    tab1.Height = 473;
                    tab1.Margin = new Thickness(0, 42, 0, 0);
                    tab1.Navigate((String)clicked.Content);

                }
            }
        }

        private void home_Click_1(object sender, RoutedEventArgs e)
        {
            welcomeScreen.Visibility = Visibility.Visible;
            //browser.Visibility = Visibility.Collapsed;
            home.Visibility = Visibility.Collapsed;
            tab1but.Visibility = Visibility.Visible;

            if (tab1.IsVisible)
            {
                welcome.Visibility = Visibility.Collapsed;
                message1.Visibility = Visibility.Collapsed;

                tab1.IsEnabled = false;

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
            currentTab = 1;
            welcomeScreen.Visibility = Visibility.Collapsed;
            home.Visibility = Visibility.Visible;

            tab1.Width = 1007;
            tab1.Height = 473;
            tab1.Margin = new Thickness(0, 42, 0, 0);
            tab1.IsEnabled = true;
        }

        private void bookmark_Click(object sender, RoutedEventArgs e)
        {
            if (urlbar.Text == "")
            {
                //do nothing
            }
            else
            {
                String bookmark = urlbar.Text;
                Button newBookmark = new Button();
                newBookmark.Height = 30;
                newBookmark.Width = 100;
                newBookmark.Content = urlbar.Text;
                newBookmark.Click += newBookmark_Click;
                nobookmarks.Text = "";
                newBookmark.VerticalAlignment = VerticalAlignment.Top;
                newBookmark.HorizontalAlignment = HorizontalAlignment.Left;
                int bookmarkplace = (bookmarkcount * 101) + 5;
                newBookmark.Margin = new Thickness(bookmarkplace, 5, 0, 0);
                welcomeScreen.Children.Add(newBookmark);
                using (StreamWriter writer = new StreamWriter("bookmarks.txt", true))
                {
                    writer.WriteLine(newBookmark.Content);
                }
                bookmarkcount++;
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (tab1.CanGoBack == true)
            {
                tab1.GoBack();
            }
        }

        private void forward_Click(object sender, RoutedEventArgs e)
        {
            //left it as tab1 for now until etienne gets tabs 100%
            if (tab1.CanGoForward == true)
            {
                tab1.GoForward();
            }
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            //crashes if there is no webpage open
            if (welcomeScreen.IsVisible){
            }
            else
            {
                tab1.Refresh();
            }
        }

        private void tab1_LoadCompleted(object sender, NavigationEventArgs e)
        {
            urlbar.Text = (String)e.Uri.OriginalString;
        }

        private void tab2_LoadCompleted(object sender, NavigationEventArgs e)
        {
            urlbar.Text = (String)e.Uri.OriginalString;
        }

        private void tab3_LoadCompleted(object sender, NavigationEventArgs e)
        {
            urlbar.Text = (String)e.Uri.OriginalString;
        }

        private void tab4_LoadCompleted(object sender, NavigationEventArgs e)
        {
            urlbar.Text = (String)e.Uri.OriginalString;
        }
    }
}
