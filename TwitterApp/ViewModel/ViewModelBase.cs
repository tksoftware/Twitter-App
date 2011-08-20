using System.ComponentModel;
using System;

namespace TwitterApp.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)   
        {   
            if (string.IsNullOrEmpty(propertyName))   
                throw new ArgumentNullException("propertyName");   
  
            if (PropertyChanged != null)   
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));   
        }

        #endregion
    }
}
