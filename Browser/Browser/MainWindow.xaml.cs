﻿using System;
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
        int recentPlaceNum = 0;
        string curUrl = "";
        String homepage = "http://google.ca";
        String bookmarksFile = "bookmarks.cfg";
        String recentPlacesFile = "recentplaces.cfg";

        public MainWindow()
        {
            InitializeComponent();
            if (!System.IO.File.Exists(bookmarksFile))
                System.IO.File.Create(bookmarksFile);
            else
            {
                string[] lines = System.IO.File.ReadAllLines(bookmarksFile);
                if (lines.Length != 0)
                {
                    nobookmarks.Text = "";
                    foreach (string line in lines)
                    {
                        String bookmark = urlbar.Text;
                        Button newBookmark = new Button();
                        SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                        mySolidColorBrush.Opacity = 0.1;
                        newBookmark.Background = mySolidColorBrush;
                        newBookmark.Height = 30;
                        newBookmark.Width = 100;
                        newBookmark.Content = line;
                        newBookmark.Click += newBookmark_Click;
                        newBookmark.VerticalAlignment = VerticalAlignment.Top;
                        newBookmark.HorizontalAlignment = HorizontalAlignment.Left;
                        int bookmarkplace = (bookmarkcount * 101) + 5;
                        newBookmark.Margin = new Thickness(bookmarkplace, 5, 0, 0);
                        mainGrid.Children.Add(newBookmark);
                        bookmarkcount++;
                    }
                }
            }


            if (!System.IO.File.Exists(recentPlacesFile))
                System.IO.File.Create(recentPlacesFile);
            else
            {
                string[] lines = System.IO.File.ReadAllLines(recentPlacesFile);
                if (lines.Length != 0)
                {
                    norecent.Text = "";                    
                    foreach (string line in lines)
                    {
                        String recentPlace = urlbar.Text;
                        Button newRecentPlace = new Button();
                        SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                        mySolidColorBrush.Opacity = 0.1;
                        newRecentPlace.Background = mySolidColorBrush;
                        newRecentPlace.Height = 85;
                        newRecentPlace.Width = 55;
                        newRecentPlace.Content = line;
                        newRecentPlace.Click += newRecentPlace_Click;
                        newRecentPlace.VerticalAlignment = VerticalAlignment.Top;
                        newRecentPlace.HorizontalAlignment = HorizontalAlignment.Left;
                        int recentPlacePlace = recentPlaceNum * 85 + 103;
                        newRecentPlace.Margin = new Thickness(942, recentPlacePlace, 0, 0);
                        mainGrid.Children.Add(newRecentPlace);
                        recentPlaceNum++;
                    }
                }
            }


        }

        void newRecentPlace_Click(object sender, RoutedEventArgs e)
        {
            Button clicked = (Button)sender;
            urlbar.Text = (String)clicked.Content;
            go_Click(sender, e);
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
            if (welcomeScreen.IsVisible)
            {
                welcomeScreen.Visibility = Visibility.Collapsed;
                //browserScroll.Visibility = Visibility.Visible;
                home.Visibility = Visibility.Visible;
                back.Visibility = Visibility.Visible;
                forward.Visibility = Visibility.Visible;
                refresh.Visibility = Visibility.Visible;
                urlbar.Margin = new Thickness(181, 0, 232, 18);
                go.Margin = new Thickness(0, 0, 175, 18);
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

                // add recent place             
                String recentPlace = urlbar.Text;
                if (urlbar.Text.StartsWith("http://www."))
                    recentPlace = recentPlace.Remove(0, 11);
                if (urlbar.Text.StartsWith("https://www."))
                    recentPlace = recentPlace.Remove(0, 12);
                Button newRecentPlace = new Button();
                SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                mySolidColorBrush.Opacity = 0.1;
                newRecentPlace.Background = mySolidColorBrush;
                newRecentPlace.Height = 85;
                newRecentPlace.Width = 55;
                newRecentPlace.Content = recentPlace;
                newRecentPlace.Click += newRecentPlace_Click;
                newRecentPlace.VerticalAlignment = VerticalAlignment.Top;
                newRecentPlace.HorizontalAlignment = HorizontalAlignment.Left;
                if (recentPlaceNum >= 4)
                    recentPlaceNum %= 4;
                int recentPlacePlace = recentPlaceNum * 85 + 103;
                newRecentPlace.Margin = new Thickness(942, recentPlacePlace, 0, 0);
                mainGrid.Children.Add(newRecentPlace);
                using (StreamWriter writer = new StreamWriter(recentPlacesFile, true))
                {
                    writer.WriteLine(newRecentPlace.Content);
                }
                bookmarkcount++;
                

                // navigate
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
            //urlbar.Text = "Search or enter a URL here";
        }

        private void urlbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                go_Click(sender, e);
        }

        void newBookmark_Click(object sender, RoutedEventArgs e)
        {
            Button clicked = (Button)sender;
            urlbar.Text = (String)clicked.Content;
            go_Click(sender, e);
        }

        private void home_Click_1(object sender, RoutedEventArgs e)
        {
            welcomeScreen.Visibility = Visibility.Visible;

            home.Visibility = Visibility.Collapsed;
            back.Visibility = Visibility.Collapsed;
            forward.Visibility = Visibility.Collapsed;
            refresh.Visibility = Visibility.Collapsed;
            urlbar.Margin = new Thickness(10, 0, 123, 18);
            go.Margin = new Thickness(0, 0, 66, 18);

            tab1but.Visibility = Visibility.Visible;

            if (tab1.IsVisible)
            {
                welcome.Visibility = Visibility.Collapsed;
                message1.Visibility = Visibility.Collapsed;

                tab1.IsEnabled = false;

                tab1.Margin = new Thickness(139, 92, 0, 0);
                tab1.Height = 200;
                tab1.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab1.InvokeScript("execScript", new Object[] { script, "JavaScript" });

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
            string script = "document.body.style.overflow ='visible'";
            tab1.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            tab1.Width = 1007;
            tab1.Height = 473;
            tab1.Margin = new Thickness(0, 42, 0, 0);
            tab1.IsEnabled = true;
        }

        private void bookmark_Click(object sender, RoutedEventArgs e)
        {
            if (urlbar.Text == "" || urlbar.Text == "Search or enter a URL here" || !(urlbar.Text.StartsWith("http://") || urlbar.Text.StartsWith("https://")) || !(urlbar.Text.Contains(".com") || urlbar.Text.Contains(".ca") || urlbar.Text.Contains(".net") || urlbar.Text.Contains(".org") || urlbar.Text.Contains(".tv")))
            {
                //do nothing
            }
            else
            {
                String bookmark = urlbar.Text;
                 if (urlbar.Text.StartsWith("http://www."))
                    bookmark = bookmark.Remove(0,11);
                 if (urlbar.Text.StartsWith("https://www."))
                    bookmark = bookmark.Remove(0, 12);
                Button newBookmark = new Button();
                newBookmark.Height = 30;
                newBookmark.Width = 100;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                mySolidColorBrush.Opacity = 0.1;
                newBookmark.Background = mySolidColorBrush;
                newBookmark.Content = bookmark;
                newBookmark.Click += newBookmark_Click;
                nobookmarks.Text = "";
                newBookmark.VerticalAlignment = VerticalAlignment.Top;
                newBookmark.HorizontalAlignment = HorizontalAlignment.Left;
                int bookmarkplace = (bookmarkcount * 101) + 5;
                newBookmark.Margin = new Thickness(bookmarkplace, 5, 0, 0);
                mainGrid.Children.Add(newBookmark);
                using (StreamWriter writer = new StreamWriter(bookmarksFile, true))
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
        private void settings_Click(object sender, RoutedEventArgs e)
        {
            settingsGrid.Visibility = Visibility.Visible;
            welcomeScreen.Visibility = Visibility.Collapsed;
            urlbar.Visibility = Visibility.Collapsed;
            go.Visibility = Visibility.Collapsed;
            back.Visibility = Visibility.Collapsed;
            forward.Visibility = Visibility.Collapsed;
            refresh.Visibility = Visibility.Collapsed;
            bookmark.Visibility = Visibility.Collapsed;

        }
        private void settingsBack_Click(object sender, RoutedEventArgs e)
        {
            settingsGrid.Visibility = Visibility.Collapsed;
            welcomeScreen.Visibility = Visibility.Visible;
            urlbar.Visibility = Visibility.Visible;
            go.Visibility = Visibility.Visible;
            back.Visibility = Visibility.Visible;
            forward.Visibility = Visibility.Visible;
            refresh.Visibility = Visibility.Visible;
            bookmark.Visibility = Visibility.Visible;

        }

        private void passwordEnter_Click(object sender, RoutedEventArgs e)
        {
            if (passwordEntryBox.Password == "password")
            {
                settingsGrid.Visibility = Visibility.Collapsed;
                settingsGrid2.Visibility = Visibility.Visible;
                passwordEntryBox.Password = "";
                settingsEnterPassword.Text = "Enter password to continue...";
            }
            else
            {
                settingsEnterPassword.Text = "Incorrect Password!";
            }
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            settingsGrid2.Visibility = Visibility.Collapsed;

        }
    }
}
