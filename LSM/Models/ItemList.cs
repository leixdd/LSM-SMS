using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class ItemList : Table
    {
        private long item_id { get; set; }

        private string item_name { get; set; }

        private double item_cost { get; set; }

        private int item_unit { get; set; }

        public long ID
        {
            get
            {
                return this.item_id;
            }

            set
            {
                if (value != this.item_id)
                {
                    this.item_id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Name
        {
            get
            {
                return this.item_name;
            }

            set
            {
                if (value != this.item_name)
                {
                    this.item_name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double Cost
        {
            get
            {
                return this.item_cost;
            }

            set
            {
                if (value != this.item_cost)
                {
                    this.item_cost = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Unit
        {
            get
            {
                return this.item_unit;
            }
            set {
                if (value != this.item_unit)
                {
                    this.item_unit = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
