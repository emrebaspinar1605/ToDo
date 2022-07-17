using System;
using System.Collections.Generic;

namespace ToDo
{
    public class Person
    {
        private List<PersonModel> persons;
        
        public Person()
        {
            persons=new List<PersonModel>();
        }

        public void Add(string no,string name,string surName)
        {
            PersonModel personModel = new PersonModel();
            personModel.No = no;
            personModel.Name = name;
            personModel.SurName = surName;
            persons.Add(personModel);
        }

        public string Find(string number)
        {
            string result = "";

            foreach (var person in persons)
            {
                if (person.No == number)
                {
                    result = person.Name + " " + person.SurName;
                }
            }
            return result;
        }

        public bool ItsHave(string number)
        {
            bool result = false;

            foreach (var person in persons)
            {
                if (person.No == number)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}