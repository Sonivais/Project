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

namespace ZadanieYLTRO
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void myCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonOtmena_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
        }

        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page6());
        }
    }
}
