using System;

namespace ToDo
{
    public class PersonModel
    {
        private string no;
        private string name;
        private string surName;

        public string No { get => no; set => no = value; }
        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
    }
}