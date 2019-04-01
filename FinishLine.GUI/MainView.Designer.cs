namespace FinishLine
{
    partial class MainView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newTournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxRaceParameters = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblLaps = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblWinners = new System.Windows.Forms.Label();
            this.btnStartRace = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grpBxRaceParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTournamentToolStripMenuItem,
            this.runnersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newTournamentToolStripMenuItem
            // 
            this.newTournamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitAppToolStripMenuItem});
            this.newTournamentToolStripMenuItem.Name = "newTournamentToolStripMenuItem";
            this.newTournamentToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.newTournamentToolStripMenuItem.Text = "New tournament";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createToolStripMenuItem.Text = "New Event";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save race";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load race";
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitAppToolStripMenuItem.Text = "Exit app";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.exitAppToolStripMenuItem_Click);
            // 
            // runnersToolStripMenuItem
            // 
            this.runnersToolStripMenuItem.Name = "runnersToolStripMenuItem";
            this.runnersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.runnersToolStripMenuItem.Text = "Runners";
            this.runnersToolStripMenuItem.Click += new System.EventHandler(this.runnersToolStripMenuItem_Click);
            // 
            // grpBxRaceParameters
            // 
            this.grpBxRaceParameters.Controls.Add(this.lblStartTime);
            this.grpBxRaceParameters.Controls.Add(this.btnStartRace);
            this.grpBxRaceParameters.Controls.Add(this.textBox3);
            this.grpBxRaceParameters.Controls.Add(this.lblWinners);
            this.grpBxRaceParameters.Controls.Add(this.textBox2);
            this.grpBxRaceParameters.Controls.Add(this.lblLaps);
            this.grpBxRaceParameters.Controls.Add(this.textBox1);
            this.grpBxRaceParameters.Controls.Add(this.lblDistance);
            this.grpBxRaceParameters.Location = new System.Drawing.Point(13, 28);
            this.grpBxRaceParameters.Name = "grpBxRaceParameters";
            this.grpBxRaceParameters.Size = new System.Drawing.Size(238, 197);
            this.grpBxRaceParameters.TabIndex = 2;
            this.grpBxRaceParameters.TabStop = false;
            this.grpBxRaceParameters.Text = "Race parameters:";
            this.grpBxRaceParameters.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(6, 30);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(73, 13);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Lap Distance:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblLaps
            // 
            this.lblLaps.AutoSize = true;
            this.lblLaps.Location = new System.Drawing.Point(6, 60);
            this.lblLaps.Name = "lblLaps";
            this.lblLaps.Size = new System.Drawing.Size(85, 13);
            this.lblLaps.TabIndex = 2;
            this.lblLaps.Text = "Number of Laps:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(132, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lblWinners
            // 
            this.lblWinners.AutoSize = true;
            this.lblWinners.Location = new System.Drawing.Point(6, 90);
            this.lblWinners.Name = "lblWinners";
            this.lblWinners.Size = new System.Drawing.Size(101, 13);
            this.lblWinners.TabIndex = 4;
            this.lblWinners.Text = "Number of Winners:";
            // 
            // btnStartRace
            // 
            this.btnStartRace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartRace.Location = new System.Drawing.Point(132, 125);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(100, 23);
            this.btnStartRace.TabIndex = 6;
            this.btnStartRace.Text = "Start race";
            this.btnStartRace.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 300);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(258, 349);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(714, 300);
            this.dataGridView2.TabIndex = 4;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(6, 169);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(72, 13);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "Starting Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 418);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpBxRaceParameters);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainView";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxRaceParameters.ResumeLayout(false);
            this.grpBxRaceParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newTournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runnersToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBxRaceParameters;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblLaps;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblWinners;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

