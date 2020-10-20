namespace wheretoeat
{
    partial class PlaceList
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
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvOptions = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnListClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // gbList
            // 
            this.gbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbList.Controls.Add(this.dgvOptions);
            this.gbList.Controls.Add(this.btnDelete);
            this.gbList.Controls.Add(this.btnAdd);
            this.gbList.Controls.Add(this.btnEdit);
            this.gbList.Location = new System.Drawing.Point(12, 12);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(479, 226);
            this.gbList.TabIndex = 14;
            this.gbList.TabStop = false;
            this.gbList.Text = "Selection List";
            // 
            // dgvOptions
            // 
            this.dgvOptions.AllowUserToAddRows = false;
            this.dgvOptions.AllowUserToDeleteRows = false;
            this.dgvOptions.AllowUserToResizeColumns = false;
            this.dgvOptions.AllowUserToResizeRows = false;
            this.dgvOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOptions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOptions.Location = new System.Drawing.Point(6, 20);
            this.dgvOptions.MultiSelect = false;
            this.dgvOptions.Name = "dgvOptions";
            this.dgvOptions.ReadOnly = true;
            this.dgvOptions.RowHeadersVisible = false;
            this.dgvOptions.RowTemplate.Height = 23;
            this.dgvOptions.RowTemplate.ReadOnly = true;
            this.dgvOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOptions.Size = new System.Drawing.Size(386, 200);
            this.dgvOptions.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(398, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(398, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(398, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnListClose
            // 
            this.btnListClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnListClose.Location = new System.Drawing.Point(416, 244);
            this.btnListClose.Name = "btnListClose";
            this.btnListClose.Size = new System.Drawing.Size(75, 23);
            this.btnListClose.TabIndex = 15;
            this.btnListClose.Text = "Close";
            this.btnListClose.UseVisualStyleBackColor = true;
            this.btnListClose.Click += new System.EventHandler(this.btnListClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(335, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PlaceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnListClose;
            this.ClientSize = new System.Drawing.Size(501, 279);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnListClose);
            this.Controls.Add(this.gbList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(517, 318);
            this.Name = "PlaceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.Load += new System.EventHandler(this.PlaceList_Load);
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgvOptions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnListClose;
        private System.Windows.Forms.Button btnSave;
    }
}