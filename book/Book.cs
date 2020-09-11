using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Book:Author
    {
        private double price;
        private int qty;
        public Book(string name,string email,string gender,double price,int qty):base(name,email,gender)
        {
            this.price = price;
            this.qty = qty;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public double getQty()
        {
            return qty;
        }
        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public override string toString()
        {
            return base.toString()+",price="+price+",qty="+qty;
        }

    }
}
