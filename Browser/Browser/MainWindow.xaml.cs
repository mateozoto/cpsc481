using System;
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
        int currentTab = -1;
        int openTabs = 0;
        int bookmarkcount = 0;
        string curUrl = "";
        String bookmarksFile = "bookmarks.cfg";
        String blockedSitesFile = "blockedsites.cfg";
        String recentPlacesFile = "recentplaces.cfg";
        ContextMenu menudel;
        String password = "password";
        ContextMenu morebookmarks;
        ArrayList bookmarks;

        System.Uri tab1URL;
        System.Uri tab2URL;
        System.Uri tab3URL;
        System.Uri tab4URL;

        public MainWindow()
        {
            InitializeComponent();

            bookmarks = new ArrayList();

            menudel = new ContextMenu();
            morebookmarks = new ContextMenu();
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
                        if (bookmarkcount == 9)
                        {
                            Button more = new Button();
                            more.Height = 30;
                            more.Width = 30;
                            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                            mySolidColorBrush.Opacity = 0.0;
                            more.Background = mySolidColorBrush;
                            more.BorderThickness = new Thickness(0, 0, 0, 0);
                            more.Content = ">>";
                            more.MouseLeftButtonDown += more_MouseLeftButtonDown;
                            more.MouseRightButtonUp += more_MouseRightButtonUp;
                            more.VerticalAlignment = VerticalAlignment.Top;
                            more.HorizontalAlignment = HorizontalAlignment.Left;
                            more.ContextMenu = morebookmarks;
                            more.Margin = new Thickness(929, 30, 0, 0);
                            MenuItem menubookmark = new MenuItem();
                            menubookmark.Header = line;
                            menubookmark.Click += menubookmark_Click;
                            morebookmarks.Items.Add(menubookmark);
                            mainGrid.Children.Add(more);

                        }
                        else if (bookmarkcount > 9) {
                            MenuItem menubookmark = new MenuItem();
                            menubookmark.Header = line;
                            menubookmark.Click += menubookmark_Click;
                            morebookmarks.Items.Add(menubookmark);
                        }
                        else
                        {
                            Button newBookmark = new Button();
                            SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                            mySolidColorBrush.Opacity = 0.0;
                            newBookmark.Background = mySolidColorBrush;
                            newBookmark.Height = 30;
                            newBookmark.Width = 100;
                            newBookmark.Content = line;
                            newBookmark.BorderThickness = new Thickness(1, 1, 1, 0);
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
        void more_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            morebookmarks.IsOpen = true;
        }

        void more_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

        void menubookmark_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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
                    newBookmark.BorderThickness = new Thickness(1, 1, 1, 0);
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

        private void urlbar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            Boolean parentalblock = false;
            String query = urlbar.Text;
            string[] lines = System.IO.File.ReadAllLines(blockedSitesFile);
            if (lines.Length != 0)
            {
                foreach (string line in lines)
                {
                    if (query == line)
                    {
                        MessageBox.Show("The website you are trying to enter has been blocked by parental controls.");
                        parentalblock = true;
                        break;
                    }

                }
            }
            if (parentalblock == false)
            {
                if (welcomeScreen.IsVisible)
                {
                    welcomeScreen.Visibility = Visibility.Collapsed;
                    //tab1but.Visibility = Visibility.Collapsed;
                    //tab1X.Visibility = Visibility.Collapsed;
                    //tab1.IsEnabled = true;
                    home.Visibility = Visibility.Visible;
                    back.Visibility = Visibility.Visible;
                    forward.Visibility = Visibility.Visible;
                    refresh.Visibility = Visibility.Visible;
                    urlbar.Margin = new Thickness(181, 0, 232, 18);
                    urlmask.Margin = new Thickness(181, 0, 232, 18);
                    go.Margin = new Thickness(0, 0, 175, 13);

                    openTabs++;
                    currentTab = openTabs;
                }
                //open the tab
                if (openTabs >= 1)
                {
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
                    if (currentTab == 1)
                    {
                        tab1.Visibility = Visibility.Visible;
                        tab1.Navigate(urlbar.Text);
                        tab1.Width = 1015;
                        tab1.Height = 500;
                        tab1.Margin = new Thickness(0, 65, 0, 0);
                    }
                    else if (currentTab == 2)
                    {
                        tab2.Visibility = Visibility.Visible;
                        tab2.Navigate(urlbar.Text);
                        tab2.Width = 1015;
                        tab2.Height = 500;
                        tab2.Margin = new Thickness(0, 65, 0, 0);
                    }
                    else if (currentTab == 3)
                    {
                        tab3.Visibility = Visibility.Visible;
                        tab3.Navigate(urlbar.Text);
                        tab3.Width = 1015;
                        tab3.Height = 500;
                        tab3.Margin = new Thickness(0, 65, 0, 0);
                    }
                    else if (currentTab == 4)
                    {
                        tab4.Visibility = Visibility.Visible;
                        tab4.Navigate(urlbar.Text);
                        tab4.Width = 1015;
                        tab4.Height = 500;
                        tab4.Margin = new Thickness(0, 65, 0, 0);
                    }
                }
            }
        }

        private void urlbar_GotFocus(object sender, RoutedEventArgs e)
        {
            if (urlbar.Text == "Make a search or enter a website here...")
            {
                urlbar.Text = "";
            }
        }

        private void urlbar_LostFocus(object sender, RoutedEventArgs e)
        {
            if (urlbar.Text == "")
            {
                urlbar.Text = "Make a search or enter a website here...";
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

            home.Visibility = Visibility.Collapsed;
            back.Visibility = Visibility.Collapsed;
            forward.Visibility = Visibility.Collapsed;
            refresh.Visibility = Visibility.Collapsed;
            urlbar.Margin = new Thickness(10, 0, 123, 18);
            urlmask.Margin = new Thickness(10, 0, 123, 18);
            urlmask.Width = 880;
            go.Margin = new Thickness(0, 0, 66, 13);

            currentTab = -1;

            if (openTabs >= 1)
            {
                welcome.Visibility = Visibility.Collapsed;
                message1.Visibility = Visibility.Collapsed;

                tab1.Visibility = Visibility.Visible;
                if(tab1URL != null)
                    tab1.Source = tab1URL;
                tab1but.Visibility = Visibility.Visible;
                tab1.IsEnabled = false;

                tab1.Margin = new Thickness(139, 92, 0, 0);
                tab1.Height = 200;
                tab1.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab1.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            if (openTabs >= 2)
            {
                tab2.IsEnabled = false;
                tab2.Visibility = Visibility.Visible;
                if (tab2URL != null)
                    tab2.Source = tab2URL;
                tab2but.Visibility = Visibility.Visible;

                tab2.Margin = new Thickness(546, 92, 0, 0);
                tab2.Height = 200;
                tab2.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab2.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            if (openTabs >= 3)
            {
                tab3.IsEnabled = false;
                tab3.Visibility = Visibility.Visible;
                if (tab3URL != null)
                    tab3.Source = tab3URL;
                tab3but.Visibility = Visibility.Visible;

                tab3.Margin = new Thickness(139, 310, 0, 0);
                tab3.Height = 200;
                tab3.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab3.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            if (openTabs >= 4)
            {
                tab4.IsEnabled = false;
                tab4.Visibility = Visibility.Visible;
                if (tab4URL != null)
                    tab4.Source = tab4URL;
                tab4but.Visibility = Visibility.Visible;

                tab4.Margin = new Thickness(546, 310, 0, 0);
                tab4.Height = 200;
                tab4.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab4.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            urlbar.Text = "Make a search or enter a website here...";
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
            tab1.Width = 1015;
            tab1.Height = 500;
            tab1.Margin = new Thickness(0, 65, 0, 0);
            tab1.IsEnabled = true;
            urlbar.Text = tab1.Source.OriginalString;
            back.Visibility = Visibility.Visible;
            forward.Visibility = Visibility.Visible;
            refresh.Visibility = Visibility.Visible;
            urlbar.Margin = new Thickness(181, 0, 232, 18);
            urlmask.Margin = new Thickness(181, 0, 232, 18);
            go.Margin = new Thickness(0, 0, 175, 13);

            tab2URL = tab2.Source;
            tab2.Visibility = Visibility.Collapsed;
            tab2but.Visibility = Visibility.Collapsed;

            tab3URL = tab3.Source;
            tab3.Visibility = Visibility.Collapsed;
            tab3but.Visibility = Visibility.Collapsed;

            tab4URL = tab4.Source;
            tab4.Visibility = Visibility.Collapsed;
            tab4but.Visibility = Visibility.Collapsed;
        }
        private void tab2but_Click(object sender, RoutedEventArgs e)
        {
            currentTab = 2;
            welcomeScreen.Visibility = Visibility.Collapsed;
            home.Visibility = Visibility.Visible;
            string script = "document.body.style.overflow ='visible'";
            tab2.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            tab2.Width = 1015;
            tab2.Height = 500;
            urlbar.Text = tab2.Source.OriginalString;
            tab2.Margin = new Thickness(0, 65, 0, 0);
            tab2.IsEnabled = true;
            back.Visibility = Visibility.Visible;
            forward.Visibility = Visibility.Visible;
            refresh.Visibility = Visibility.Visible;
            urlbar.Margin = new Thickness(181, 0, 232, 18);
            urlmask.Margin = new Thickness(181, 0, 232, 18);
            go.Margin = new Thickness(0, 0, 175, 13);

            tab1URL = tab1.Source;
            tab1.Visibility = Visibility.Collapsed;
            tab1but.Visibility = Visibility.Collapsed;

            tab3URL = tab3.Source;
            tab3.Visibility = Visibility.Collapsed;
            tab3but.Visibility = Visibility.Collapsed;

            tab4URL = tab4.Source;
            tab4.Visibility = Visibility.Collapsed;
            tab4but.Visibility = Visibility.Collapsed;
        }
        private void tab3but_Click(object sender, RoutedEventArgs e)
        {
            currentTab = 3;
            welcomeScreen.Visibility = Visibility.Collapsed;
            home.Visibility = Visibility.Visible;
            string script = "document.body.style.overflow ='visible'";
            tab3.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            tab3.Width = 1015;
            tab3.Height = 500;
            tab3.Margin = new Thickness(0, 65, 0, 0);
            tab3.IsEnabled = true;
            urlbar.Text = tab3.Source.OriginalString;

            back.Visibility = Visibility.Visible;
            forward.Visibility = Visibility.Visible;
            refresh.Visibility = Visibility.Visible;
            urlbar.Margin = new Thickness(181, 0, 232, 18);
            urlmask.Margin = new Thickness(181, 0, 232, 18);
            go.Margin = new Thickness(0, 0, 175, 13);

            tab1URL = tab1.Source;
            tab1.Visibility = Visibility.Collapsed;
            tab1but.Visibility = Visibility.Collapsed;

            tab2URL = tab2.Source;
            tab2.Visibility = Visibility.Collapsed;
            tab2but.Visibility = Visibility.Collapsed;

            tab4URL = tab4.Source;
            tab4.Visibility = Visibility.Collapsed;
            tab4but.Visibility = Visibility.Collapsed;
        }
        private void tab4but_Click(object sender, RoutedEventArgs e)
        {
            currentTab = 4;
            welcomeScreen.Visibility = Visibility.Collapsed;
            home.Visibility = Visibility.Visible;
            string script = "document.body.style.overflow ='visible'";
            tab4.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            tab4.Width = 1015;
            tab4.Height = 500;
            urlbar.Text = tab4.Source.OriginalString;
            tab4.Margin = new Thickness(0, 65, 0, 0);
            tab4.IsEnabled = true;
            back.Visibility = Visibility.Visible;
            forward.Visibility = Visibility.Visible;
            refresh.Visibility = Visibility.Visible;
            urlbar.Margin = new Thickness(181, 0, 232, 18);
            urlmask.Margin = new Thickness(181, 0, 232, 18);
            go.Margin = new Thickness(0, 0, 175, 13);

            tab1URL = tab2.Source;
            tab1.Visibility = Visibility.Collapsed;
            tab1but.Visibility = Visibility.Collapsed;

            tab2URL = tab2.Source;
            tab2.Visibility = Visibility.Collapsed;
            tab2but.Visibility = Visibility.Collapsed;

            tab3URL = tab2.Source;
            tab3.Visibility = Visibility.Collapsed;
            tab3but.Visibility = Visibility.Collapsed;
        }

        private void bookmark_Click(object sender, RoutedEventArgs e)
        {
            bool skip = false;
            if (urlbar.Text == "" || urlbar.Text == "Make a search or enter a website here..." || !(urlbar.Text.StartsWith("http://") || urlbar.Text.StartsWith("https://")) || !(urlbar.Text.Contains(".com") || urlbar.Text.Contains(".ca") || urlbar.Text.Contains(".net") || urlbar.Text.Contains(".org") || urlbar.Text.Contains(".tv")))
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
                if (bookmarkcount == 9)
                {
                    Button more = new Button();
                    more.Height = 30;
                    more.Width = 30;
                    SolidColorBrush mySolidColorBrush = new SolidColorBrush(Colors.Gray);
                    mySolidColorBrush.Opacity = 0.0;
                    more.Background = mySolidColorBrush;
                    more.BorderThickness = new Thickness(0, 0, 0, 0);
                    more.Content = ">>";
                    more.MouseLeftButtonDown += more_MouseLeftButtonDown;
                    more.MouseRightButtonUp += more_MouseRightButtonUp;
                    more.VerticalAlignment = VerticalAlignment.Top;
                    more.HorizontalAlignment = HorizontalAlignment.Left;
                    more.ContextMenu = morebookmarks;
                    more.Margin = new Thickness(929, 30, 0, 0);
                    MenuItem menubookmark = new MenuItem();
                    menubookmark.Header = bookmark;
                    menubookmark.Click += menubookmark_Click;
                    morebookmarks.Items.Add(menubookmark);
                    bookmarks.Add(more);
                    using (StreamWriter writer = new StreamWriter(bookmarksFile, true))
                    {
                        writer.WriteLine(menubookmark.Header);
                    }

                }
                else if (bookmarkcount > 9)
                {
                    MenuItem menubookmark = new MenuItem();
                    menubookmark.Header = bookmark;
                    menubookmark.Click += menubookmark_Click;
                    morebookmarks.Items.Add(menubookmark);
                    using (StreamWriter writer = new StreamWriter(bookmarksFile, true))
                    {
                        writer.WriteLine(menubookmark.Header);
                    }
                }
                else
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
            settingsRectangle.Visibility = Visibility.Visible;
            settingslabel.Visibility = Visibility.Visible;
            welcomeScreen.Visibility = Visibility.Collapsed;
            recentplacesrectangle.Visibility = Visibility.Collapsed;
            recentplacesrectangle_Copy.Visibility = Visibility.Collapsed;
            recentplacesrectangle_Copy1.Visibility = Visibility.Collapsed;
            recentplacesrectangle_Copy2.Visibility = Visibility.Collapsed;
            recentButton1.Visibility = Visibility.Collapsed;
            recentButton2.Visibility = Visibility.Collapsed;
            recentButton3.Visibility = Visibility.Collapsed;
            recentButton4.Visibility = Visibility.Collapsed;
            urlbar.Visibility = Visibility.Collapsed;
            go.Visibility = Visibility.Collapsed;
            back.Visibility = Visibility.Collapsed;
            forward.Visibility = Visibility.Collapsed;
            refresh.Visibility = Visibility.Collapsed;
            bookmark.Visibility = Visibility.Collapsed;
            urlmask.Visibility = Visibility.Collapsed;

            tab1URL = tab1.Source;
            tab2URL = tab2.Source;
            tab3URL = tab3.Source;
            tab4URL = tab4.Source;

            tab1.Visibility = Visibility.Collapsed;
            tab1but.Visibility = Visibility.Collapsed;
            tab2.Visibility = Visibility.Collapsed;
            tab2but.Visibility = Visibility.Collapsed;
            tab3.Visibility = Visibility.Collapsed;
            tab3but.Visibility = Visibility.Collapsed;
            tab4.Visibility = Visibility.Collapsed;
            tab4but.Visibility = Visibility.Collapsed;

        }
        private void settingsBack_Click(object sender, RoutedEventArgs e)
        {
            settingsGrid.Visibility = Visibility.Visible;
            passwordEntry.Visibility = Visibility.Collapsed;
            settingsRectangle.Visibility = Visibility.Visible;
            passwordEntryBox.Password = "";
            settingsEnterPassword.Text = "Please enter a valid password to access parental controls.";
        }

        private void passwordEnter_Click(object sender, RoutedEventArgs e)
        {
            if (passwordEntryBox.Password == password)
            {
                passwordEntry.Visibility = Visibility.Collapsed;
                parentalControls.Visibility = Visibility.Visible;
                passwordEntryBox.Password = "";
                settingsEnterPassword.Text = "Please enter a valid password to access parental controls.";
            }
            else
            {
                settingsEnterPassword.Text = "Incorrect Password!";
            }
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            settingsRectangle.Visibility = Visibility.Collapsed;
            parentalControls.Visibility = Visibility.Collapsed;
            welcomeScreen.Visibility = Visibility.Visible;
            urlbar.Visibility = Visibility.Visible;
            go.Visibility = Visibility.Visible;
            recentplacesrectangle.Visibility = Visibility.Visible;
            recentplacesrectangle_Copy.Visibility = Visibility.Visible;
            recentplacesrectangle_Copy1.Visibility = Visibility.Visible;
            recentplacesrectangle_Copy2.Visibility = Visibility.Visible;
            settingslabel.Visibility = Visibility.Collapsed;
            back.Visibility = Visibility.Collapsed;
            forward.Visibility = Visibility.Collapsed;
            refresh.Visibility = Visibility.Collapsed;
            bookmark.Visibility = Visibility.Visible;
            urlmask.Visibility = Visibility.Visible;
            currentTab = -1;

            if (openTabs >= 1)
            {
                welcome.Visibility = Visibility.Collapsed;
                message1.Visibility = Visibility.Collapsed;

                tab1.Visibility = Visibility.Visible;
                if (tab1URL != null)
                    tab1.Source = tab1URL;
                tab1but.Visibility = Visibility.Visible;
                tab1.IsEnabled = false;

                tab1.Margin = new Thickness(139, 92, 0, 0);
                tab1.Height = 200;
                tab1.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab1.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            if (openTabs >= 2)
            {
                tab2.IsEnabled = false;
                tab2.Visibility = Visibility.Visible;
                if (tab2URL != null)
                    tab2.Source = tab2URL;
                tab2but.Visibility = Visibility.Visible;

                tab2.Margin = new Thickness(546, 92, 0, 0);
                tab2.Height = 200;
                tab2.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab2.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            if (openTabs >= 3)
            {
                tab3.IsEnabled = false;
                tab3.Visibility = Visibility.Visible;
                if (tab3URL != null)
                    tab3.Source = tab3URL;
                tab3but.Visibility = Visibility.Visible;

                tab3.Margin = new Thickness(139, 310, 0, 0);
                tab3.Height = 200;
                tab3.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab3.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            if (openTabs >= 4)
            {
                tab4.IsEnabled = false;
                tab4.Visibility = Visibility.Visible;
                if (tab4URL != null)
                    tab4.Source = tab4URL;
                tab4but.Visibility = Visibility.Visible;

                tab4.Margin = new Thickness(546, 310, 0, 0);
                tab4.Height = 200;
                tab4.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab4.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
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

        private void settingsGridExit_Click(object sender, RoutedEventArgs e)
        {
            settingsGrid.Visibility = Visibility.Collapsed;
            settingsRectangle.Visibility = Visibility.Collapsed;
            settingslabel.Visibility = Visibility.Collapsed;
            welcomeScreen.Visibility = Visibility.Visible;
            urlbar.Visibility = Visibility.Visible;
            go.Visibility = Visibility.Visible;
            back.Visibility = Visibility.Collapsed;
            urlmask.Visibility = Visibility.Visible;
            forward.Visibility = Visibility.Collapsed;
            recentplacesrectangle.Visibility = Visibility.Visible;
            recentplacesrectangle_Copy.Visibility = Visibility.Visible;
            recentplacesrectangle_Copy1.Visibility = Visibility.Visible;
            recentplacesrectangle_Copy2.Visibility = Visibility.Visible;
            refresh.Visibility = Visibility.Collapsed;
            bookmark.Visibility = Visibility.Visible;
            currentTab = -1;
            if (openTabs >= 1)
            {
                welcome.Visibility = Visibility.Collapsed;
                message1.Visibility = Visibility.Collapsed;

                tab1.Visibility = Visibility.Visible;
                if (tab1URL != null)
                    tab1.Source = tab1URL;
                tab1but.Visibility = Visibility.Visible;
                tab1.IsEnabled = false;

                tab1.Margin = new Thickness(139, 92, 0, 0);
                tab1.Height = 200;
                tab1.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab1.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            if (openTabs >= 2)
            {
                tab2.IsEnabled = false;
                tab2.Visibility = Visibility.Visible;
                if (tab2URL != null)
                    tab2.Source = tab2URL;
                tab2but.Visibility = Visibility.Visible;

                tab2.Margin = new Thickness(546, 92, 0, 0);
                tab2.Height = 200;
                tab2.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab2.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            if (openTabs >= 3)
            {
                tab3.IsEnabled = false;
                tab3.Visibility = Visibility.Visible;
                if (tab3URL != null)
                    tab3.Source = tab3URL;
                tab3but.Visibility = Visibility.Visible;

                tab3.Margin = new Thickness(139, 310, 0, 0);
                tab3.Height = 200;
                tab3.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab3.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
            if (openTabs >= 4)
            {
                tab4.IsEnabled = false;
                tab4.Visibility = Visibility.Visible;
                if (tab4URL != null)
                    tab4.Source = tab4URL;
                tab4but.Visibility = Visibility.Visible;

                tab4.Margin = new Thickness(546, 310, 0, 0);
                tab4.Height = 200;
                tab4.Width = 343;
                string script = "document.body.style.overflow ='hidden'";
                tab4.InvokeScript("execScript", new Object[] { script, "JavaScript" });
            }
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

        private void bookmarksButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void parentalSettings_Click(object sender, RoutedEventArgs e)
        {
            passwordEntry.Visibility = Visibility.Visible;
            settingsGrid.Visibility = Visibility.Collapsed;
        }

        private void tab1but_MouseEnter(object sender, MouseEventArgs e)
        {
            tab1X.Visibility = Visibility.Visible;
        }

        private void tab1but_MouseLeave(object sender, MouseEventArgs e)
        {
            tab1X.Visibility = Visibility.Collapsed;
        }

        private void tab1X_MouseEnter(object sender, MouseEventArgs e)
        {
            tab1X.Visibility = Visibility.Visible;
        }

        private void tab1X_MouseLeave(object sender, MouseEventArgs e)
        {
            tab1X.Visibility = Visibility.Collapsed;
        }

        private void tab2but_MouseEnter(object sender, MouseEventArgs e)
        {
            tab2X.Visibility = Visibility.Visible;
        }

        private void tab2but_MouseLeave(object sender, MouseEventArgs e)
        {
            tab2X.Visibility = Visibility.Collapsed;
        }

        private void tab2X_MouseEnter(object sender, MouseEventArgs e)
        {
            tab2X.Visibility = Visibility.Visible;
        }

        private void tab2X_MouseLeave(object sender, MouseEventArgs e)
        {
            tab2X.Visibility = Visibility.Collapsed;
        }

        private void tab3but_MouseEnter(object sender, MouseEventArgs e)
        {
            tab3X.Visibility = Visibility.Visible;
        }

        private void tab3but_MouseLeave(object sender, MouseEventArgs e)
        {
            tab3X.Visibility = Visibility.Collapsed;
        }

        private void tab3X_MouseEnter(object sender, MouseEventArgs e)
        {
            tab3X.Visibility = Visibility.Visible;
        }

        private void tab3X_MouseLeave(object sender, MouseEventArgs e)
        {
            tab3X.Visibility = Visibility.Collapsed;
        }

        private void tab4but_MouseEnter(object sender, MouseEventArgs e)
        {
            tab4X.Visibility = Visibility.Visible;
        }

        private void tab4but_MouseLeave(object sender, MouseEventArgs e)
        {
            tab4X.Visibility = Visibility.Collapsed;
        }

        private void tab4X_MouseEnter(object sender, MouseEventArgs e)
        {
            tab4X.Visibility = Visibility.Visible;
        }

        private void tab4X_MouseLeave(object sender, MouseEventArgs e)
        {
            tab4X.Visibility = Visibility.Collapsed;
        }

        private void tab1X_Click(object sender, RoutedEventArgs e)
        {
            if (openTabs == 1)
            {
                tab1.Visibility = Visibility.Collapsed;
                tab1but.Visibility = Visibility.Collapsed;
                welcome.Visibility = Visibility.Visible;
                message1.Visibility = Visibility.Visible;
            }
            else if (openTabs == 2)
            {
                tab1.Source = tab2.Source;
                tab2.Visibility = Visibility.Collapsed;
                tab2but.Visibility = Visibility.Collapsed;
            }
            else if (openTabs == 3)
            {
                tab1.Source = tab2.Source;
                tab2.Source = tab3.Source;
                tab3.Visibility = Visibility.Collapsed;
                tab3but.Visibility = Visibility.Collapsed;
            }
            else if (openTabs == 4)
            {
                tab1.Source = tab2.Source;
                tab2.Source = tab3.Source;
                tab3.Source = tab4.Source;
                tab4.Visibility = Visibility.Collapsed;
                tab4but.Visibility = Visibility.Collapsed;
            }

            openTabs--;
        }

        private void tab2X_Click(object sender, RoutedEventArgs e)
        {
            if (openTabs == 2)
            {
                tab2.Visibility = Visibility.Collapsed;
                tab2but.Visibility = Visibility.Collapsed;
            }
            else if (openTabs == 3)
            {
                tab2.Source = tab3.Source;
                tab3.Visibility = Visibility.Collapsed;
                tab3but.Visibility = Visibility.Collapsed;
            }
            else if (openTabs == 4)
            {
                tab2.Source = tab3.Source;
                tab3.Source = tab4.Source;
                tab4.Visibility = Visibility.Collapsed;
                tab4but.Visibility = Visibility.Collapsed;
            }

            openTabs--;
        }

        private void tab3X_Click(object sender, RoutedEventArgs e)
        {
            if (openTabs == 3)
            {
                tab3.Visibility = Visibility.Collapsed;
                tab3but.Visibility = Visibility.Collapsed;
            }
            else if (openTabs == 4)
            {
                tab3.Source = tab4.Source;
                tab4.Visibility = Visibility.Collapsed;
                tab4but.Visibility = Visibility.Collapsed;
            }

            openTabs--;
        }

        private void tab4X_Click(object sender, RoutedEventArgs e)
        {
            tab4.Visibility = Visibility.Collapsed;
            tab4but.Visibility = Visibility.Collapsed;

            openTabs--;
        }


        private void safeSearchCheckbox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (safeSearchCheckbox.IsChecked == true)
            {
                safeSearchButton.IsEnabled = true;
            }
            if (safeSearchCheckbox.IsChecked == false)
            {
                safeSearchButton.IsEnabled = false;
            }
        }

        private void blockURLTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (blockURLTextBox.Text == "Enter URL to Block")
            {
                blockURLTextBox.Text = "";
            }

        }

        private void settingsBlockedSites_Click(object sender, RoutedEventArgs e)
        {

            blockedSitesGrid.Visibility = Visibility.Visible;
            passwordChangeGrid.Visibility = Visibility.Collapsed;
        }

        private void addBlockedButton_Click(object sender, RoutedEventArgs e)
        {
            blockedSitesGrid.Visibility = Visibility.Collapsed;
            blockURLGrid.Visibility = Visibility.Visible;
        }

        private void blockURLAcceptButton_Click(object sender, RoutedEventArgs e)
        {
            blockedSitesListbox.Items.Add(blockURLTextBox.Text);
            blockURLGrid.Visibility = Visibility.Collapsed;
            blockedSitesGrid.Visibility = Visibility.Visible;
        }

        private void removeBlockedButton_Click(object sender, RoutedEventArgs e)
        {
            blockedSitesListbox.Items.Remove(blockedSitesListbox.SelectedItem);
        }

        private void acceptBlockedButton_Click(object sender, RoutedEventArgs e)
        {
            blockedSitesGrid.Visibility = Visibility.Collapsed;
        }

        private void cancelPassword_Click(object sender, RoutedEventArgs e)
        {
            passwordChangeGrid.Visibility = Visibility.Collapsed;
            enterOldPassword.Text = "Enter your old password";
            oldPassword.Password = "";
            newPassword.Password = "";
        }

        private void passwordChangeButton_Click(object sender, RoutedEventArgs e)
        {
            blockedSitesGrid.Visibility = Visibility.Collapsed;
            passwordChangeGrid.Visibility = Visibility.Visible;
        }

        private void acceptPassword_Click(object sender, RoutedEventArgs e)
        {
            if (oldPassword.Password != password)
            {
                enterOldPassword.Text = "Password didn't match!";
            }
            if (oldPassword.Password == password)
            {
                password = newPassword.Password;
                passwordChangeGrid.Visibility = Visibility.Collapsed;
                enterOldPassword.Text = "Enter your old password";
                oldPassword.Password = "";
                newPassword.Password = "";
                //password change confirmation here
            }


           
        }
    }
}
