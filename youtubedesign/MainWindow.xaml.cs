
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using youtubedesign.ConnectionApi;
using WebView = Xamarin.Forms.WebView;

namespace youtubedesign
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cliked(object sender, MouseButtonEventArgs e)
        {
            var item = ((Image)sender).DataContext as VideoInforms;
            var link = $@"https://www.youtube.com/watch?v={item.VideoId}";
            WebView.Visibility = Visibility.Visible;
            WebView.Source = new Uri(link);

        }

        private void clickdouble(object sender, MouseButtonEventArgs e)
        {
            WebView.Visibility = Visibility.Hidden;


        }
    }




}
