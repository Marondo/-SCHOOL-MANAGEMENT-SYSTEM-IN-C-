using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGE_em_CSharp_fx_06_018.Bag_frms
{
    public partial class Jogo_fx : Form
    {
        public Jogo_fx()
        {
            InitializeComponent();
        }
        string actual = "";
        int origem = 0;
        private void Jogo_fx_Load(object sender, EventArgs e)
        {
            chkl3.Items.Add("6.       [    *    ]");
            chkl3.Items.Add("5.      [ *      * ]");
            chkl3.Items.Add("4.     [ *   *   * ]");
            chkl3.Items.Add("3.    [ * *    * * ]");
            chkl3.Items.Add("2.   [ * *  *  * * ]");
            chkl3.Items.Add("1.  [ * * *  * * * ]");
          //  chkl3.Items.Add(" [ * * * * * * * ]");
        }

        private void vasculha()
        {
            foreach (string s in chkl1.CheckedItems)
            {
                if (s != "")
                {
                    actual = s;
                    origem = 1;
                }
            }/////////////////1
            foreach (string s in chkl2.CheckedItems)
            {
                if (s != "")
                {
                    actual = s;
                    origem = 2;
                }
            }//////////////2
            foreach (string s in chkl3.CheckedItems)
            {
                if (s != "")
                {
                    actual = s;
                    origem = 3;
                }
            }
        }
        private void chkl3_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   vasculha();
        }

        private void chkl2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // vasculha();

        }

        private void chkl1_SelectedIndexChanged(object sender, EventArgs e)
        {//    vasculha();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            vasculha();
            if (actual != "")
            {
                chkl3.Items.Add(actual);
            actual = "";
            origem = 0;
            }
            if (origem == 1)
            {
                chkl1.Items.Remove(chkl1.SelectedItem);
            }
            else
            {
                chkl2.Items.Remove(chkl2.SelectedItem);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            vasculha();
            if (actual != "")
            {
                chkl2.Items.Add(actual);
                actual = "";
                origem = 0;
            }
            if (origem == 1)
            {
                chkl1.Items.Remove(chkl1.SelectedItem);
            }
            else
            {
                chkl3.Items.Remove(chkl3.SelectedItem);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            vasculha();
            if (actual != "")
            {
                chkl1.Items.Add(actual);
                actual = "";
                origem = 0;
            }
            if (origem == 2)
            {
                chkl2.Items.Remove(chkl2.SelectedItem);
            }
            else
            {
                chkl3.Items.Remove(chkl3.SelectedItem);
            }
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            chkl3.Items.Remove(chkl3.Items);
            chkl1.Items.Remove(AllowDrop);
            chkl2.Items.Remove(AllowDrop);
        }
    }
}
