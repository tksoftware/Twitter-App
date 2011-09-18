using System.Windows;
using Microsoft.Phone.Controls;
using TwitterApp.Services;
using TwitterApp.ViewModel;

namespace TwitterApp
{
    public partial class MainPage : PhoneApplicationPage
    {

        private MainViewModel _viewModel;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            if (_viewModel == null)
            {
                _viewModel = new MainViewModel(new TwitterService());
                LayoutRoot.DataContext = _viewModel;
            }


        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
           _viewModel.FetchData();
        }
    }
}