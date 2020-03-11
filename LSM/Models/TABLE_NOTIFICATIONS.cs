using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class TABLE_NOTIFICATIONS : BaseTable
    {

        public DateTime DueDate
        {
            get
            {
                return this._dueDate;
            }

            set
            {
                if(value != this._dueDate)
                {
                    this._dueDate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public String DRNo
        {
            get
            {
                return this._drNo;
            }

            set
            {
                if(value != this._drNo)
                {
                    this._drNo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public String  CustomerName
        {
            get
            {
                return this.customer_name;
            }

            set
            {
                if(value != this.customer_name)
                {
                    this.customer_name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Double TotalAmount
        {
            get
            {
                return this.total_amount;
            }
            set
            {
                if(value != this.total_amount)
                {
                    this.total_amount = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int RemainingDays
        {
            get
            {
                return this.remaining_days;
            }

            set
            {
                if(value != this.remaining_days)
                {
                    this.remaining_days = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        private DateTime _dueDate { get; set; }
        private String _drNo { get; set; }
        private String customer_name { get; set; }
        private Double total_amount { get; set; }
        private int remaining_days { get; set; }

    }
}
