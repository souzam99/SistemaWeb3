﻿using SistemaWeb3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWeb3.Services
{
    public class SellerService
    {
        private readonly SistemaWeb3Context _context;

        public SellerService(SistemaWeb3Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
