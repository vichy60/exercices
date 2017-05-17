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
    /// Interaction logic for UCEmployes.xaml
    /// </summary>
    public partial class UCEmployes : UserControl
    {
        #region propriété
        public List<Personne> ListPersonne { get; set; }

        #endregion
        public UCEmployes()
        {
            InitializeComponent();
            DataContext = new ContexteEmploye();
            //DataContext = DAL.GetPersonnes();      mis en commentaire suite exercice Etape 1 Saisie d'employés
            //ListPersonne = DAL.GetPersonnes();
            //lb_Empl.ItemsSource = ListPersonne;
            //lb_Empl.DisplayMemberPath = "NomPrenom";
            //lb_Empl.SelectionChanged += Lb_Empl_SelectionChanged;
            //lb_Empl.SelectedValuePath = "EmployeeId";
            //lb_Empl.DataContext = ListPersonne;
            //sp_Employe.DataContext = ListPersonne;




        }

        //private void Lb_Empl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    //int Id = (int)lb_Empl.SelectedValue;
        //    //Personne p = ListPersonne.Where(lp => lp.EmployeeId == Id).FirstOrDefault();
        //    //tb_Id.Text = p.EmployeeId.ToString();
        //    //tb_Nom.Text = p.Nom;
        //    //tb_Prenom.Text = p.Prenom;
        //    sp_Employe.DataContext = lb_Empl.SelectedItem ;

        //}
    }
}
