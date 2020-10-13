﻿using Hemsida.Data.Entities;
using System.Collections.Generic;

namespace Hemsida.Data
{
    public interface IHemsidaRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        public bool SaveAll();
   }
}