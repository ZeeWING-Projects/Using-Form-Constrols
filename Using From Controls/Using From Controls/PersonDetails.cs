using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_From_Controls
{
    class PersonDetails
    {
        public int index { get; set; }
        public string name { get; set; }
        public string catagory { get; set; }
        public  string gender { get; set; }
        public ArrayList profiles;
        public PersonDetails(string name, string catagory, string gender,ArrayList profiles)
        {
            this.name = name;
            this.catagory = catagory;
            this.gender = gender;
            this.profiles = profiles;
        }


    }
}
