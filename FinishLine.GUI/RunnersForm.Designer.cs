namespace FinishLine
{
    partial class RunnersForm
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
            this.grpBxRunnnerReg = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartingNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBtFemale = new System.Windows.Forms.RadioButton();
            this.rdBtMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.nmrAge = new System.Windows.Forms.NumericUpDown();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstnName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegisterWithNumber = new System.Windows.Forms.Button();
            this.btnLoadDb = new System.Windows.Forms.Button();
            this.btnSaveDb = new System.Windows.Forms.Button();
            this.grpBxRunnnerReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxRunnnerReg
            // 
            this.grpBxRunnnerReg.Controls.Add(this.btnRegisterWithNumber);
            this.grpBxRunnnerReg.Controls.Add(this.btnRegister);
            this.grpBxRunnnerReg.Controls.Add(this.cmbCountry);
            this.grpBxRunnnerReg.Controls.Add(this.label3);
            this.grpBxRunnnerReg.Controls.Add(this.txtStartingNum);
            this.grpBxRunnnerReg.Controls.Add(this.label2);
            this.grpBxRunnnerReg.Controls.Add(this.rdBtFemale);
            this.grpBxRunnnerReg.Controls.Add(this.rdBtMale);
            this.grpBxRunnnerReg.Controls.Add(this.label1);
            this.grpBxRunnnerReg.Controls.Add(this.lblAge);
            this.grpBxRunnnerReg.Controls.Add(this.nmrAge);
            this.grpBxRunnnerReg.Controls.Add(this.txtBxLastName);
            this.grpBxRunnnerReg.Controls.Add(this.lblLastName);
            this.grpBxRunnnerReg.Controls.Add(this.txtBxFirstName);
            this.grpBxRunnnerReg.Controls.Add(this.lblFirstnName);
            this.grpBxRunnnerReg.Location = new System.Drawing.Point(12, 12);
            this.grpBxRunnnerReg.Name = "grpBxRunnnerReg";
            this.grpBxRunnnerReg.Size = new System.Drawing.Size(143, 426);
            this.grpBxRunnnerReg.TabIndex = 3;
            this.grpBxRunnnerReg.TabStop = false;
            this.grpBxRunnnerReg.Text = "Runner registration";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(5, 381);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(132, 23);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register with number";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(5, 167);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(132, 21);
            this.cmbCountry.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Country";
            // 
            // txtStartingNum
            // 
            this.txtStartingNum.Location = new System.Drawing.Point(6, 355);
            this.txtStartingNum.Name = "txtStartingNum";
            this.txtStartingNum.Size = new System.Drawing.Size(131, 20);
            this.txtStartingNum.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Starting number:";
            // 
            // rdBtFemale
            // 
            this.rdBtFemale.AutoSize = true;
            this.rdBtFemale.Location = new System.Drawing.Point(60, 284);
            this.rdBtFemale.Name = "rdBtFemale";
            this.rdBtFemale.Size = new System.Drawing.Size(59, 17);
            this.rdBtFemale.TabIndex = 8;
            this.rdBtFemale.TabStop = true;
            this.rdBtFemale.Text = "Female";
            this.rdBtFemale.UseVisualStyleBackColor = true;
            // 
            // rdBtMale
            // 
            this.rdBtMale.AutoSize = true;
            this.rdBtMale.Location = new System.Drawing.Point(6, 284);
            this.rdBtMale.Name = "rdBtMale";
            this.rdBtMale.Size = new System.Drawing.Size(48, 17);
            this.rdBtMale.TabIndex = 7;
            this.rdBtMale.TabStop = true;
            this.rdBtMale.Text = "Male";
            this.rdBtMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gender:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(6, 206);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age:";
            // 
            // nmrAge
            // 
            this.nmrAge.Location = new System.Drawing.Point(6, 222);
            this.nmrAge.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrAge.Name = "nmrAge";
            this.nmrAge.Size = new System.Drawing.Size(131, 20);
            this.nmrAge.TabIndex = 4;
            this.nmrAge.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(6, 116);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(131, 20);
            this.txtBxLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Lastname:";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(6, 72);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(131, 20);
            this.txtBxFirstName.TabIndex = 1;
            // 
            // lblFirstnName
            // 
            this.lblFirstnName.AutoSize = true;
            this.lblFirstnName.Location = new System.Drawing.Point(6, 56);
            this.lblFirstnName.Name = "lblFirstnName";
            this.lblFirstnName.Size = new System.Drawing.Size(55, 13);
            this.lblFirstnName.TabIndex = 0;
            this.lblFirstnName.Text = "Firstname:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveDb);
            this.groupBox1.Controls.Add(this.btnLoadDb);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(162, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 425);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registred Runners";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(614, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRegisterWithNumber
            // 
            this.btnRegisterWithNumber.Location = new System.Drawing.Point(5, 312);
            this.btnRegisterWithNumber.Name = "btnRegisterWithNumber";
            this.btnRegisterWithNumber.Size = new System.Drawing.Size(132, 23);
            this.btnRegisterWithNumber.TabIndex = 14;
            this.btnRegisterWithNumber.Text = "Register";
            this.btnRegisterWithNumber.UseVisualStyleBackColor = true;
            // 
            // btnLoadDb
            // 
            this.btnLoadDb.Location = new System.Drawing.Point(7, 380);
            this.btnLoadDb.Name = "btnLoadDb";
            this.btnLoadDb.Size = new System.Drawing.Size(304, 39);
            this.btnLoadDb.TabIndex = 1;
            this.btnLoadDb.Text = "Load Database";
            this.btnLoadDb.UseVisualStyleBackColor = true;
            // 
            // btnSaveDb
            // 
            this.btnSaveDb.Location = new System.Drawing.Point(317, 380);
            this.btnSaveDb.Name = "btnSaveDb";
            this.btnSaveDb.Size = new System.Drawing.Size(304, 39);
            this.btnSaveDb.TabIndex = 2;
            this.btnSaveDb.Text = "Save Database";
            this.btnSaveDb.UseVisualStyleBackColor = true;
            // 
            // RunnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBxRunnnerReg);
            this.Name = "RunnersForm";
            this.Text = "Form1";
            this.grpBxRunnnerReg.ResumeLayout(false);
            this.grpBxRunnnerReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxRunnnerReg;
        private System.Windows.Forms.TextBox txtStartingNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdBtFemale;
        private System.Windows.Forms.RadioButton rdBtMale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown nmrAge;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label lblFirstnName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegisterWithNumber;
        private System.Windows.Forms.Button btnSaveDb;
        private System.Windows.Forms.Button btnLoadDb;
    }
}