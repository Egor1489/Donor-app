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
using WpfApp1.AppDataFile;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageHistory.xaml
    /// </summary>
    public partial class PageHistory : Page
    {
        public PageHistory(Edinica edinica)
        {
            InitializeComponent();
            
            ProductObj.ID_Edinica = edinica.ID_Edinica;
            cmbxEdinica.DisplayMemberPath = "Component";
            cmbxEdinica.SelectedValuePath = "ID_Edinica";
            cmbxEdinica.ItemsSource = ConnectOdb.conObj.Edinica.ToList();

            GridHistoryEd.IsReadOnly = true;
            GridHistoryEd.ItemsSource = ConnectOdb.conObj.Edinica.Where(x => x.ID_Edinica == ProductObj.ID_Edinica).ToList();
            
            
        }

        private void cmbxEdinica_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridHistoryEd.ItemsSource = null;
            int HistiryEd = Convert.ToInt32(cmbxEdinica.SelectedValue); // Переменная выбранного продукта
            GridHistoryEd.ItemsSource = ConnectOdb.conObj.Edinica.Where(x => x.ID_Edinica == HistiryEd).ToList();
            GridHistoryEd.SelectedIndex = 0;
        }
    }
}
