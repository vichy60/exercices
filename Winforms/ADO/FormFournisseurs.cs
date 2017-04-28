using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class FormFournisseurs : Form
    {
        public FormFournisseurs()
        {
            InitializeComponent();
            cbbPays.SelectedValueChanged += CbbPays_SelectedValueChanged;
            

        }

        private void CbbPays_SelectedValueChanged(object sender, EventArgs e)
        {
            lbNbProduit.Text = DAL.GetNbProduits(cbbPays.SelectedItem.ToString());
            dgvSupplier.DataSource = DAL.GetSuppliers(cbbPays.SelectedItem.ToString());
        }

        protected override void OnLoad(EventArgs e)

        {

            //dgvSupplier.DataSource = DAL.GetSuppliers(cbbPays.SelectedItem.ToString());
            cbbPays.DataSource = DAL.GetPays();
            // lbNbProduit.Text =DAL.GetNbProduits(cbbPays.SelectedItem.ToString()).ToString();  pas nécessaire car passe dans SelectedValueChanged au demarrage.
          



            base.OnLoad(e);
        }

    }
}



//create function ufn_listCommandeClient(@clientId nchar(5))
//returns @tab Table(commandeId int, dateCommande datetime, dateEnvoi datetime, nbArticle int, MontantTotal money, FraisEnvoi money)
//as
//begin
//--select o.OrderID, o.OrderDate, o.ShippedDate , COUNT(1),sum(od.Quantity* od.UnitPrice*(1-od.Discount)),o.Freight from Orders as o
//--inner join Order_Details as od on o.OrderID=od.OrderID
//--where o.CustomerID='ALFKI'
//--group by o.OrderID, o.OrderDate, o.ShippedDate, o.Freight
//insert @tab
//select distinct o.OrderID, o.OrderDate, o.ShippedDate,
//        COUNT(1) over(partition by o.OrderID),

//        sum(od.Quantity* od.UnitPrice*(1-od.Discount)) over(partition by o.OrderID),
//		o.Freight
//from Orders as o
//    inner join Order_Details as od on o.OrderID=od.OrderID
//where o.CustomerID=@clientId
//order by 2


//return 
//end
//go
