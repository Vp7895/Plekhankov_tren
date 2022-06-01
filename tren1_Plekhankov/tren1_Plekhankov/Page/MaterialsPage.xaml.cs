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
using tren1_Plekhankov.DateBase;

namespace tren1_Plekhankov.Page
{
    /// <summary>
    /// Логика взаимодействия для MaterialsPage.xaml
    /// </summary>
    public partial class MaterialsPage : Window
    {
        public MaterialsPage()
        {
            InitializeComponent();

            DGridMaterials.ItemsSource = tren1_PlekhankovEntities.GetContext().Materials.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Window Back = new MainWindow();
            Back.Show();
            Close();
        }
    }
}
