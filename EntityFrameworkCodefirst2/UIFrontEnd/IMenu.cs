using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.UIFrontEnd
{
    public interface IMenu<T>
    {
        public T DisplayMenu();
    }
}
