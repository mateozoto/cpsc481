﻿using System;
using System.Collections;
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
        String bookmarksFile = "bookmarks.cfg";
        String recentPlacesFile = "recentplaces.cfg";
        ContextMenu menudel;
        ArrayList bookmarks;

        public MainWindow()
        {
            InitializeComponent();

            bookmarks = new ArrayList();

            menudel = new ContextMenu();
            MenuItem itemdel = new MenuItem();
            itemdel.Header = "Delete";
            itemdel.Click += itemdel_Click;
            menudel.Items.Add(itemdel);


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
                        Button newBookmark = new Button();
                        SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                        mySolidColorBrush.Opacity = 0.0;
                        newBookmark.Background = mySolidColorBrush;
                        newBookmark.Height = 30;
                        newBookmark.Width = 100;
                        newBookmark.Content = line;
                        newBookmark.ToolTip = line;
                        newBookmark.ContextMenu = menudel;
                        newBookmark.Click += newBookmark_Click;
                        newBookmark.VerticalAlignment = VerticalAlignment.Top;
                        newBookmark.HorizontalAlignment = HorizontalAlignment.Left;
                        int bookmarkplace = (bookmarkcount * 101) + 5;
                        newBookmark.Margin = new Thickness(bookmarkplace, 30, 0, 0);
                        mainGrid.Children.Add(newBookmark);
                        bookmarks.Add(newBookmark);
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
                    int recentPlaceNum = 0;
                    foreach (string line in lines)
                    {
                        if (recentPlaceNum == 0)
                        {
                            recentButton1.Content = line;
                            recentButton1.ToolTip = line;
                            recentButton1.Visibility = Visibility.Visible;
                        }
                        else if (recentPlaceNum == 1)
                        {
                            recentButton2.Content = line;
                            recentButton2.ToolTip = line;
                            recentButton2.Visibility = Visibility.Visible;
                        }
                        else if (recentPlaceNum == 2)
                        {
                            recentButton3.Content = line;
                            recentButton3.ToolTip = line;
                            recentButton3.Visibility = Visibility.Visible;
                        }
                        else if (recentPlaceNum == 3)
                        {
                            recentButton4.Content = line;
                            recentButton4.ToolTip = line;
                            recentButton4.Visibility = Visibility.Visible;
                        }

                        recentPlaceNum++;
                    }
                }
            }


        }

        void itemdel_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            ContextMenu owner = (ContextMenu)item.Parent;
            Button clicked = (Button)owner.PlacementTarget;

            string[] lines = System.IO.File.ReadAllLines(bookmarksFile);
            int index = 0;
            foreach (string line in lines)
            {
                if (line.Equals((String)clicked.Content))
                    break;
                index++;
            }
            for (int i = index; i < lines.Length - 1; i++)
            {
                lines[i] = lines[i + 1];
            }
            using (StreamWriter writer = new StreamWriter(bookmarksFile, false))
            {
                for (int i = 0; i < lines.Length - 1; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }



            foreach (Button b in bookmarks)
            {
                mainGrid.Children.Remove(b);
            }
            bookmarks = new ArrayList();

            bookmarkcount = 0;

            if (lines.Length != 0)
            {
                nobookmarks.Text = "";
                for (int i = 0; i < lines.Length - 1; i++)
                {
                    string line = lines[i];
                    Button newBookmark = new Button();
                    SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                    mySolidColorBrush.Opacity = 0.0;
                    newBookmark.Background = mySolidColorBrush;
                    newBookmark.Height = 30;
                    newBookmark.Width = 100;
                    newBookmark.Content = line;
                    newBookmark.ToolTip = line;
                    newBookmark.ContextMenu = menudel;
                    newBookmark.Click += newBookmark_Click;
                    newBookmark.VerticalAlignment = VerticalAlignment.Top;
                    newBookmark.HorizontalAlignment = HorizontalAlignment.Left;
                    int bookmarkplace = (bookmarkcount * 101) + 5;
                    newBookmark.Margin = new Thickness(bookmarkplace, 30, 0, 0);
                    mainGrid.Children.Add(newBookmark);
                    bookmarks.Add(newBookmark);
                    bookmarkcount++;
                }
            }
            if (bookmarkcount == 0) {
                nobookmarks.Text = "No bookmarks";
            }

        }

        void recentPlace_Click(object sender, RoutedEventArgs e)
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
                tab1but.Visibility = Visibility.Collapsed;
                tab1.IsEnabled = true;
                //browserScroll.Visibility = Visibility.Visible;
                home.Visibility = Visibility.Visible;
                back.Visibility = Visibility.Visible;
                forward.Visibility = Visibility.Visible;
                refresh.Visibility = Visibility.Visible;
                urlbar.Margin = new Thickness(181, 0, 232, 18);
                go.Margin = new Thickness(0, 0, 175, 13);
                
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
                norecent.Text = "";
                String recentPlace = urlbar.Text;
                if (urlbar.Text.StartsWith("http://www."))
                    recentPlace = recentPlace.Remove(0, 11);
                else if (urlbar.Text.StartsWith("https://www."))
                    recentPlace = recentPlace.Remove(0, 12);
                else if (urlbar.Text.StartsWith("https://"))
                    recentPlace = recentPlace.Remove(0, 8);
                else if (urlbar.Text.StartsWith("http://"))
                    recentPlace = recentPlace.Remove(0, 7);

                string[] lines = System.IO.File.ReadAllLines(recentPlacesFile);
                bool skip = false;
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (recentPlace.Equals(line))
                    {
                        skip = true;
                        for (int j = i; j < lines.Length - 1; j++)
                        {
                            string temp = lines[j + 1];
                            lines[j + 1] = lines[j];
                            lines[j] = temp;
                        }
                        using (StreamWriter writer = new StreamWriter(recentPlacesFile, false))
                        {
                            for (int j = 0; j < lines.Length; j++)
                            {
                                writer.WriteLine(lines[j]);
                            }
                        }
                        if (lines.Length >= 1)
                        {
                            recentButton1.Content = lines[0];
                            recentButton1.ToolTip = lines[0];
                        }
                        if (lines.Length >= 2)
                        {
                            recentButton2.Content = lines[1];
                            recentButton2.ToolTip = lines[1];
                        }
                        if (lines.Length >= 3)
                        {
                            recentButton3.Content = lines[2];
                            recentButton3.ToolTip = lines[2];
                        }
                        if (lines.Length >= 4)
                        {
                            recentButton4.Content = lines[3];
                            recentButton4.ToolTip = lines[3];
                        }
                        break;
                    }
                }
                if (!skip)
                {
                    if (lines.Length >= 4)
                    {
                        lines[0] = lines[1];
                        lines[1] = lines[2];
                        lines[2] = lines[3];
                        lines[3] = recentPlace;

                        recentButton1.Content = recentButton2.Content;
                        recentButton1.ToolTip = recentButton2.Content;
                        recentButton2.Content = recentButton3.Content;
                        recentButton2.ToolTip = recentButton3.Content;
                        recentButton3.Content = recentButton4.Content;
                        recentButton3.ToolTip = recentButton4.Content;
                        recentButton4.Content = recentPlace;
                        recentButton4.ToolTip = recentPlace;

                        using (StreamWriter writer = new StreamWriter(recentPlacesFile, false))
                        {
                            for (int i = 0; i < lines.Length; i++)
                            {
                                writer.WriteLine(lines[i]);
                            }
                        }
                    }
                    else
                    {
                        if (lines.Length == 0)
                        {
                            recentButton1.Content = recentPlace;
                            recentButton1.ToolTip = recentPlace;
                            recentButton1.Visibility = Visibility.Visible;
                        }
                        else if (lines.Length == 1)
                        {
                            recentButton2.Content = recentPlace;
                            recentButton2.ToolTip = recentPlace;
                            recentButton2.Visibility = Visibility.Visible;
                        }
                        else if (lines.Length == 2)
                        {
                            recentButton3.Content = recentPlace;
                            recentButton3.ToolTip = recentPlace;
                            recentButton3.Visibility = Visibility.Visible;
                        }
                        else if (lines.Length == 3)
                        {
                            recentButton4.Content = recentPlace;
                            recentButton4.ToolTip = recentPlace;
                            recentButton4.Visibility = Visibility.Visible;
                        }

                        using (StreamWriter writer = new StreamWriter(recentPlacesFile, true))
                        {
                            writer.WriteLine(recentPlace);
                        }
                    }
                }

                // navigate
                tab1.Visibility = Visibility.Visible;
                tab1.Navigate(urlbar.Text);
                tab1.Width = 1015;
                tab1.Height = 473;
                tab1.Margin = new Thickness(0, 100, 0, 0);
               
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
            if (urlbar.Text == "")
            {
                urlbar.Text = "Search or enter a URL here";
            }
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
            urlbar.Text = "Search or enter a URL here";

            home.Visibility = Visibility.Collapsed;
            back.Visibility = Visibility.Collapsed;
            forward.Visibility = Visibility.Collapsed;
            refresh.Visibility = Visibility.Collapsed;
            urlbar.Margin = new Thickness(10, 0, 123, 18);
            go.Margin = new Thickness(0, 0, 66, 13);

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
            tab1.Margin = new Thickness(0, 100, 0, 0);
            tab1.IsEnabled = true;
            back.Visibility = Visibility.Visible;
            forward.Visibility = Visibility.Visible;
            refresh.Visibility = Visibility.Visible;
            urlbar.Margin = new Thickness(181, 0, 232, 18);
            go.Margin = new Thickness(0, 0, 175, 13);
        }

        private void bookmark_Click(object sender, RoutedEventArgs e)
        {
            bool skip = false;
            if (urlbar.Text == "" || urlbar.Text == "Search or enter a URL here" || !(urlbar.Text.StartsWith("http://") || urlbar.Text.StartsWith("https://")) || !(urlbar.Text.Contains(".com") || urlbar.Text.Contains(".ca") || urlbar.Text.Contains(".net") || urlbar.Text.Contains(".org") || urlbar.Text.Contains(".tv")))
            {
                skip=true;
            }

            String bookmark = urlbar.Text;
            if (urlbar.Text.StartsWith("http://www."))
                bookmark = bookmark.Remove(0, 11);
            if (urlbar.Text.StartsWith("https://www."))
                bookmark = bookmark.Remove(0, 12);

            string[] lines = System.IO.File.ReadAllLines(bookmarksFile);            
            foreach (string line in lines) {
                if (line.Equals(bookmark))
                {
                    skip = true;
                    break;
                }
            }

            if (!skip)
            {
                Button newBookmark = new Button();
                newBookmark.Height = 30;
                newBookmark.Width = 100;
                SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                mySolidColorBrush.Opacity = 0.0;
                newBookmark.Background = mySolidColorBrush;
                newBookmark.Content = bookmark;
                newBookmark.ToolTip = bookmark;
                newBookmark.ContextMenu = menudel;
                newBookmark.Click += newBookmark_Click;
                nobookmarks.Text = "";
                newBookmark.VerticalAlignment = VerticalAlignment.Top;
                newBookmark.HorizontalAlignment = HorizontalAlignment.Left;
                int bookmarkplace = (bookmarkcount * 101) + 5;
                newBookmark.Margin = new Thickness(bookmarkplace, 30, 0, 0);
                mainGrid.Children.Add(newBookmark);
                bookmarks.Add(newBookmark);
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
            settingsRectangle.Visibility = Visibility.Visible;
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
            settingsRectangle.Visibility = Visibility.Collapsed;
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
            settingsRectangle.Visibility = Visibility.Collapsed;
            settingsGrid2.Visibility = Visibility.Collapsed;
            welcomeScreen.Visibility = Visibility.Visible;
            urlbar.Visibility = Visibility.Visible;
            go.Visibility = Visibility.Visible;
            back.Visibility = Visibility.Visible;
            forward.Visibility = Visibility.Visible;
            refresh.Visibility = Visibility.Visible;
            bookmark.Visibility = Visibility.Visible;

        }

        private void ExitButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void HeaderGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CheckBox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (timeRestrictCheck.IsChecked == true)
            {
                startTime.IsEnabled = true;
                endTime.IsEnabled = true;
            }
            if (timeRestrictCheck.IsChecked == false)
            {
                startTime.IsEnabled = false;
                endTime.IsEnabled = false;
            }
        }
    }
}
