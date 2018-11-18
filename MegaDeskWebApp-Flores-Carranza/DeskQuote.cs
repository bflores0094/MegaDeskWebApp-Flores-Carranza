using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;


namespace MegaDeskWebApp_Flores_Carranza
{
    class DeskQuote
    {
        public Desk Desk { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Shipping { get; set; }
        const decimal BASE_PRICE = 200;
        public decimal materialInt;

        public DeskQuote(Desk Desk, string Name, decimal shippingNum)
        {
            this.Desk = Desk;
            this.Name = Name;
            this.Date = DateTime.Now;
            decimal size = Desk.widthInput * Desk.heightInput;
            this.Shipping = CalcShipping(shippingNum, size);
            decimal materialCost = GetMatCost(Desk.materialNum);
            this.Cost = GetQuote(size, this.Shipping, materialCost);
            materialInt = Desk.materialNum;

        }

        public decimal CalcShipping(decimal shippingNum, decimal size)
        {
            decimal tempShip;

            if (shippingNum == 3)
            {
                if (size < 1000)
                {
                    tempShip = 60;
                }
                else if (size < 2001)
                {
                    tempShip = 70;
                }
                else
                {
                    tempShip = 80;
                }
            }
            else if (shippingNum == 5)
            {
                if (size < 1000)
                {
                    tempShip = 40;
                }
                else if (size < 2001)
                {
                    tempShip = 45;
                }
                else
                {
                    tempShip = 60;
                }
            }
            else
            {
                if (size < 1000)
                {
                    tempShip = 60;
                }
                else if (size < 2001)
                {
                    tempShip = 70;
                }
                else
                {
                    tempShip = 80;
                }
            }
            return tempShip;
        }

        public decimal GetMatCost(decimal matNum)
        {
            decimal tempMat;

            if (matNum == 1)
            {
                tempMat = 200;
            }
            else if (matNum == 2)
            {
                tempMat = 100;
            }
            else if (matNum == 3)
            {
                tempMat = 50;
            }
            else if (matNum == 4)
            {
                tempMat = 300;
            }
            else
            {
                tempMat = 125;
            }
            return tempMat;
        }

        public decimal GetQuote(decimal size, decimal shipping, decimal materialCost)
        {
            decimal cost;

            if (size < 1000)
            {
                cost = BASE_PRICE + shipping + materialCost;
            }
            else
            {
                cost = BASE_PRICE + size + shipping + materialCost;
            }
            return cost;
        }





    }
}
