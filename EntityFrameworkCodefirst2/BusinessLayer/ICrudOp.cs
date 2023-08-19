using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.BusinessLayer
{
    public interface ICrudOp<T>
    {
        public T Add();
        public T Update();
        public T Delete();
        public T View();
    }
}
