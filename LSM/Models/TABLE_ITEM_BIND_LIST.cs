using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class TABLE_ITEM_BIND_LIST : BaseTable
    {
        private long bind_id { get; set; }
        private string item_name { get; set; }
        private double selling_price { get; set; }
        private string item_size { get; set; }
        private double item_discount { get; set; }
        private double final_price { get; set; }

        public long BindID
        {
            get { return this.bind_id; } 

            set
            {
                if(value != this.bind_id)
                {
                    this.bind_id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ItemName
        {
            get { return this.item_name; }

            set
            {
                if (value != this.item_name)
                {
                    this.item_name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Double SellingPrice
        {
            get { return this.selling_price; }

            set
            {
                if (value != this.selling_price)
                {
                    this.selling_price = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public String Size
        {
            get { return this.item_size; }

            set
            {
                if (value != this.item_size)
                {
                    this.item_size = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Double Discount
        {
            get { return this.item_discount; }

            set
            {
                if (value != this.item_discount)
                {
                    this.item_discount = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Double FinalPrice
        {
            get { return this.final_price; }

            set
            {
                if (value != this.final_price)
                {
                    this.final_price = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
