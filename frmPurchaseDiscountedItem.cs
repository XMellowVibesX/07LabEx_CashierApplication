using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Converting to the right data type
            string item_name = tbItemPrice.Text;
            double item_price = Convert.ToDouble(tbItemPrice.Text);
            double item_discount = Convert.ToDouble(tbDiscount.Text);
            int item_quantity = Convert.ToInt32(tbItemQuantity.Text);

            DiscountedItem DI = new DiscountedItem(item_name, item_price, item_quantity, item_discount);
            lblTotalNumber.Text = DI.getDiscountedPrice().ToString("F2");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string item_name = tbItemPrice.Text;
            double item_price = Convert.ToDouble(tbItemPrice.Text);
            double item_discount = Convert.ToDouble(tbDiscount.Text);
            double payment_received = Convert.ToDouble(tbPaymentReceived.Text);
            int item_quantity = Convert.ToInt32(tbItemQuantity.Text);

            DiscountedItem DI = new DiscountedItem(item_name, item_price, item_quantity, item_discount);

            DI.setPaymentAmount(payment_received);

            lblChangeNumber.Text = DI.getChange().ToString("F2");

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount LA = new frmLoginAccount();
            this.Close();
            LA.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
