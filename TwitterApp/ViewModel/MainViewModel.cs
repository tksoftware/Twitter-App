using System;
using System.Collections.ObjectModel;
using System.Windows;
using TwitterApp.Model;
using TwitterApp.Services;

namespace TwitterApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ITwitterService _service;
        private bool _isUpdating;

        public MainViewModel(ITwitterService service)
        {
            _service = service;
        }


        public ObservableCollection<Tweet> Tweets { get; set; }

        public String Query
        {
            get { return "C#"; }
        }


        public bool IsUpdating
        {
            get { return _isUpdating; }
            set
            {
                _isUpdating = value;
                RaisePropertyChanged("IsUpdating");
            }
        }

        private DateTime _lastUpdated;

        public DateTime LastUpdated
        {
            get { return _lastUpdated; }
            set { 
                _lastUpdated = value;
                RaisePropertyChanged("LastUpdated");
            }
        }


        public void FetchData()
        {
            IsUpdating = true;

            _service.GetTweets(
                result =>
                    {
                        if (result.HasValue())
                        {
                            Deployment.Current.Dispatcher.BeginInvoke(() =>
                                                                          {
                                                                              IsUpdating = false;

                                                                              foreach ( Tweet tweet in result.Value.results)
                                                                              {

                                                                              }
                                                                          }
                                );
                        }
                        else
                        {
                            Deployment.Current.Dispatcher.BeginInvoke(() =>
                                                                          {
                                                                              IsUpdating = false;
                                                                          }
                                );
                        }
                    },
                Query
                );
        }
    }
}