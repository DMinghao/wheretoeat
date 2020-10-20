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
    public partial class InputInfo : Form
    {
        public InputInfo()
        {
            InitializeComponent();
        }

        public void ifEdit(Place input)
        {
            textBox1.Text = input.PlaceName;
            comboBox1.SelectedItem = input.Type;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            btnSaveInfo.Enabled = false;
            string test = textBox1.Text;
            Place outresult = new Place();
            if(MainForm.pList.Count != 0)
            {
                foreach (Place i in MainForm.pList)
                {
                    if (test == i.PlaceName)
                    {
                        MessageBox.Show("Place is already in the list. ");
                        btnSaveInfo.Enabled = true;
                        return;
                    }
                }
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please selecte a type");
                btnSaveInfo.Enabled = true;
                return; 
            }
            switch (comboBox1.SelectedItem.ToString())
            {
                case ("American"):
                    outresult = new Place(Place.placeType.American, test);
                    break;
                case ("Chinese"):
                    outresult = new Place(Place.placeType.Chinese, test);
                    break;
                case ("Japanese"):
                    outresult = new Place(Place.placeType.Japanese, test);
                    break;
                case ("Other"):
                    outresult = new Place(Place.placeType.Other, test);
                    break;
            }
            this.Tag = outresult;
            DialogResult = DialogResult.OK;
            this.Close(); 
            btnSaveInfo.Enabled = true; 
        }
        
    }
}
