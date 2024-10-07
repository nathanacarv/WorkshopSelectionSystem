namespace WorkshopSelector
{
    partial class WorkshopSelectorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListBoxWorkshop = new ListBox();
            lblSelectWorkshop = new Label();
            lblSelectLocation = new Label();
            ListBoxLodging = new ListBox();
            btnCalculateTotal = new Button();
            lblRegistration = new Label();
            lblLodging = new Label();
            lblTotal = new Label();
            lblRegistrationValue = new Label();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // ListBoxWorkshop
            // 
            ListBoxWorkshop.BackColor = Color.BlanchedAlmond;
            ListBoxWorkshop.FormattingEnabled = true;
            ListBoxWorkshop.ItemHeight = 46;
            ListBoxWorkshop.Items.AddRange(new object[] { "Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview" });
            ListBoxWorkshop.Location = new Point(56, 102);
            ListBoxWorkshop.Name = "ListBoxWorkshop";
            ListBoxWorkshop.Size = new Size(589, 234);
            ListBoxWorkshop.TabIndex = 0;
            ListBoxWorkshop.SelectedIndexChanged += lbWorkshop_SelectedIndexChanged;
            // 
            // lblSelectWorkshop
            // 
            lblSelectWorkshop.BackColor = Color.RosyBrown;
            lblSelectWorkshop.Location = new Point(56, 31);
            lblSelectWorkshop.Name = "lblSelectWorkshop";
            lblSelectWorkshop.Size = new Size(589, 52);
            lblSelectWorkshop.TabIndex = 1;
            lblSelectWorkshop.Text = "Select Workshop:";
            lblSelectWorkshop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSelectLocation
            // 
            lblSelectLocation.BackColor = Color.RosyBrown;
            lblSelectLocation.Location = new Point(56, 440);
            lblSelectLocation.Name = "lblSelectLocation";
            lblSelectLocation.Size = new Size(589, 52);
            lblSelectLocation.TabIndex = 2;
            lblSelectLocation.Text = "Select Location:";
            lblSelectLocation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ListBoxLodging
            // 
            ListBoxLodging.BackColor = Color.BlanchedAlmond;
            ListBoxLodging.FormattingEnabled = true;
            ListBoxLodging.ItemHeight = 46;
            ListBoxLodging.Items.AddRange(new object[] { "Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh" });
            ListBoxLodging.Location = new Point(56, 508);
            ListBoxLodging.Name = "ListBoxLodging";
            ListBoxLodging.Size = new Size(589, 234);
            ListBoxLodging.TabIndex = 3;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.Location = new Point(976, 486);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(329, 101);
            btnCalculateTotal.TabIndex = 4;
            btnCalculateTotal.Text = "Calculate Total";
            btnCalculateTotal.UseVisualStyleBackColor = true;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Segoe UI", 14.15029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistration.Location = new Point(747, 112);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(271, 46);
            lblRegistration.TabIndex = 5;
            lblRegistration.Text = "REGISTRATION:";
            // 
            // lblLodging
            // 
            lblLodging.AutoSize = true;
            lblLodging.Font = new Font("Segoe UI", 14.15029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLodging.Location = new Point(747, 197);
            lblLodging.Name = "lblLodging";
            lblLodging.Size = new Size(182, 46);
            lblLodging.TabIndex = 6;
            lblLodging.Text = "LODGING:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.15029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(747, 290);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(132, 46);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL:";
            // 
            // lblRegistrationValue
            // 
            lblRegistrationValue.BorderStyle = BorderStyle.FixedSingle;
            lblRegistrationValue.Location = new Point(1046, 112);
            lblRegistrationValue.Name = "lblRegistrationValue";
            lblRegistrationValue.Size = new Size(312, 46);
            lblRegistrationValue.TabIndex = 8;
            lblRegistrationValue.Text = "0.00";
            lblRegistrationValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(1046, 197);
            label1.Name = "label1";
            label1.Size = new Size(312, 46);
            label1.TabIndex = 9;
            label1.Text = "0.00";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(1046, 290);
            label2.Name = "label2";
            label2.Size = new Size(312, 46);
            label2.TabIndex = 10;
            label2.Text = "0.00";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(976, 641);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(329, 101);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // WorkshopSelectorForm
            // 
            AutoScaleDimensions = new SizeF(19F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1475, 811);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblRegistrationValue);
            Controls.Add(lblTotal);
            Controls.Add(lblLodging);
            Controls.Add(lblRegistration);
            Controls.Add(btnCalculateTotal);
            Controls.Add(ListBoxLodging);
            Controls.Add(lblSelectLocation);
            Controls.Add(lblSelectWorkshop);
            Controls.Add(ListBoxWorkshop);
            Font = new Font("Segoe UI", 14.15029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "WorkshopSelectorForm";
            Text = "Workshop Selector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxWorkshop;
        private Label lblSelectWorkshop;
        private Label lblSelectLocation;
        private ListBox ListBoxLodging;
        private Button btnCalculateTotal;
        private Label lblRegistration;
        private Label lblLodging;
        private Label lblTotal;
        private Label lblRegistrationValue;
        private Label label1;
        private Label label2;
        private Button btnExit;
    }
}
