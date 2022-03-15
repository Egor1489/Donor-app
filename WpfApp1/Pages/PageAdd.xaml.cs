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
using System.Windows.Threading;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        

        public PageAdd()
        {
            InitializeComponent();
            
            CmbxStatus.SelectedValuePath = "ID_Status";
            CmbxStatus.DisplayMemberPath = "Status1";
            CmbxStatus.ItemsSource = ConnectOdb.conObj.Status.ToList();

            

        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                Edinica edinica = new Edinica()
                {
                    Component = txtComp.Text,
                    GUID_Donor = txtDonor.Text,
                    Date_Sbora = Convert.ToDateTime(txtDateSbor.SelectedDate.Value),
                    Date_Freeze = Convert.ToDateTime(txtDateSbor.SelectedDate.Value),
                    Group = txtGroup.Text,
                    Rh = txtRh.Text,
                    FK_Status = (int)CmbxStatus.SelectedValue
                };
                ConnectOdb.conObj.Edinica.Add(edinica);
                ConnectOdb.conObj.SaveChanges();
                MessageBox.Show("Данные успешно добавлены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString());
            }

        }
    }
}
