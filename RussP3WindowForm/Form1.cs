
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace RussP3WindowForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

         
      
        //add the clear form button
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txbResults.Clear();
            txbOrderNumber.Clear();
            txbNumberOfItems.Clear();
            txbEngrave.Clear();
            txbNumberOfColor.Clear();
            rbPen.Checked = false;
            rbUSB.Checked = false;
            rbMug.Checked = false;
            cbLogo.Checked = false; 
        }

        //add the submit form and send text to the result window
        private void btnSubmitForm_Click(object sender, EventArgs e)
        {
            try
            {
                string itemList = "TBD";
                if (rbMug.Checked)
                {
                    itemList = rbMug.Text;
                }
                else if (rbUSB.Checked)
                {
                    itemList = rbUSB.Text;
                }
                else if (rbPen.Checked)
                {
                    itemList = rbPen.Text;
                }
                else
                {
                    itemList = "blank";
                }


                // Set properties of the LogoOrderItem instance
                LogoOrderItem logoOrderItem = new LogoOrderItem(txbOrderNumber.Text, itemList, txbEngrave.Text, txbResults.Text);
                logoOrderItem.OrderId = txbOrderNumber.Text;
                logoOrderItem.ItemType = itemList;
                logoOrderItem.TextEngrave = txbEngrave.Text;
                logoOrderItem.NumColors = int.Parse(txbNumberOfColor.Text);
                logoOrderItem.HasLogo = cbLogo.Checked;

                txbResults.Text = logoOrderItem.GetOrderSummary();
            }
            catch (Exception ex)
            {
                txbResults.Text = "Error: " + ex.Message;
            }
            
        }
    }
}

