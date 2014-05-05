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
using Microsoft.Phone.Tasks;

namespace Assignment1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            txtBlk01.MouseLeftButtonUp += new MouseButtonEventHandler(txtBlk01_MouseLeftButtonUp);
            txtBlk02.MouseLeftButtonUp += new MouseButtonEventHandler(txtBlk02_MouseLeftButtonUp);
            txtBlk03.MouseLeftButtonUp += new MouseButtonEventHandler(txtBlk03_MouseLeftButtonUp);
            bicyclepic01.MouseLeftButtonUp += new MouseButtonEventHandler(bicyclepic01_MouseLeftButtonUp);

        }
        void txtBlk01_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            msgBlock.Text = "You Have clicked TextBlock1";

        }
        void txtBlk02_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            msgBlock.Text = "You Have clicked TextBlock2";
        }
        void txtBlk03_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            msgBlock.Text = "You Have clicked TextBlock3";
        }
        void bicyclepic01_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://www.robertmorris.edu");
            webBrowserTask.Show();
        }
    }
}