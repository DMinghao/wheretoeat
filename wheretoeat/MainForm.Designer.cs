namespace wheretoeat
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.gbSelecteFilter = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cboxEnableSF = new System.Windows.Forms.CheckBox();
            this.gbHistoryFilter = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbGroupFilter = new System.Windows.Forms.GroupBox();
            this.cboxFilter1 = new System.Windows.Forms.CheckBox();
            this.cboxFilter4 = new System.Windows.Forms.CheckBox();
            this.cboxFilter2 = new System.Windows.Forms.CheckBox();
            this.cboxFilter3 = new System.Windows.Forms.CheckBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbHistory = new System.Windows.Forms.TextBox();
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.lbHistoryTime = new System.Windows.Forms.Label();
            this.randomFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFilter.SuspendLayout();
            this.gbSelecteFilter.SuspendLayout();
            this.gbHistoryFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbGroupFilter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoll.Location = new System.Drawing.Point(506, 318);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbFilter.Controls.Add(this.gbSelecteFilter);
            this.gbFilter.Controls.Add(this.gbHistoryFilter);
            this.gbFilter.Controls.Add(this.gbGroupFilter);
            this.gbFilter.Location = new System.Drawing.Point(155, 28);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(426, 254);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // gbSelecteFilter
            // 
            this.gbSelecteFilter.BackColor = System.Drawing.SystemColors.Control;
            this.gbSelecteFilter.Controls.Add(this.checkedListBox1);
            this.gbSelecteFilter.Controls.Add(this.cboxEnableSF);
            this.gbSelecteFilter.Location = new System.Drawing.Point(202, 20);
            this.gbSelecteFilter.Name = "gbSelecteFilter";
            this.gbSelecteFilter.Size = new System.Drawing.Size(218, 228);
            this.gbSelecteFilter.TabIndex = 6;
            this.gbSelecteFilter.TabStop = false;
            this.gbSelecteFilter.Text = "Selecte Filter";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(206, 180);
            this.checkedListBox1.TabIndex = 1;
            // 
            // cboxEnableSF
            // 
            this.cboxEnableSF.AutoSize = true;
            this.cboxEnableSF.Location = new System.Drawing.Point(7, 19);
            this.cboxEnableSF.Name = "cboxEnableSF";
            this.cboxEnableSF.Size = new System.Drawing.Size(60, 16);
            this.cboxEnableSF.TabIndex = 0;
            this.cboxEnableSF.Text = "Enable";
            this.cboxEnableSF.UseVisualStyleBackColor = true;
            this.cboxEnableSF.CheckedChanged += new System.EventHandler(this.cboxEnableSF_CheckedChanged);
            // 
            // gbHistoryFilter
            // 
            this.gbHistoryFilter.BackColor = System.Drawing.SystemColors.Control;
            this.gbHistoryFilter.Controls.Add(this.numericUpDown1);
            this.gbHistoryFilter.Location = new System.Drawing.Point(6, 135);
            this.gbHistoryFilter.Name = "gbHistoryFilter";
            this.gbHistoryFilter.Size = new System.Drawing.Size(190, 51);
            this.gbHistoryFilter.TabIndex = 5;
            this.gbHistoryFilter.TabStop = false;
            this.gbHistoryFilter.Text = "History Filter";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown1.Location = new System.Drawing.Point(6, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(178, 21);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbGroupFilter
            // 
            this.gbGroupFilter.BackColor = System.Drawing.SystemColors.Control;
            this.gbGroupFilter.Controls.Add(this.cboxFilter1);
            this.gbGroupFilter.Controls.Add(this.cboxFilter4);
            this.gbGroupFilter.Controls.Add(this.cboxFilter2);
            this.gbGroupFilter.Controls.Add(this.cboxFilter3);
            this.gbGroupFilter.Location = new System.Drawing.Point(6, 20);
            this.gbGroupFilter.Name = "gbGroupFilter";
            this.gbGroupFilter.Size = new System.Drawing.Size(190, 109);
            this.gbGroupFilter.TabIndex = 4;
            this.gbGroupFilter.TabStop = false;
            this.gbGroupFilter.Text = "Group Filter";
            // 
            // cboxFilter1
            // 
            this.cboxFilter1.AutoSize = true;
            this.cboxFilter1.Location = new System.Drawing.Point(6, 20);
            this.cboxFilter1.Name = "cboxFilter1";
            this.cboxFilter1.Size = new System.Drawing.Size(102, 16);
            this.cboxFilter1.TabIndex = 0;
            this.cboxFilter1.Text = "American Food";
            this.cboxFilter1.UseVisualStyleBackColor = true;
            // 
            // cboxFilter4
            // 
            this.cboxFilter4.AutoSize = true;
            this.cboxFilter4.Location = new System.Drawing.Point(6, 86);
            this.cboxFilter4.Name = "cboxFilter4";
            this.cboxFilter4.Size = new System.Drawing.Size(60, 16);
            this.cboxFilter4.TabIndex = 3;
            this.cboxFilter4.Text = "Others";
            this.cboxFilter4.UseVisualStyleBackColor = true;
            // 
            // cboxFilter2
            // 
            this.cboxFilter2.AutoSize = true;
            this.cboxFilter2.Location = new System.Drawing.Point(6, 42);
            this.cboxFilter2.Name = "cboxFilter2";
            this.cboxFilter2.Size = new System.Drawing.Size(96, 16);
            this.cboxFilter2.TabIndex = 1;
            this.cboxFilter2.Text = "Chinese Food";
            this.cboxFilter2.UseVisualStyleBackColor = true;
            // 
            // cboxFilter3
            // 
            this.cboxFilter3.AutoSize = true;
            this.cboxFilter3.Location = new System.Drawing.Point(6, 64);
            this.cboxFilter3.Name = "cboxFilter3";
            this.cboxFilter3.Size = new System.Drawing.Size(102, 16);
            this.cboxFilter3.TabIndex = 2;
            this.cboxFilter3.Text = "Japanese Food";
            this.cboxFilter3.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbResult.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbResult.ForeColor = System.Drawing.Color.Green;
            this.tbResult.Location = new System.Drawing.Point(58, 288);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(523, 20);
            this.tbResult.TabIndex = 5;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(10, 291);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(41, 12);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "Result";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOption,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(593, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOption
            // 
            this.menuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFilterToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportListToolStripMenuItem,
            this.loadListToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.menuOption.Name = "menuOption";
            this.menuOption.Size = new System.Drawing.Size(60, 21);
            this.menuOption.Text = "Option";
            // 
            // saveFilterToolStripMenuItem
            // 
            this.saveFilterToolStripMenuItem.Name = "saveFilterToolStripMenuItem";
            this.saveFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFilterToolStripMenuItem.Text = "Save Filter";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load Filter";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exportListToolStripMenuItem
            // 
            this.exportListToolStripMenuItem.Name = "exportListToolStripMenuItem";
            this.exportListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportListToolStripMenuItem.Text = "Export List";
            // 
            // loadListToolStripMenuItem
            // 
            this.loadListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.myListToolStripMenuItem});
            this.loadListToolStripMenuItem.Name = "loadListToolStripMenuItem";
            this.loadListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadListToolStripMenuItem.Text = "Load List";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.defaultToolStripMenuItem.Text = "Default List";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // myListToolStripMenuItem
            // 
            this.myListToolStripMenuItem.Name = "myListToolStripMenuItem";
            this.myListToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.myListToolStripMenuItem.Text = "My list";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editListToolStripMenuItem,
            this.addFilterToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.clearFilterToolStripMenuItem,
            this.randomFilterToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editListToolStripMenuItem
            // 
            this.editListToolStripMenuItem.Name = "editListToolStripMenuItem";
            this.editListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editListToolStripMenuItem.Text = "Edit List";
            this.editListToolStripMenuItem.Click += new System.EventHandler(this.editListToolStripMenuItem_Click);
            // 
            // addFilterToolStripMenuItem
            // 
            this.addFilterToolStripMenuItem.Name = "addFilterToolStripMenuItem";
            this.addFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFilterToolStripMenuItem.Text = "Clear List";
            this.addFilterToolStripMenuItem.Click += new System.EventHandler(this.addFilterToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Clear History";
            // 
            // clearFilterToolStripMenuItem
            // 
            this.clearFilterToolStripMenuItem.Name = "clearFilterToolStripMenuItem";
            this.clearFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearFilterToolStripMenuItem.Text = "Clear Filter";
            // 
            // tbHistory
            // 
            this.tbHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHistory.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbHistory.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHistory.ForeColor = System.Drawing.Color.Red;
            this.tbHistory.Location = new System.Drawing.Point(6, 20);
            this.tbHistory.Multiline = true;
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.ReadOnly = true;
            this.tbHistory.Size = new System.Drawing.Size(125, 197);
            this.tbHistory.TabIndex = 12;
            // 
            // gbHistory
            // 
            this.gbHistory.Controls.Add(this.lbHistoryTime);
            this.gbHistory.Controls.Add(this.tbHistory);
            this.gbHistory.Location = new System.Drawing.Point(12, 28);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(137, 254);
            this.gbHistory.TabIndex = 12;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "History";
            // 
            // lbHistoryTime
            // 
            this.lbHistoryTime.AutoSize = true;
            this.lbHistoryTime.Location = new System.Drawing.Point(4, 229);
            this.lbHistoryTime.Name = "lbHistoryTime";
            this.lbHistoryTime.Size = new System.Drawing.Size(0, 12);
            this.lbHistoryTime.TabIndex = 13;
            // 
            // randomFilterToolStripMenuItem
            // 
            this.randomFilterToolStripMenuItem.Name = "randomFilterToolStripMenuItem";
            this.randomFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randomFilterToolStripMenuItem.Text = "Random Filter";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(593, 353);
            this.Controls.Add(this.gbHistory);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(609, 392);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Where To Eat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbSelecteFilter.ResumeLayout(false);
            this.gbSelecteFilter.PerformLayout();
            this.gbHistoryFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbGroupFilter.ResumeLayout(false);
            this.gbGroupFilter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbHistory.ResumeLayout(false);
            this.gbHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.CheckBox cboxFilter4;
        private System.Windows.Forms.CheckBox cboxFilter3;
        private System.Windows.Forms.CheckBox cboxFilter2;
        private System.Windows.Forms.CheckBox cboxFilter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOption;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFilterToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbGroupFilter;
        private System.Windows.Forms.GroupBox gbHistoryFilter;
        private System.Windows.Forms.GroupBox gbSelecteFilter;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox cboxEnableSF;
        private System.Windows.Forms.TextBox tbHistory;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.Label lbHistoryTime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem randomFilterToolStripMenuItem;
    }
}

