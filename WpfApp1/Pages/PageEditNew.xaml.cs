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
    /// Логика взаимодействия для PageEditNew.xaml
    /// </summary>
    public partial class PageEditNew : Page
    {

        public PageEditNew(Edinica edinica)
        {
            InitializeComponent();

            CmbxStatus.SelectedIndex = (int)edinica.FK_Status - 1;
            CmbxStatus.SelectedValuePath = "ID_Status";
            CmbxStatus.DisplayMemberPath = "Status1";
            CmbxStatus.ItemsSource = ConnectOdb.conObj.Status.ToList();


            ProductObj.ID_Edinica = edinica.ID_Edinica;

            txtComp.Text = edinica.Component;
            txtDonor.Text = edinica.GUID_Donor;
            txtDateSbor.Text = Convert.ToString(edinica.Date_Sbora);
            txtDateZam.Text = Convert.ToString(edinica.Date_Freeze);
            txtGroup.Text = edinica.Group;
            txtRh.Text = edinica.Rh;






        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Edinica> edinicas = ConnectOdb.conObj.Edinica.Where(x => x.ID_Edinica == ProductObj.ID_Edinica).AsEnumerable().Select(x => {
                x.Component = txtComp.Text;
                x.GUID_Donor = txtDonor.Text;
                x.Date_Sbora = Convert.ToDateTime(txtDateSbor.SelectedDate.Value);
                x.Date_Freeze = Convert.ToDateTime(txtDateZam.SelectedDate.Value);
                x.Group = txtGroup.Text;
                x.Rh = txtRh.Text;
                x.FK_Status = (int)CmbxStatus.SelectedValue;

                return x;
            });
            foreach (Edinica ednc in edinicas)
            {
                ConnectOdb.conObj.Entry(ednc).State = System.Data.Entity.EntityState.Modified;

            }
            ConnectOdb.conObj.SaveChanges();
            MessageBox.Show("Данные успешно изменены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
          

        }
    }
}
