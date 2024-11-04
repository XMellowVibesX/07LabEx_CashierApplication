using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class Item
    {
        protected string itemName;
        protected double itemPrice, totalPrice;
        protected int itemQuantity;

        public Item(string itemName, double itemPrice, int itemQuantity)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.itemQuantity = itemQuantity;
            this.totalPrice = itemPrice * itemQuantity;
        }
    }


        public class DiscountedItem : Item
        {
            private double itemDiscount, discountedPrice, paymentAmount, change;

            public DiscountedItem(string itemName, double itemPrice, int itemQuantity, double itemDiscount) : base(itemName, itemPrice, itemQuantity)
            {
                this.itemDiscount = itemDiscount * 0.01;
                this.discountedPrice = this.totalPrice - (totalPrice * this.itemDiscount);
            }


            public double getDiscountedPrice()
            {
                return discountedPrice;
            }

            public void setPaymentAmount(double paymentAmount)
            {
                this.paymentAmount = paymentAmount;
            }

            public double getChange()
            {
                this.change = paymentAmount - discountedPrice;
                return change;
            }
        }
    
}
