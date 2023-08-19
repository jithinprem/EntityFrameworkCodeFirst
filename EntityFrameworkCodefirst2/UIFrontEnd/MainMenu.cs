using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.UIFrontEnd
{
    public class MainMenu : IMenu<int>
    {
        public int DisplayMenu() {

            Console.WriteLine("1) Add Student Data ");
            Console.WriteLine("2) Add Student Marks ");
            Console.WriteLine("3) Find TOP 3 student ");
            Console.WriteLine("4) Find LastTOP 3 student ");
            

            Console.WriteLine("\nEnter : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

    }
}
