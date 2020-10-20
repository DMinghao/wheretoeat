namespace wheretoeat
{
    partial class InputInfo
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
            this.lbname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbtype = new System.Windows.Forms.Label();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(13, 13);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(29, 12);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 21);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "American",
            "Chinese",
            "Japanese",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(60, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Location = new System.Drawing.Point(13, 54);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(29, 12);
            this.lbtype.TabIndex = 3;
            this.lbtype.Text = "type";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(60, 91);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInfo.TabIndex = 4;
            this.btnSaveInfo.Text = "Save";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(141, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InputInfo
            // 
            this.AcceptButton = this.btnSaveInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 126);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.lbtype);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputInfo";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Button btnCancel;
    }
}