using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookManager
{
    public interface IBookManamger
    {
        public void AddBook();
        public void ViewAllBooks();
        public void FindBook();
    }
}
