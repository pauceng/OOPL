using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01Aprel
{
    class Invoice
    {
        string partNumber; //seri no
        string partDescription; //ürün açıklaması
        int quantity; //miktar
        decimal pricePerItem; //birim fiyatı

        public string PartNumber
        {
            get
            {
                return partNumber;
            }
            set
            {
                partNumber = value;
            }
        }

        public string PartDescription
        {
            get
            {
                return partDescription;
            }
            set
            {
                partDescription = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                    quantity = value;
            }
        }

        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if (value >= 0)
                    pricePerItem = value;
            }
        }

        public Invoice() { }
        public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
        {
            this.PartNumber = partNumber;
            this.PartDescription = partDescription;
            this.Quantity = quantity;
            this.PricePerItem = pricePerItem;
        }
        //Fatura miktarı birim fiyat * miktar
        public decimal GetInvoiceAmount()
        {
            return PricePerItem * Quantity;
        }
        //Display
        public string InvoiceDisplay()
        {
            return ("Part Number: "+PartNumber + "\nPart Description: " + PartDescription + "\nPart quantity: " + Quantity + "\nPart per item: " + PricePerItem).ToString();
        }
    }
}
