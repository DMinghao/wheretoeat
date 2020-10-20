using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheretoeat
{
    public class FilterSetup
    {
        private bool checkBox1;
        private bool checkBox2;
        private bool checkBox3;
        private bool checkBox4;
        private int history;
        private bool listEnabled;
        private List<Place> selectedPlaces;
        
        public FilterSetup()
        {
            checkBox1 = checkBox2 = checkBox3 = checkBox4 = false;
            history = 0;
            listEnabled = true; 
            selectedPlaces = new List<Place>(); 
        }

        public FilterSetup(bool cb1, bool cb2, bool cb3, bool cb4, int h, bool list, List<Place> p)
        {
            checkBox1 = cb1;
            checkBox2 = cb2;
            checkBox3 = cb3;
            checkBox4 = cb4;
            history = h;
            listEnabled = list; 
            foreach (Place i in p) selectedPlaces.Add(i);
        }

        public bool CheckBox1 { get => checkBox1;}
        public bool CheckBox2 { get => checkBox2;}
        public bool CheckBox3 { get => checkBox3;}
        public bool CheckBox4 { get => checkBox4;}
        public int History { get => history;}
        public List<Place> SelectedPlaces { get => selectedPlaces;}
        public bool ListEnabled { get => listEnabled;}
    }
}
