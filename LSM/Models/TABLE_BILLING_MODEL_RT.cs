using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class TABLE_BILLING_MODEL_RT : BaseTable
    {

        public long ID
        {
            get
            {
                return this._id;
            }

            set
            {
                if (value != this._id)
                {
                    this._id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public long DRBind
        {
            get
            {
                return this._dr_trans_no;
            }

            set
            {
                if (value != this._dr_trans_no)
                {
                    this._dr_trans_no = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public long ItemID
        {
            get
            {
                return this._item_id;
            }

            set
            {
                if (value != this._item_id)
                {
                    this._item_id = value;
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

        public string Size
        {
            get
            {
                return this.item_size;
            }

            set
            {
                if (value != this.item_size)
                {
                    this.item_size = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Quantity
        {
            get
            {
                return this._quantity;
            }

            set
            {
                if (value != this._quantity)
                {
                    this._quantity = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double Amount
        {
            get
            {
                return this._amount;
            }

            set
            {
                if (value != this._amount)
                {
                    this._amount = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int isReturned {
            get
            {
                return this._isReturned;
            }

            set
            {
                if (value != this._isReturned)
                {
                    this._isReturned = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private long _id { get; set; }
        private long _dr_trans_no { get; set; }
        private long _item_id { get; set; }
        private string item_name { get; set; }
        private string item_size { get; set; }
        private int _quantity { get; set; }
        private double _amount { get; set; }
        private int _isReturned { get; set; }
    }
}
