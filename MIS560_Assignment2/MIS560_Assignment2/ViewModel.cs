﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;    //Needed for Notify property change
using System.Collections.ObjectModel; //for observable collection

namespace MIS560_Assignment2
{
    public class ViewModel : INotifyPropertyChanged 
    {
        #region Notify Property logic
        public event PropertyChangedEventHandler PropertyChanged;

        // NotifyPropertyChanged will raise the PropertyChanged event passing the
        // source property that is being updated.
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public ViewModel()
        {
            NoteList = new ObservableCollection<string>();
            NoteList.Add("Temp");
            NoteList.Add("Temp2");
        }

        public ObservableCollection<string> NoteList {get;set;}

        private string _SelectedItem;

        public string SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                NotifyPropertyChanged("SelectedItem");
                //_TextboxString = _SelectedItem;
            }
        }
       
        #region Command logic
        public ICommand ButtonCommand
        {
            get
            {
                return new DelegateCommand(SetToList, CanSetToList);
            }

        }

        private void SetToList(object obj)
        {
            NoteList.Add(SelectedItem);
            
        }

        private bool CanSetToList(object obj)
        {
            return true;
        }

        #endregion

    }
}
