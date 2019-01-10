using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic4
{
    class Money
    {


        private int _NumberBill; // Номинал купюры
        private int _countBills; // Кол-во купюр
        private int _Sum; // Общее кол-во денежных средств
        public Money()
        {
        }
        public Money(int NumberBill,int countBills)
        {
            _NumberBill = NumberBill;
            _countBills = countBills;
            _Sum = _NumberBill * _countBills;

        }
        public int GetNumberBill()
        {
            return _NumberBill;
        }
        public void SetNumberBill(int NumberBill)
        {

            _NumberBill = NumberBill;
        }

        public int GetCountBills()
        {
            return _countBills;
        }
        public void SetCountBills(int countBills)
        {

            _countBills = countBills;
        }
        public bool IsThereEnoughMoney(int PriceProduct)
        {
            if(PriceProduct <=_Sum)
            {
            return true;
            }
            return false;
        }
        public int CanBuyProducts(int PriceProduct)
        {
            return _Sum / PriceProduct;
        }

        public int NumberBill
        {
            get => _NumberBill; 
            set =>_NumberBill = value; 
        }
        public int CountBills
        {
            get =>_countBills; 
            set =>_countBills = value; 
        }
        public int Sum
        {
            get => _Sum; 
        }
    }
}
