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
        Party party;
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
            bool maxNumOk = CreateParty();

            if (!maxNumOk)
                return;
            bool amountOK = ReadCostPerPerson();

            if(maxNumOk && amountOK)
            {
                grpAddGuests.Enabled = true;
                UpdateGUI();
            }
        }
        private bool CreateParty()
        {
            int maxNumber = 0;
            bool ok = true;
            if (int.TryParse(txtMaxNum.Text,out maxNumber) && (maxNumber > 0))
            {
                party = new Party(maxNumber);
                MessageBox.Show($"party list with space for {maxNumber} guests created!", "success");

            }
            else
            {
                MessageBox.Show("Invalid Total Number. Please try again!", "Error");
                ok = false;
            }

            return ok;
        }
        private void UpdateGUI()
        {
            lstAllGuests.Items.Clear();

            string[] guestList = party.GetGuestList();

            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20}";
                    lstAllGuests.Items.Add(str);
                }
            }
            else
                return;

            double totalCost = party.CalcTotatalCost();
            lblTotalCost.Text = totalCost.ToString("0.00");
            lblNumOfGuestList.Text = party.Count.ToString();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TrimNames())
            {
                bool ok = party.AddNewGuest(txtFirstName.Text, txtLastName.Text);
                if (!ok)
                    MessageBox.Show("List is full! New guest not added!", "Error");
                else
                    UpdateGUI();
            }

        }

        private bool TrimNames()
        {
            if ((!ValidateText(txtFirstName.Text))|| (!ValidateText(txtLastName.Text)))
                return false;

            txtFirstName.Text = txtFirstName.Text.Trim();
            txtLastName.Text = txtLastName.Text.Trim();
            return true;

    }
        private bool ValidateText(string text)
        {
            text = text.Trim();

            if( string.IsNullOrEmpty(text))
            {
                MessageBox.Show("please provide both the first name and te second name .", "Error");
                return false;

            }
            return true;

        }
}
