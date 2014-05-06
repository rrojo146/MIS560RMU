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
            

        }
     

        private void txtBlk01_Tap(object sender, GestureEventArgs e)
        {
            msgBlock.Text = "You Have clicked TextBlock1";
        }

        private void txtBlk02_Tap(object sender, GestureEventArgs e)
        {
            msgBlock.Text = "You Have clicked TextBlock2";
        }

        private void txtBlk03_Tap(object sender, GestureEventArgs e)
        {
            msgBlock.Text = "You Have clicked TextBlock3";
        }

        private void bicyclepic01_Tap(object sender, GestureEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://www.robertmorris.edu");
            webBrowserTask.Show();
        }
    }
}