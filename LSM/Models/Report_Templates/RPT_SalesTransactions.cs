using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using LSM.Utilities;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace LSM.Models.Report_Templates
{
    public class RPT_SalesTransactions : IReport
    {
        public string route { get; set; }
        public string RPT_NAME { get; set; }

        private BindingSource bnd_source { get; set; }

        public List<SalesTransactions_Model> list_dr = new List<SalesTransactions_Model>();

        public BindingList<SalesTransactions_Model> transactions;

        public RPT_SalesTransactions()
        {
            transactions = new BindingList<SalesTransactions_Model>(list_dr);
            bnd_source = new BindingSource(transactions, null);
        }

        public string report_name()
        {
            return this.RPT_NAME;
        }

        public void generate_report()
        {

            HttpServer.Get(route, (passed, results) =>
            {

                if (passed)
                {
                    
                    if (bool.Parse(results.success))
                    {

                        var rs_object = JsonConvert.DeserializeObject<List<RS_DEF>>(results.data.ToString());

                        list_dr.Clear();
                        transactions.Clear();

                        foreach (RS_DEF rs_d in rs_object)
                        {
                            list_dr.Add(new SalesTransactions_Model
                            { 
                                AmountPaid = Double.Parse(rs_d.amount_paid),
                                AmountToBePaid = Double.Parse(rs_d.total_amount),
                                ModeOfPayment = rs_d.bank_trans_id.Equals("0") ? "Cash" : "Check",
                                OutstandingBalance = Double.Parse(rs_d.total_amount) - Double.Parse(rs_d.amount_paid),
                                TransactionNo = int.Parse(rs_d.transaction_no),
                                TotalCost = rs_d.COST,
                                TotalSales = (rs_d.SALES - rs_d.COST),
                                TotalSellingPrice = rs_d.SALES
                            });
                        }


                        transactions.ResetBindings();

                        return true;
                    }

                    return false;
                }

                return false;
            });



        }




        public BindingSource dgv
        {
            get
            {
                return this.bnd_source;
            }
        }
    }



    class RS_DEF
    {
        public string transaction_no {get; set;}
        public string  sold_to{get; set;}
        public string date  {get; set;}
        public string total_amount {get; set;}
        public string  amount_paid {get; set;}
        public string bank_trans_id { get; set; }

        public double COST { get; set; }
        public double SALES { get; set; }


        //public IList<Models.Cheque> cheques { get; set; }
        //public IList<>

    }
}
