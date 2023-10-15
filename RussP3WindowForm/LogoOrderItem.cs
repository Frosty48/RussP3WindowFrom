using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace RussP3WindowForm
{
    class LogoOrderItem
    {
        private bool hasLogo = false;
        private int numColors = 0;
        private int numItems = 0;
        private double[] price;
        private string textEngrave = " ";
        private string results = " ";
        private string itemType = "";
        //private double totalSpent= 0;

        public bool HasLogo
        {
            get { return hasLogo; }
            set { hasLogo = value; CalculatePrice(); }
        }

        public string OrderId 
        { 
            get;
            set; 
        }
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; CalculatePrice(); }
        }

        public int NumColors
        {
            get { return numColors; }
            set { numColors = value; CalculatePrice(); }
        }

        public int NumItems
        {
            get { return numItems; }
            set { numItems = value; CalculatePrice(); }
        }

        public double[] Price
        {
            get { return price; }
            set { price = value; CalculatePrice(); }
        }

        public double TotalSpent 
        {
            get;
            set;
        }


        public string TextEngrave
        {
            get { return textEngrave; }
            set { textEngrave = value; CalculatePrice(); }
        }

        public string Results
        {
            get { return results; }
            set { results = value; CalculatePrice(); }
        }

        public LogoOrderItem()
        {
            CalculatePrice();
        }

        public LogoOrderItem(string orderId, string itemType, string textEngrave, string results)
        {
            OrderId = orderId;
            ItemType = itemType;
            TextEngrave = textEngrave;
            Results = results;
        }

        public LogoOrderItem(string itemId, string itemType, string textEngrave, double[] price, string results): this(itemId, itemType, textEngrave, results)
        {
            Price = price;
        }

        //Methods

        private void CalculatePrice()
        {
            double logoPrice = 0.10;

            double engravingPrice = 0.05;

            // Base price for the item type
            double basePrice = 0.0;

            // Additional price for colors
            double colorPrice = 0.0;

            if (itemType == "Mug")
            {
                basePrice = 3.50;
            }
            else if (itemType == "USB")
            {
                basePrice = 4.0;
            }
            else if (itemType== "Pen")
            {
                basePrice = 1.0;
            }

            if (HasLogo==true)
            {
                // Calculate additional price for colors
                colorPrice = numColors * 1.5;
            }
            if (textEngrave != null) {

                engravingPrice+=engravingPrice*numItems;
            }
            if (hasLogo == true) {

                logoPrice = logoPrice * numItems;
            
            }

            // Calculate the total price
            TotalSpent = (basePrice + colorPrice + engravingPrice  + logoPrice);
            //GetOrderSummary()
        }


        public string GetOrderSummary()
        {
            //spaced out like this because of the result box
            string summary = "The item you picked is " + ItemType +
                   " \r\nYour order number is " + OrderId +
                   "\r\nYou picked " + NumColors + " total number of colors" +
                   "\r\n Your engraving you want " + TextEngrave +
                   "\r\nThe total is " + TotalSpent +
                   "\r\n results: ";
            return summary;
        }
    }
}




