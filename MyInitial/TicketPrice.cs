﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private bool discount2;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecDiscount = 5.0m;
        const decimal mdecDiscount2 = 10.0m;
        const decimal mdecBack = 15.0m;


        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        private bool Discount2
        {
            get { return discount2; }
            set { discount2 = value; }
        }

        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TcicketPrice
    public TicketPrice(int section, int quantity, bool discount, bool discount2)
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
        Discount2 = discount2;
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
             case 4:
                 mPrice = mdecBack;
                 break;
            }
         if (discount==true && discount2 == false)
         { mPrice -= mdecDiscount; }
         if (discount == false && discount2 ==true)
         { mPrice -= mdecDiscount2; }
            AmountDue = mPrice * quantity;

     }
    }
}
