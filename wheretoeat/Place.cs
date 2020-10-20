using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheretoeat
{
    public class Place
    {
        public enum placeType {Chinese, Japanese, American, Other};
        private placeType? t; 
        private string placeName;
        private DateTime? lastTime;
        private string placeT;
        private string lt; 

        public string PlaceName { get => placeName; set => placeName = value; }
        public string Type { get => placeT; set => placeT = value; }
        public string LastTime { get => lt; set => lt = value; }

        public Place()
        {
            t = null;
            placeName = null;
            lastTime = null; 
        }

        public Place(placeType inT, string name)
        {
            placeT = inT.ToString(); 
            t = inT;
            placeName = name;
            lastTime = DateTime.Now;
            lt = lastTime.ToString(); 
        }
    }
}
