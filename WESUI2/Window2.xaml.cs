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
using System.Windows.Shapes;
using CefSharp.WinForms;

namespace WESUI2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            ChromiumWebBrowser chrome;
            CefSettings settings = new CefSettings();
            string url = "https://earthquake.usgs.gov/earthquakes/eventpage/ci11408890/map";
            chrome = new ChromiumWebBrowser(url);
            this.Doctor.DataContext = chrome;
            chrome.Load(url);
        }
 
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
