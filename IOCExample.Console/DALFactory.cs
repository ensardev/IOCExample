using System;
using System.Collections.Generic;
using System.Text;

namespace IOCExample
{
    class DALFactory
    {
        internal static IDAL GetDAL()
        {
            return new DAL();
        }
    }
}
