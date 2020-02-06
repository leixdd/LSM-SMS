using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class DR : INotifyPropertyChanged
    {
        private string dr_Item { get; set; }
        private double dr_UnitPrice { get; set; }
        private double dr_Quantity { get; set; }
        private string dr_Size { get; set; }
        private int dr_item_id { get; set; }
        private string dr_Amount { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Item
        {
            get
            {
                return dr_Item;
            }
            set
            {
                if (value != this.dr_Item)
                {
                    this.dr_Item = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public double Quantity
        {
            get
            {
                return dr_Quantity;
            }
            set
            {
                if(value != this.dr_Quantity)
                {
                    this.dr_Quantity = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Size
        {
            get
            {
                return dr_Size;
            }
            set
            {
                if (value != this.dr_Size)
                {
                    this.dr_Size = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public int ItemID
        {
            get
            {
                return dr_item_id;
            }
            set
            {
                if (value != this.dr_item_id)
                {
                    this.dr_item_id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double UnitPrice
        {
            get
            {
                return dr_UnitPrice;
            }
            set
            {
                if (value != this.dr_UnitPrice)
                {
                    this.dr_UnitPrice = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Amount
        {
            get
            {
                return dr_Amount;
            }
            set
            {
                if (value != this.dr_Amount)
                {
                    this.dr_Amount = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
