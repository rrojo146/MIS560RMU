using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO.IsolatedStorage;

namespace MIS560_Assignment2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void newNoteBtn_Click(object sender, RoutedEventArgs e)
        {
            //IsolatedStorageSettings.ApplicationSettings["uName"] = txtBox1.Text;
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

        private void MainListNote_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}