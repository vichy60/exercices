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

namespace Trombinoscope2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private  UCTrombi _Uctrombi=null;
        private UCEmployes _Ucemployes = null;
        public MainWindow()
        {
            InitializeComponent();
            Menu_Tromb.Click += Menu_Tromb_Click;
            Menu_Empl.Click += Menu_Empl_Click;
        }

        private void Menu_Empl_Click(object sender, RoutedEventArgs e)
        {
            if (_Ucemployes == null)
            {
                _Ucemployes = new UCEmployes ();
            }
            contentCtrl.Content = _Ucemployes;
        }

        private void Menu_Tromb_Click(object sender, RoutedEventArgs e)
        {
            if (_Uctrombi == null)
            {
                _Uctrombi = new UCTrombi();
            }
            contentCtrl.Content = _Uctrombi;
        }
    }
}
