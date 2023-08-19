using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.BackEndDataOp
{
    public interface IDbOperation<T, TKey>
    {
        public IQueryable<T> Fetch(TKey searchId);
        public T Write(T writeValue);
    }
}
