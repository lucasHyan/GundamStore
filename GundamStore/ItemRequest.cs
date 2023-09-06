using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamStore
{
    internal class ItemRequest
    {
        private const double ItemZeta = 99.99;
        private const double ItemGundam = 30.00;
        private const double ItemZaku = 75.50;

        public int RequestNumber { get; }
        public static int QuantityZeta { get; private set; }
        public static int QuantityGundam { get; private set; }
        public static int QuantityZaku { get; private set; }

        public ItemRequest()
        {
            RequestNumber = new Random().Next(1000, 10000); 
        }

        public void AddZeta()
        {
            QuantityZeta++;
        }

        public void AddGundam()
        {
            QuantityGundam++;
        }

        public void AddZaku()
        {
            QuantityZaku++;
        }

        public double CalculateTotal()
        {
            double total = (QuantityZeta * ItemZeta) + (QuantityGundam * ItemGundam) + (QuantityZaku * ItemZaku);

            return total;
        }
    }
}