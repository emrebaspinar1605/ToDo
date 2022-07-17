using System;
using System.Collections.Generic;

namespace ToDo
{
    public class CardModel
    {
        private string header;
        private string content;
        private string appointedPerson;
        private string grown;
        private int situation=0;

        public string Header { get => header; set => header = value; }
        public string Content { get => content; set => content = value; }
        public string AppointedPerson { get => appointedPerson; set => appointedPerson = value; }
        public string Grown { 
            get {return grown;}
            set { grown = value;}
        }
        public int Situation { 
            get  {return situation;}
            set { situation = value;}
            }
    }
}