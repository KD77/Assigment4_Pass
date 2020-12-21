
namespace Assigment4_Pass
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grtNewParty = new System.Windows.Forms.GroupBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.grpAddGuests = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstAllGuests = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumOfGuestList = new System.Windows.Forms.Label();
            this.grtNewParty.SuspendLayout();
            this.grpAddGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // grtNewParty
            // 
            this.grtNewParty.Controls.Add(this.btnCreateList);
            this.grtNewParty.Controls.Add(this.textBox2);
            this.grtNewParty.Controls.Add(this.textBox1);
            this.grtNewParty.Controls.Add(this.label2);
            this.grtNewParty.Controls.Add(this.lbl1);
            this.grtNewParty.ForeColor = System.Drawing.Color.Teal;
            this.grtNewParty.Location = new System.Drawing.Point(92, 68);
            this.grtNewParty.Name = "grtNewParty";
            this.grtNewParty.Size = new System.Drawing.Size(524, 286);
            this.grtNewParty.TabIndex = 0;
            this.grtNewParty.TabStop = false;
            this.grtNewParty.Text = "New Party";
            // 
            // btnCreateList
            // 
            this.btnCreateList.ForeColor = System.Drawing.Color.Teal;
            this.btnCreateList.Location = new System.Drawing.Point(183, 203);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(142, 47);
            this.btnCreateList.TabIndex = 4;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 31);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost per person";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl1.Location = new System.Drawing.Point(24, 57);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(235, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Total Number of guests";
            // 
            // grpAddGuests
            // 
            this.grpAddGuests.Controls.Add(this.btnAdd);
            this.grpAddGuests.Controls.Add(this.txtLastName);
            this.grpAddGuests.Controls.Add(this.txtFirstName);
            this.grpAddGuests.Controls.Add(this.label4);
            this.grpAddGuests.Controls.Add(this.label3);
            this.grpAddGuests.Location = new System.Drawing.Point(92, 389);
            this.grpAddGuests.Name = "grpAddGuests";
            this.grpAddGuests.Size = new System.Drawing.Size(524, 306);
            this.grpAddGuests.TabIndex = 1;
            this.grpAddGuests.TabStop = false;
            this.grpAddGuests.Text = "Invite guest";
            this.grpAddGuests.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(183, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(151, 163);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(340, 31);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(151, 91);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(340, 31);
            this.txtFirstName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 744);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 809);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number of guests";
            // 
            // lstAllGuests
            // 
            this.lstAllGuests.FormattingEnabled = true;
            this.lstAllGuests.ItemHeight = 25;
            this.lstAllGuests.Location = new System.Drawing.Point(645, 90);
            this.lstAllGuests.Name = "lstAllGuests";
            this.lstAllGuests.Size = new System.Drawing.Size(454, 654);
            this.lstAllGuests.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Guests List";
            // 
            // Delete
            // 
            this.Delete.ForeColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(834, 771);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(145, 52);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotalCost.Location = new System.Drawing.Point(434, 744);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(96, 25);
            this.lblTotalCost.TabIndex = 5;
            this.lblTotalCost.Text = "              ";
            // 
            // lblNumOfGuestList
            // 
            this.lblNumOfGuestList.AutoSize = true;
            this.lblNumOfGuestList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNumOfGuestList.Location = new System.Drawing.Point(439, 808);
            this.lblNumOfGuestList.Name = "lblNumOfGuestList";
            this.lblNumOfGuestList.Size = new System.Drawing.Size(90, 25);
            this.lblNumOfGuestList.TabIndex = 7;
            this.lblNumOfGuestList.Text = "             ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 882);
            this.Controls.Add(this.lblNumOfGuestList);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstAllGuests);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpAddGuests);
            this.Controls.Add(this.grtNewParty);
            this.Name = "MainForm";
            this.Text = "Party Organizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grtNewParty.ResumeLayout(false);
            this.grtNewParty.PerformLayout();
            this.grpAddGuests.ResumeLayout(false);
            this.grpAddGuests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grtNewParty;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox grpAddGuests;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstAllGuests;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNumOfGuestList;
    }
}

