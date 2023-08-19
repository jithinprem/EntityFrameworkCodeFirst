using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.UIFrontEnd
{
    public interface IReadStudent<T>
    {
        public T ReadStudentDetails();
      
    }
}
