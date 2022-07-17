using System;
using System.Collections.Generic;

namespace ToDo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.DefaultCard();
            operation.DefaultPerson();
            operation.LetsGo();
            bool control = true;
            while (control)
            {
                
                Console.WriteLine("Lütfen 1 ile 5 Arasında Bir İşlem Seçiniz");
                int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1 : operation.GetList(); break;

                    case 2 : operation.Add(); break;

                    case 3 : operation.Delete(); break;

                    case 4 : operation.MoveCard(); break;

                    case 5 : control = false; break;
                    
                }
            }
        }
    }
}