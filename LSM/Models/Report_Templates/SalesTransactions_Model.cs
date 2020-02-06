using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models.Report_Templates
{
    public class SalesTransactions_Model : INotifyPropertyChanged
    {
        private int transaction_number { get; set; }
        private double amount_to_be_paid { get; set; }
        private string MODE { get; set; }
        private double amount_paid { get; set; }
        private double Outstanding_Balance { get; set; }
        private double _cost { get; set; }
        private double _sales { get; set; }
        private double _sellingprice { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int TransactionNo
        {
            get
            {
                return this.transaction_number;
            }
            set
            {
                if (value != this.transaction_number)
                {
                    this.transaction_number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double AmountToBePaid
        {
            get
            {
                return this.amount_to_be_paid;
            }
            set
            {
                if (value != this.amount_to_be_paid)
                {
                    this.amount_to_be_paid = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public string ModeOfPayment
        {
            get
            {
                return this.MODE;
            }

            set
            {
                if (value != this.MODE)
                {
                    this.MODE = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double AmountPaid
        {
            get
            {
                return this.amount_paid;
            }

            set
            {
                if (value != this.amount_paid)
                {
                    this.amount_paid = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double OutstandingBalance
        {
            get
            {
                return this.Outstanding_Balance;
            }

            set
            {
                if (value != this.Outstanding_Balance)
                {
                    this.Outstanding_Balance = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double TotalSellingPrice
        {
            get
            {
                return this._sellingprice;
            }

            set
            {
                if (value != this._sellingprice)
                {
                    this._sellingprice = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public double TotalCost
        {
            get
            {
                return this._cost;
            }

            set
            {
                if (value != this._cost)
                {
                    this._cost = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double TotalSales
        {
            get
            {
                return this._sales;
            }

            set
            {
                if (value != this._sales)
                {
                    this._sales = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
