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

namespace Trombinoscope
{
    /// <summary>
    /// Interaction logic for UCTrombi.xaml
    /// </summary>
    public partial class UCTrombi : UserControl
    {
        public List<Personne> ListPersonne { get; set; }

        public UCTrombi()
        {
            InitializeComponent();
            DataContext = DAL.GetPersonnes();
            //ListPersonne = DAL.GetPersonnes();
            //foreach( var pers in ListPersonne)
            //{
            //    lb_Photos.Items.Add(pers.Photo);
            //}
            // exercice 17 remplacé par un DataTemplate dans le xaml

        }
    }
}
