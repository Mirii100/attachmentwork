namespace covid19
{
    partial class frmPatients
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
            txtName = new TextBox();
            txtCountry = new TextBox();
            txtIdNo = new TextBox();
            cmbGender = new ComboBox();
            btnNew = new Button();
            btnDelete = new Button();
            chkIsActive = new CheckBox();
            lblName = new Label();
            lblCountry = new Label();
            btnSave = new Button();
            lblIdNo = new Label();
            lblDob = new Label();
            lblGender = new Label();
            dtpDob = new DateTimePicker();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AccessibleName = "txtName";
            txtName.Location = new Point(272, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(169, 31);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtCountry
            // 
            txtCountry.AccessibleName = "txt.country";
            txtCountry.Location = new Point(264, 253);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(177, 31);
            txtCountry.TabIndex = 1;
            // 
            // txtIdNo
            // 
            txtIdNo.AccessibleName = "txtidno";
            txtIdNo.Location = new Point(272, 82);
            txtIdNo.Name = "txtIdNo";
            txtIdNo.Size = new Size(169, 31);
            txtIdNo.TabIndex = 2;
            // 
            // cmbGender
            // 
            cmbGender.AccessibleName = "txtgender";
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(264, 202);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(177, 33);
            cmbGender.TabIndex = 4;
            // 
            // btnNew
            // 
            btnNew.AccessibleName = "namebtn";
            btnNew.Location = new Point(339, 364);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(115, 41);
            btnNew.TabIndex = 7;
            btnNew.Text = "new";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.AccessibleName = "delete";
            btnDelete.Location = new Point(569, 364);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 41);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AccessibleName = "isActive";
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(123, 298);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(98, 29);
            chkIsActive.TabIndex = 9;
            chkIsActive.Text = "isActive";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AccessibleName = "name";
            lblName.AutoSize = true;
            lblName.Location = new Point(113, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 10;
            lblName.Text = "Name";
            // 
            // lblCountry
            // 
            lblCountry.AccessibleName = "country";
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(113, 234);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(72, 25);
            lblCountry.TabIndex = 11;
            lblCountry.Text = "country";
            // 
            // btnSave
            // 
            btnSave.AccessibleName = "save";
            btnSave.Location = new Point(189, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 41);
            btnSave.TabIndex = 12;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblIdNo
            // 
            lblIdNo.AccessibleName = "idno";
            lblIdNo.AutoSize = true;
            lblIdNo.Location = new Point(123, 97);
            lblIdNo.Name = "lblIdNo";
            lblIdNo.Size = new Size(54, 25);
            lblIdNo.TabIndex = 13;
            lblIdNo.Text = "IDNo";
            // 
            // lblDob
            // 
            lblDob.AccessibleName = "dob";
            lblDob.AutoSize = true;
            lblDob.Location = new Point(123, 135);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(49, 25);
            lblDob.TabIndex = 14;
            lblDob.Text = "DOB";
            // 
            // lblGender
            // 
            lblGender.AccessibleName = "gender";
            lblGender.AutoSize = true;
            lblGender.Location = new Point(116, 185);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 25);
            lblGender.TabIndex = 15;
            lblGender.Text = "Gender";
            // 
            // dtpDob
            // 
            dtpDob.AccessibleName = "txtdateofbirth";
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(272, 129);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(169, 31);
            dtpDob.TabIndex = 16;
            // 
            // frmPatients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDob);
            Controls.Add(lblGender);
            Controls.Add(lblDob);
            Controls.Add(lblIdNo);
            Controls.Add(btnSave);
            Controls.Add(lblCountry);
            Controls.Add(lblName);
            Controls.Add(chkIsActive);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(cmbGender);
            Controls.Add(txtIdNo);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Name = "frmPatients";
            Text = "patientsForm";
            Load += frmPatients_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtCountry;
        private TextBox txtIdNo;
        private ComboBox cmbGender;
        private Button btnNew;
        private Button btnDelete;
        private CheckBox chkIsActive;
        private Label lblName;
        private Label lblCountry;
        private Button btnSave;
        private Label lblIdNo;
        private Label lblDob;
        private Label lblGender;
        private DateTimePicker dtpDob;
    }
}
