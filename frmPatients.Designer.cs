namespace covid19
{
    partial class Form1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "txtName";
            textBox1.Location = new Point(272, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "txt.country";
            textBox2.Location = new Point(264, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "txtidno";
            textBox3.Location = new Point(272, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 31);
            textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "txtgender";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(264, 202);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 33);
            comboBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.AccessibleName = "namebtn";
            button3.Location = new Point(339, 364);
            button3.Name = "button3";
            button3.Size = new Size(115, 41);
            button3.TabIndex = 7;
            button3.Text = "new";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AccessibleName = "delete";
            button4.Location = new Point(569, 364);
            button4.Name = "button4";
            button4.Size = new Size(115, 41);
            button4.TabIndex = 8;
            button4.Text = "delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AccessibleName = "isActive";
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(123, 298);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "isActive";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AccessibleName = "name";
            label1.AutoSize = true;
            label1.Location = new Point(113, 51);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 10;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AccessibleName = "country";
            label2.AutoSize = true;
            label2.Location = new Point(113, 234);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 11;
            label2.Text = "country";
            // 
            // button5
            // 
            button5.AccessibleName = "save";
            button5.Location = new Point(189, 355);
            button5.Name = "button5";
            button5.Size = new Size(115, 41);
            button5.TabIndex = 12;
            button5.Text = "save";
            button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AccessibleName = "idno";
            label3.AutoSize = true;
            label3.Location = new Point(123, 97);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 13;
            label3.Text = "IDNo";
            // 
            // label4
            // 
            label4.AccessibleName = "dob";
            label4.AutoSize = true;
            label4.Location = new Point(123, 135);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 14;
            label4.Text = "DOB";
            // 
            // label5
            // 
            label5.AccessibleName = "gender";
            label5.AutoSize = true;
            label5.Location = new Point(116, 185);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 15;
            label5.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleName = "txtdateofbirth";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(272, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(169, 31);
            dateTimePicker1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "patientsForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private Button button5;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}
