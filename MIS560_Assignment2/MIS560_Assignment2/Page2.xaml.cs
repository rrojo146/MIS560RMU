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
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void txbNoteEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.txbNoteEntry.Text != "")
            {
                IsolatedStorageSettings.ApplicationSettings["lstNoteList"] = (this.txbNoteEntry.Text);
            }
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            //TODO Do I need someething here?
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            //TODO save textbox text here

            base.OnBackKeyPress(e);
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            //TODO load the data that was selected
            base.OnNavigatedTo(e);

        }
    }
}