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
using System.Runtime.Serialization;
using System.IO;//for isolated storage

namespace rrojo_assignment2
{
    public partial class EditPage : PhoneApplicationPage
    {
        public EditPage()
        {
            InitializeComponent();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (NavigationContext.QueryString.ContainsKey("note"))
            {
                string strFileName = this.NavigationContext.QueryString["note"];
                if (!string.IsNullOrEmpty(strFileName))
                {
                    using (var store = System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication())
                    using (var stream = new IsolatedStorageFileStream(strFileName, FileMode.Open, FileAccess.ReadWrite, store))
                    {
                        StreamReader stmReader = new StreamReader(stream);
                        this.tbxNote.Text = stmReader.ReadToEnd();
                        this.tbxNotename.Text = strFileName;
                        stmReader.Close();
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var store = System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication())
                using (var stream = new IsolatedStorageFileStream(tbxNotename.Text, FileMode.Create, FileAccess.Write, store))
                {
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write(tbxNote.Text);
                    writer.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't save the file.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var store = System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForApplication())
            {
                store.DeleteFile(tbxNotename.Text);
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
           
        }
    }
}