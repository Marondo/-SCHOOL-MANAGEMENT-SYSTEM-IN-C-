using System;
using System.Windows.Forms;

namespace SGE_em_CSharp_fx_06_018.Bag_frms
{
    public partial class frmMover : Form
    {
        public frmMover()
        {
            InitializeComponent();
        }

        private void btnVend_Click(object sender, EventArgs e)
        {
            chklV.GetItemCheckState(1);
            ultm = chklV.SelectedItem.ToString();
            chklC.Items.Add(chklV.SelectedItem);
            chklV.Items.Remove(chklV.SelectedItem);
        }
        int i=0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "")
            {
                i++;
                chklV.Items.Add(i+". "+txtAdd.Text);
            }
        }

        private void btnDevol_Click(object sender, EventArgs e)
        {
            chklV.Items.Add(chklC.SelectedItem);
            chklC.Items.Remove(chklC.SelectedItem);
        }
        String ultm="";
        private void btnAnull_Click(object sender, EventArgs e)
        {
            if (ultm != "")
            {
                chklV.Items.Add(ultm);
                chklC.Items.Remove(ultm);
            }
        }

        private void chklC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chklV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimp_Click(object sender, EventArgs e)
        {

        }
    }
}