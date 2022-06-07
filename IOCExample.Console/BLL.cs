﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IOCExample
{
    public class BLL
    {
        private DAL _dal { get; set; }

        public BLL()
        {
            _dal = new DAL();
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}