using System;
using System.Collections.Generic;
using System.Text;

namespace IOCExample
{
    class DALFactory
    {
        public static DAL GetDAL()
        {
            return new DAL();
        }
    }
}
