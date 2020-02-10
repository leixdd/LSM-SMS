using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    public class TABLE_CUSTOMER_LIST : BaseTable
    {
        private long customer_id { get; set; }
        private string customer_name { get; set; }
        private string company_name { get; set; }
        private string contact_number { get; set; }
        private string email { get; set; }
        private string company_address { get; set; }

        public long ID
        {
            get { return this.customer_id;  }
            set
            {
                if (value != this.customer_id)
                {
                    this.customer_id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string CustomerName
        {
            get { return this.customer_name; }
            set
            {
                if (value != this.customer_name)
                {
                    this.customer_name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string CompanyName
        {
            get { return this.company_name; }
            set
            {
                if (value != this.company_name)
                {
                    this.company_name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ContactNumber
        {
            get { return this.contact_number; }
            set
            {
                if (value != this.contact_number)
                {
                    this.contact_number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != this.email)
                {
                    this.email = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string CompanyAddress
        {
            get { return this.company_address; }
            set
            {
                if (value != this.company_address)
                {
                    this.company_address = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
