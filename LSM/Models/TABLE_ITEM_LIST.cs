using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class TABLE_ITEM_LIST : BaseTable
    {
        private long item_id { get; set; }
        private string item_name { get; set; }
        private double item_cost { get; set; }
        private string item_size { get; set; }


        public long ID {
            get { return this.item_id; }
            
            set 
            {
                if (value != this.item_id) {
                    this.item_id = value;
                    NotifyPropertyChanged();
                }
            }

        }

        public string Name {
            get { return this.item_name; }

            set {
                if (value != this.item_name)
                {
                    this.item_name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double Cost {

            get { return this.item_cost; }

            set {
                if (value != this.item_cost)
                {
                    this.item_cost = value;
                    NotifyPropertyChanged();
                }
            } 
        }

        public string Size {

            get { return this.item_size; }

            set {
                if (value != this.item_size) {
                    this.item_size = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
