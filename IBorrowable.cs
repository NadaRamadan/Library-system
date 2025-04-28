using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    public interface IBorrowable
    {
        void borrow();
        void returnBook();
        double calculatePenality(int days);

    }
}
