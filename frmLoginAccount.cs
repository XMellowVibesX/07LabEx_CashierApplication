using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) { 
        
            Cashier cashier = new Cashier("Jane Doe", "Marketing", "Janie123", "JD123");
            frmPurchaseDiscountedItem PDI = new frmPurchaseDiscountedItem();
            
            if (cashier.validateLogin(tbUsername.Text, tbPassword.Text))
            {
                MessageBox.Show("Welcome back " + cashier.getFullName() + " of " + cashier.getDepartment() + "!");
                this.Hide();
                PDI.Show();
            }                
            else { MessageBox.Show("Login failed. Try again!"); }
        }
    }
}
