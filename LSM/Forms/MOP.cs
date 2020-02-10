using LSM.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Forms
{
    public partial class MOP : Form
    {
        private Models.TransactionRPT transaction_items;
        private double total_amount = 0;
        private double final_amount = 0;
        private double cash_amount = 0;
        private double cheque_amount = 0;
       
        protected Models.DGV_MODEL<Models.ChequeDGV> TABLE_MODEL = new Models.DGV_MODEL<Models.ChequeDGV>();

        private Boolean useDR = false;
        private Models.DR_RPT DR_Transactions;

        public MOP()
        {
            InitializeComponent();

            dgvChequeList.DataSource = new BindingSource(TABLE_MODEL.get_model, null);
            TABLE_MODEL.get_model.ResetBindings();

        }

        public void setItems(Models.TransactionRPT trans) {
            transaction_items = trans;
            total_amount = total_amount_generate(trans.item_list);
            txtTotalAmount.Text = total_amount.ToString("C", CultureInfo.CurrentCulture);
        }

        public void setDRTrans(Models.DR_RPT trans)
        {
            this.useDR = true;
            this.DR_Transactions = trans;
            total_amount = total_amount_generate(trans.dr_list);
            txtTotalAmount.Text = total_amount.ToString("C", CultureInfo.CurrentCulture);

            cashGroup.Visible = false;
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected double total_amount_generate(IList<Models.DR> list)
        {
            double f_amt = 0;

            foreach (var item in list)
            {
                f_amt += item.UnitPrice * item.Quantity;    
            }

            return f_amt;
        } 

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           frmError _error = new frmError();
           Boolean primary_validation = true;

           if (final_amount == 0)
           {
               primary_validation = false;
               _error.errorList1.addError("Total Recieved Amount was empty.");
           }

           try
           {
               if (primary_validation)
               {

                   computeTR();

                   if (this.useDR)
                   {
                       this.DR_Transactions.cheque = TABLE_MODEL.get_list;
                       this.DR_Transactions.check_empty = (TABLE_MODEL.get_list.Count == 0);
                       this.DR_Transactions.amount_received = final_amount;
                       this.DR_Transactions.total_amount = total_amount;

                       HttpServer.Post(Routes.R_DR_SAVE, new StringContent(JsonConvert.SerializeObject(this.DR_Transactions), Encoding.UTF8, "application/json"), (passed, results) =>
                       {
                           if (passed)
                           {

                               if (!bool.Parse(results.success))
                               {
                                   var data_ = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(results.data.ToString());
                                   foreach (String control in data_.Keys)
                                   {
                                       _error.errorList1.addError(String.Join(",", data_[control]));
                                   }

                                   _error.Show();


                                   return false;
                               }

                               frmSuccess success = new frmSuccess();
                               success.setDesc(results.data.ToString());
                               success.ShowDialog();


                           }
                           return false;
                       });


                   }
                   else { 
                       var rp_prep = new Models.RP
                       {
                           amount_received = final_amount,
                           cheque = TABLE_MODEL.get_list,
                           total_amount = total_amount,
                           transact_items = transaction_items,
                           check_empty = (TABLE_MODEL.get_list.Count == 0)
                       };


                       HttpServer.Post(Routes.R_SALES_SAVE, new StringContent(JsonConvert.SerializeObject(rp_prep), Encoding.UTF8, "application/json"), (passed, results) =>
                       {
                           if (passed)
                           {

                               if (!bool.Parse(results.success))
                               {
                                   var data_ = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(results.data.ToString());
                                   foreach (String control in data_.Keys)
                                   {
                                       _error.errorList1.addError(String.Join(",", data_[control]));
                                   }
                                   _error.Show();
                                   return false;
                               }

                               frmSuccess success = new frmSuccess();
                               success.setDesc(results.data.ToString());
                               success.ShowDialog();


                           }
                           return false;
                       });
                   }

               }

           }
           catch (Exception ex)
           {
               primary_validation = false;
               _error.errorList1.addError(ex.Message);
           }


           if (!primary_validation)
           {
               _error.Show();
           }



           this.Close();
        }

        private bool  MODE_CH() {

            if (txtAmountReceived.Text.Equals(""))
            {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var bq = bankMOP1;

                TABLE_MODEL.get_list.Add(new Models.ChequeDGV
                {
                    BankAccountNumber = int.Parse(bq.AccNumber),
                    BankBranch = bq.BankBranch,
                    BankName = bq.BankName,
                    ChequeAmount = Double.Parse(bq.ChequeAmount),
                    ChequeDate = bq.ChequeDate,
                    ChequeNumber = int.Parse(bq.ChequeNumber),
                    IsPostDatedCheque = bq.postdated_check
                });

                TABLE_MODEL.get_model.ResetBindings();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuCards1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }

        private void computeTR()
        {
            final_amount = cheque_amount + cash_amount;
            txtTotalReceived.Text = final_amount.ToString("C", CultureInfo.CurrentCulture);
        }

        private void computeCheque()
        {
            cheque_amount = 0;
            foreach (var lst in TABLE_MODEL.get_list)
            {
                cheque_amount += lst.ChequeAmount;
            }
            computeTR();
        }

        private void txtAmountReceived_ValueChanged(object sender, EventArgs e)
        {
            cash_amount = Double.Parse(txtAmountReceived.Value.ToString());
            computeTR();
        }

        private void dgvChequeList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            computeCheque();
        }

        private void dgvChequeList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            computeCheque();
        }

        private void dgvChequeList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            computeCheque();
        }
    }
}
