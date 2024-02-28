using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void updatesize()
        {
            updatetotalprice();
            if (rbsmall.Checked){
                lbanswersize.Text = "Small";
                return;
                }
            else if (rbmedium.Checked)
            {
                lbanswersize.Text = "Medium";
                return;
            }
            else if (rblarge.Checked)
            {
                lbanswersize.Text = "Large";
                return;
            }
        }
        float sizeprice()
        {
            if (rbsmall.Checked)
            {
                return Convert.ToSingle(rbsmall.Tag);
            }
            else if (rbmedium.Checked)
            {
                return Convert.ToSingle(rbmedium.Tag);
            }
            else  
            {
                return Convert.ToSingle(rblarge.Tag);
            }

        }
        float crustprice()
        {
            if (rbthin.Checked)
            {
                return Convert.ToSingle(rbthin.Tag);
            }
            else  
            {
                return Convert.ToSingle(rbthick.Tag);
            }
           
        }
        float toppingprice()
        {
            float total = 0;
            if (chkcheese.Checked)
            {
                total+= Convert.ToSingle(chkcheese.Tag);
            }
             if (chkmushrum.Checked)
            {
                total += Convert.ToSingle(chkmushrum.Tag);
            }
             if (chkolives.Checked)
            {
                total += Convert.ToSingle(chkolives.Tag);
            }
             if (chkonion.Checked)
            {
                total += Convert.ToSingle(chkonion.Tag);
            }
             if (chktomato.Checked)
            {
                total += Convert.ToSingle(chktomato.Tag);
            }
            if (Chkgreenp.Checked)
            {
                total += Convert.ToSingle(Chkgreenp.Tag);
            }return total;
        }
        float gettotalprice()
        {
             return( toppingprice() + crustprice() + sizeprice());

        }
        private void btorder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure you want to Subit your order? ","Confirm Submitting:", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Your order has been confirmed :)","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btorder.Enabled = false;
                gbsize.Enabled = false;
                gbtopping.Enabled = false;
                gbcrust.Enabled = false;
                gbplace.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update your order", "Update",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btreset_Click(object sender, EventArgs e)
        {
            resetform();
        }
        private void rbmedium_CheckedChanged(object sender, EventArgs e)
        {
            updatesize();
        }
        private void rblarge_CheckedChanged(object sender, EventArgs e)
        {
            updatesize();
        }
        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            updatesize();
        }
        void updatetotalprice()
        {
            lbanswerprice .Text = "$" + gettotalprice().ToString();
        }
        void updatecrust()
        {
            updatetotalprice();
            if (rbthin.Checked)
            {
                lbanswercrust.Text = "Thin";
                return;
            }
            if(rbthick.Checked)
            {
                lbanswercrust.Text = "Thick";
                return;
            }
        }
        void updatetopping()
        {
            updatetotalprice();
            string s = "";
            if (chkcheese.Checked)
            {
                s = " Cheese ";
            }
             if (chkmushrum.Checked)
            {
                s += " Mashrum ";

            }
             if (chkolives.Checked)
            {
                s += " Olives ";

            }
             if (chkonion.Checked)
            {
                s += " Onion ";

            }
             if (chktomato.Checked)
            {
                s += " Tomato ";

            }
             if (Chkgreenp.Checked)
            {
                s += " Green paper ";

            }
            if (s == "")
                s = "No topping";
            lbanswertopping.Text = s;
        }
        void updateplace()
        {

            updatetotalprice();
            if (rbin.Checked)
            {
                lbanswerplace.Text = " Eat in ";
                return;
            }
            if(rbout.Checked)
            {
                lbanswerplace.Text = "Take Out";
                return;
            }
               
        }

        private void rbthin_CheckedChanged(object sender, EventArgs e)
        {
            updatecrust();
        }

        private void rbthick_CheckedChanged(object sender, EventArgs e)
        {
            updatecrust();
        }

        private void rbin_CheckedChanged(object sender, EventArgs e)
        {
            updateplace();
        }

        private void rbout_CheckedChanged(object sender, EventArgs e)
        {
            updateplace();
        }

        private void lbanswerprice_Click(object sender, EventArgs e)
        {
            updatetotalprice();
        }
        void updatesummary()
        {
            updateplace();
            updatesize();
            updatetopping();
            updatetotalprice();
            updatecrust(); 
        }

        private void chkcheese_CheckedChanged(object sender, EventArgs e)
        {
            updatetopping();
        }
        private void chkonion_CheckedChanged(object sender, EventArgs e)
        {
            updatetopping();
        }
        private void chkmushrum_CheckedChanged(object sender, EventArgs e)
        {
            updatetopping();
        }

        private void Chkgreenp_CheckedChanged(object sender, EventArgs e)
        {
            updatetopping();
        }

        private void chktomato_CheckedChanged(object sender, EventArgs e)
        {
            updatetopping();
        }

        private void chkolives_CheckedChanged(object sender, EventArgs e)
        {
            updatetopping();
        }

        void resetform()
        {
            btorder.Enabled = true;
            gbsize.Enabled = true;
            gbtopping.Enabled = true;
            gbcrust.Enabled = true;
            gbplace.Enabled = true;
            rbmedium.Checked = true;
            chkcheese.Checked=false;
            chkmushrum.Checked = false;
            chkolives.Checked = false;
            chktomato.Checked = false;
            Chkgreenp.Checked = false;
            chkonion.Checked = false;
            rbthin.Checked = true;
            rbthick.Checked = false;
            rbin.Checked = true;
            rbout.Checked = false;
            btorder.Enabled = true;
        }
    }
}
