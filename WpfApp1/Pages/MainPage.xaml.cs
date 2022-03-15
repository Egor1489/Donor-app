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
using WpfApp1.Pages;
using WpfApp1.AppDataFile;
using System.Windows.Threading;

namespace WpfApp1.Pages

{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnEdinica_Click(object sender, RoutedEventArgs e)
        {

            FrameObj.frameMain.Navigate(new PageProduct());

        }

        private void BtnEdinicaAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageAdd());
        }

        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
