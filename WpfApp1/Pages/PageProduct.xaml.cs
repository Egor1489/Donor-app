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
using System.Windows.Threading;
using WpfApp1.Pages;
using WpfApp1.AppDataFile;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct : Page
    {
        public PageProduct()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            grdList.ItemsSource = ConnectOdb.conObj.Edinica.ToList();
            timer.Interval = TimeSpan.FromSeconds(1);// Обновление данных в реальном времени
            timer.Tick += UpdateData;
            timer.Start();

            


        }
        
        public void UpdateData(object sender, object e)
        {
            var HistoryProduct = ConnectOdb.conObj.Edinica.ToList();
            ListProduct.ItemsSource = HistoryProduct;
            ListProduct.ItemsSource = ConnectOdb.conObj.Edinica.Where(x => x.Component.StartsWith(TxtSearch.Text) || x.Rh.StartsWith(TxtSearch.Text)).ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageEditNew((sender as Button).DataContext as Edinica));
            
        }

        private void BtnHistory_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageHistory((sender as Button).DataContext as Edinica));

        }

       

        private void RbDesk_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdList.ItemsSource = ConnectOdb.conObj.Edinica.OrderByDescending(x => x.Date_Sbora).ToList();

        }

        private void RbAsk_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdList.ItemsSource = ConnectOdb.conObj.Edinica.OrderBy(x => x.Date_Sbora).ToList();

        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
          var remove = grdList.SelectedItems.Cast<Edinica>().ToList();
           if(MessageBox.Show("Вы уверены?","Уведомление!",MessageBoxButton.OKCancel,MessageBoxImage.Information) == MessageBoxResult.OK)
            {
                try
                {
                    ConnectOdb.conObj.Edinica.RemoveRange(remove);
                    ConnectOdb.conObj.SaveChanges();
                    MessageBox.Show("Данные удалены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                } catch (Exception er){
                    MessageBox.Show(er.Message.ToString());
                }

            }
           

        }
        
    }
}
