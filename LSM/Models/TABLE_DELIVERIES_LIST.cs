using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class TABLE_DELIVERIES_LIST : BaseTable
    {
        public long ID
        {
            get
            {
                return this.dr_id;
            }

            set
            {
                if(value != this.dr_id)
                {
                    this.dr_id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string DRNo
        {
            get
            {
                return this.dr_no;
            }

            set
            {
                if (value != this.dr_no)
                {
                    this.dr_no = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string DeliveredTo
        {
            get
            {
                return this.delivered_to;
            }

            set
            {
                if (value != this.delivered_to)
                {
                    this.delivered_to = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (value != this.address)
                {
                    this.address = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        public string DeliveryStyle
        {
            get
            {
                return this.delivery_style;
            }

            set
            {
                if (value != this.delivery_style)
                {
                    this.delivery_style = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }

            set
            {
                if (value != this.date)
                {
                    this.date = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string DueDate
        {
            get
            {
                return this.date_to_be_paid;
            }

            set
            {
                if (value != this.date_to_be_paid)
                {
                    this.date_to_be_paid = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Terms
        {
            get
            {
                return this.terms;
            }

            set
            {
                if (value != this.terms)
                {
                    this.terms = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Tin
        {
            get
            {
                return this.tin;
            }

            set
            {
                if (value != this.tin)
                {
                    this.tin = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string UpdatedBy
        {
            get
            {
                return this.updated_by;
            }

            set
            {
                if (value != this.updated_by)
                {
                    this.updated_by = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double AmountReceived
        {
            get
            {
                return this.amount_received;
            }

            set
            {
                if (value != this.amount_received)
                {
                    this.amount_received = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double TotalAmount
        {

            get
            {
                return this.total_amount;
            }

            set
            {
                if (value != this.total_amount)
                {
                    this.total_amount = value;
                    NotifyPropertyChanged();
                }
            }

        }

        private long dr_id { get; set; }
        private string dr_no { get; set; }
        private string delivered_to { get; set; }
        private string address { get; set; }
        private string delivery_style { get; set; }
        private string date { get; set; }
        private string date_to_be_paid { get; set; }
        private string terms { get; set; }
        private string tin { get; set; }
        private string updated_by { get; set; }
        private double amount_received { get; set; }
        private double total_amount { get; set; }

    }
}
