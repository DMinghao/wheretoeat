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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static BindingList<Place> pList;
        private BindingList<Place> historyPlaces;
        private FilterSetup pFilter; 
        private Random r = new Random(DateTime.Now.Second); 

        private void datafill()
        {
            pList.Clear(); 
            pList.Add(new Place(Place.placeType.Chinese, "Mr. Chen"));
            pList.Add(new Place(Place.placeType.American, "OutBack"));
            pList.Add(new Place(Place.placeType.Japanese, "Hokkaido"));
            pList.Add(new Place(Place.placeType.American, "MugShot"));
            pList.Add(new Place(Place.placeType.Chinese, "Lai Lai Lai"));
            UpdateCheckList(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pList = new BindingList<Place>();
            historyPlaces = new BindingList<Place>(); 
            datafill();
            pFilter = new FilterSetup();
            cboxEnableSF.Checked = true;
            UpdateCheckList();
            //pFilter.SelectedPlaces.Add(new Place(Place.placeType.American, "MugShot"));
            readFilterClass(); 
        }

        private void UpdateCheckList()
        {
            checkedListBox1.Items.Clear(); 
            if(pList != null)
            {
                foreach (Place i in pList)
                {
                    checkedListBox1.Items.Add(i.PlaceName);
                }
            }
        }

        private void readFilterClass()
        {
            cboxFilter1.Checked = pFilter.CheckBox1; 
            cboxFilter2.Checked = pFilter.CheckBox2; 
            cboxFilter3.Checked = pFilter.CheckBox3; 
            cboxFilter4.Checked = pFilter.CheckBox4;
            cboxEnableSF.Checked = pFilter.ListEnabled; 
            if(pFilter.SelectedPlaces != null)
            {
                foreach (Place i in pFilter.SelectedPlaces)
                {
                    for(int a = 0; a < checkedListBox1.Items.Count; a++)
                    {
                        if (i.PlaceName == checkedListBox1.Items[a].ToString())
                        {
                            checkedListBox1.SetItemChecked(a, true);
                            break; 
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void editListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceList d = new PlaceList();
            d.ShowDialog();
            UpdateCheckList(); 
        }

        private void addFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("You are about to clear the list, are you sure? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                DialogResult d2 = MessageBox.Show("Do you really want to clear the list? ", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d2 == DialogResult.Yes)
                {
                    pList = new BindingList<Place>();
                    MessageBox.Show("List cleared"); 
                }
            }
            UpdateCheckList(); 
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Loading this list will Clear your current list, are you sure? ", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                datafill();
                MessageBox.Show("Default List loaded. ");
            }
        }

        private void cboxEnableSF_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxEnableSF.Checked == true) checkedListBox1.Enabled = true;
            if (cboxEnableSF.Checked == false) checkedListBox1.Enabled = false; 
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            btnRoll.Enabled = false; 
            string result;
            Place outResult = new Place(); 
            int totalOption = pList.Count();
            int output;
            do
            {
                output = r.Next(0, int.MaxValue) % totalOption;
                outResult = pList[output];
            } while (!checkResult(outResult));

            lbHistoryTime.Text = outResult.LastTime;
            historyPlaces.Add(outResult);
            tbHistory.AppendText(outResult.PlaceName + Environment.NewLine);
            tbResult.Text = outResult.PlaceName; 
            btnRoll.Enabled = true; 
        }

        private bool checkResult(Place input)
        {
            if(cboxEnableSF.Checked == true)
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    if (input.PlaceName == checkedListBox1.CheckedItems[i].ToString()) return false;
                }
            }
            
            for(int i = 1; i <= numericUpDown1.Value; i++)
            {
                if(historyPlaces.Count > 0 && historyPlaces.Count > numericUpDown1.Value)
                {
                    if (historyPlaces[historyPlaces.Count-i].PlaceName == input.PlaceName) return false; 
                }
            }
            if (cboxFilter1.Checked == true && input.Type == Place.placeType.American.ToString()) return false; 
            else if (cboxFilter2.Checked == true && input.Type == Place.placeType.Chinese.ToString()) return false; 
            else if (cboxFilter3.Checked == true && input.Type == Place.placeType.Japanese.ToString()) return false; 
            else if (cboxFilter4.Checked == true && input.Type == Place.placeType.Other.ToString()) return false;
            else return true;
        }
    }
}
