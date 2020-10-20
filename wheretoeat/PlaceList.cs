using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wheretoeat
{
    public partial class PlaceList : Form
    {
        public PlaceList()
        {
            InitializeComponent();
        }

        private BindingList<Place> tempList;
        private bool changed;
        private string path;
        private string defaultFileOut; 

        private void btnListClose_Click(object sender, EventArgs e)
        {
            btnListClose.Enabled = false; 
            if (changed)
            {
                DialogResult d = MessageBox.Show("You have made changes to the list, do you want to clsoe? ", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(d == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Cancel;
                    this.Close(); 
                }
                else
                {
                    btnListClose.Enabled = true;
                    return; 
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InputInfo n = new InputInfo();
            n.ShowDialog();
            if (n.DialogResult == DialogResult.OK)
            {
                changed = true; 
                Place p = (Place)n.Tag;
                tempList.Add(p); 
            }
        }

        private void PlaceList_Load(object sender, EventArgs e)
        {
            tempList = new BindingList<Place>(); 
            foreach (Place i in MainForm.pList) tempList.Add(i); 
            dgvOptions.DataSource = typeof(Place);
            dgvOptions.DataSource = tempList; 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            changed = false; 
            btnEdit.Enabled = false; 
            if (dgvOptions.SelectedRows.Count == 1)
            {
                Place edittemp = (Place)dgvOptions.SelectedRows[0].DataBoundItem;
                InputInfo n = new InputInfo();
                n.ifEdit(edittemp);
                n.ShowDialog(); 
                if(n.DialogResult == DialogResult.OK)
                {
                    changed = true; 
                    Place p = (Place)n.Tag;
                    for(int i = 0; i < tempList.Count; i++)
                    {
                        if(tempList[i] == edittemp)
                        {
                            tempList[i] = p; 
                            break; 
                        }
                    }
                }
            }
            btnEdit.Enabled = true; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false; 
            Place edittemp = (Place)dgvOptions.SelectedRows[0].DataBoundItem;
            DialogResult d = MessageBox.Show($"Do you really want to delete {edittemp.PlaceName} ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if(d == DialogResult.Yes)
            {
                changed = true; 
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i] == edittemp) tempList.Remove(MainForm.pList[i]); 
                }
            }
            if(d == DialogResult.No)
            {
                btnDelete.Enabled = true;
                return; 
            }
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (changed)
            {
                MainForm.pList = new BindingList<Place>();
                foreach (Place a in tempList) MainForm.pList.Add(a); 
            }
            this.Close(); 
        }
    }
}
