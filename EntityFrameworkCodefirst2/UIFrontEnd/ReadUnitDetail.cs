using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.UIFrontEnd
{
    public class ReadUnitDetail : IReadStudent<int>
    {
        public int ReadStudentDetails(){
            Console.Write("Enter Student ID : ");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
