using System;
using System.Collections.Generic;
using System.Text;

namespace IOCExample
{
    public class BLL
    {
        private IDAL _dal { get; set; }

        public BLL(IDAL dal)
        {
            _dal = dal;
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
