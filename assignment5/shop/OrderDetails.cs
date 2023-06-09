﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    public class OrderDetails : IEquatable<OrderDetails>
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Amount => Price * Quantity;

        public OrderDetails(string productName, decimal price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return Equals(obj as OrderDetails);
        }

        public bool Equals(OrderDetails other)
        {
            return other != null && ProductName == other.ProductName;
        }

        public override int GetHashCode()
        {
            return ProductName.GetHashCode();
        }

        public override string ToString()
        {
            return $"Product Name: {ProductName}, Price: {Price}, Quantity: {Quantity}, Amount: {Amount}";
        }
    }
}
