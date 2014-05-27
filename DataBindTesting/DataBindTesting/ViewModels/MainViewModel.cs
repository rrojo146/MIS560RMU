using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace DataBindTesting
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { LineOne = "Grocery list", LineTwo = "apples eggs bread cereal spaghetti", LineThree = "apples", LineFour = "eggs", LineFive = "bread", LineSix = "cereal spaghetti " });
            this.Items.Add(new ItemViewModel() { LineOne = "TODO LIST", LineTwo = "Laundry upstairs Make dinner Return clothes", LineThree = "Laundry upstairs Make dinner Return clothes Call doctor Pay house bills" });
            this.Items.Add(new ItemViewModel() { LineOne = "Dimensions", LineTwo = "60 Inches by 42 inches", LineThree = "60 Inches by 42 inches" });
            this.Items.Add(new ItemViewModel() { LineOne = "Router", LineTwo = "Router password", LineThree = "Router password: CFFA7599ab" });
            this.Items.Add(new ItemViewModel() { LineOne = "Email Bob", LineTwo = "email Bob Smith", LineThree = "email Bob Smith bill.smith@windowsmsdn.com" });
            this.Items.Add(new ItemViewModel() { LineOne = "Watchlist", LineTwo = "Favorite shows", LineThree = "Godfather I", LineFour = "Office Space", LineFive = "Pulp Fiction" });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}