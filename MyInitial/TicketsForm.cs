using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        bool mDiscount = false;
        bool mDiscount2 = false;
        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            if (chkDiscount.Checked && childDiscount.Checked)
            {
                chkDiscount.Checked = false;
                childDiscount.Checked = false;
                mDiscount = false;
                mDiscount2 = false;
                return;
            }
            else if (chkDiscount.Checked)
            {
                mDiscount = true;
                mDiscount2 = false;
            }
            else if (childDiscount.Checked)
            {
                mDiscount = false;
                mDiscount2 = true;
            }
            else
            {
                mDiscount = false;
                mDiscount2 = false;
            }

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }

            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount, mDiscount2);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }

        private Task ShowMessageBox(string v, MessageBoxButtons oK, MessageBoxIcon error)
        {
            throw new NotImplementedException();
        }
    }
}
