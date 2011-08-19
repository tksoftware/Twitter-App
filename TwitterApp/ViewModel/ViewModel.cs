using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using TwitterApp.Model;
using System.ComponentModel;

namespace TwitterApp.ViewModel
{
    public class ViewModel : ViewModelBase
    {
        public ObservableCollection<Tweet> Tweets { get; set; }

        private bool _isUpdating;
        public bool IsUpdating {
            get { return _isUpdating; }
            set {
                _isUpdating = value;
                RaisePropertyChanged("IsUpdating");
            
            }
        }


    }
}
