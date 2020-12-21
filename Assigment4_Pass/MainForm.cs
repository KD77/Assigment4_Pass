using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment4_Pass
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeGUI()
        {
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;

            lblNumOfGuestList.Text = string.Empty;
            lblTotalCost.Text = "0.0";
            lstAllGuests.Items.Clear();


            // disable the add guest groupbox
            grpAddGuests.Enabled = false;
            // enabe the create new party groupbox
            grtNewParty.Enabled = true;



        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {

        }
    }
}
