using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSM.Utilities;
using System.Net.Http;
using Newtonsoft.Json;
using System.Globalization;

namespace LSM.Forms
{
    public partial class frmDR : Form
    {
        public static long DRNO_Value = 0;
        protected static List<Models.DR> list_dr = new List<Models.DR>();
        protected static BindingList<Models.DR> dr_items = new BindingList<Models.DR>(list_dr);

        public long dto_id = 0;
        public long item_id = 0;

        public Boolean isEditing = false;

        public frmDR()
        {
            InitializeComponent();
            dgvDeliveryItems.DataSource = new BindingSource(dr_items, null);
            resetDGV();
        }

        public frmDR(long dr_no)
        {
            isEditing = true;
            DRNO_Value = dr_no;
        }

        protected int unit_index(string unit)
        {
            foreach (var unit_ in Models.GlobalSettings.UNIT_LIST)
            {
                if (unit_.unit_name == unit)
                {
                    return unit_.id;
                }
            }

            return 0;
        }


        private void dgvDeliveryItems_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            generate_total_amount(e.RowIndex);
        }

        protected void generate_total_amount(int Index)
        {
            try
            {
                dgvDeliveryItems.Rows[Index].Cells["Amount"].Value = (Double.Parse(dgvDeliveryItems.Rows[Index].Cells["UnitPrice"].Value.ToString()) * Double.Parse(dgvDeliveryItems.Rows[Index].Cells["Quantity"].Value.ToString())).ToString("C", CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvDeliveryItems_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1 || e.ColumnIndex == 2 )
            {
                generate_total_amount(e.RowIndex);
            }
        }

        private void dgvDeliveryItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                generate_total_amount(e.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                new Forms.frmSetDR().ShowDialog();
                this.btnDRNumber.Text = DRNO_Value.ToString();
            }
            
        }

        private void frmDR_Load(object sender, EventArgs e)
        {

        }

        private void frmDR_Shown(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                if (DRNO_Value == 0)
                {
                    new Forms.frmSetDR().ShowDialog();
                }


                this.btnDRNumber.Text = DRNO_Value.ToString();
            }
            
        }

        private void dgvDeliveryItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Boolean passed = true;

            if (txtItem.Text.Equals("") || this.item_id == 0)
            {
                passed = false;
                MessageBox.Show(this, "Item was empty", "Error in adding new item into Sales Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (passed)
            {
                list_dr.Add(new Models.DR
                {
                    Item = txtItem.Text,
                    Quantity = (Double)numQuantity.Value,
                    Size = txtItemSize.Text,
                    ItemID = (int) this.item_id,
                    UnitPrice = (Double)numUnitPrice.Value,
                    Amount = ((Double)numUnitPrice.Value * (Double)numQuantity.Value).ToString("C", CultureInfo.CurrentCulture)
                });
                
                dr_items.ResetBindings();
                resetDGV();
                lblTA.Text = updateTotal().ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private Double updateTotal() {
            Double total_amount_ = 0;

            foreach (Models.DR dritem in list_dr)
            {
                total_amount_ += (dritem.Quantity * dritem.UnitPrice);
            }

            return total_amount_;
        }

        protected void resetDGV()
        {
            this.dgvDeliveryItems.Columns["ItemID"].Visible = false;
            this.dgvDeliveryItems.Columns["Amount"].ReadOnly = true;
            this.dgvDeliveryItems.Columns["UnitPrice"].HeaderText = "Unit Price";
            this.dgvDeliveryItems.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
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

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to save this transaction?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {

                var dr_setup = new Models.DR_RPT
                {
                    address = (txtAddress.Text.Equals("") ? "No Input" : txtAddress.Text),
                    datetime = dtpDate.Value.ToString("yyyy-MM-dd"),
                    d_style = txtDeliveryStyle.Text.Equals("") ? "No Input" : txtDeliveryStyle.Text,
                    deliverd_to = dto_id.ToString(),
                    datetime_to_be_paid = dtpToBePaid.Value.ToString("yyyy-MM-dd"),
                    dr_list = list_dr,
                    dr_no = btnDRNumber.Text,
                    terms = txtTerms.Value.ToString(),
                    tin = (txtTin.Text.Equals("") ? "No Input" : txtTin.Text),
                    updated_by = Models.GlobalSettings.CURRENT_USER.user_id.ToString(), //getting the current user
                    total_amount = total_amount_generate(list_dr),
                    check_empty = true
                };



                if (list_dr.Count > 0)
                {
                    DialogResult result = MessageBox.Show(this, "Do you want to setup the bank checks?", "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        MOP rp = new MOP();
                        rp.setDRTrans(dr_setup);
                        rp.ShowDialog();

                    }
                    else
                    {

                        HttpServer.Post(Routes.R_DR_SAVE, new StringContent(JsonConvert.SerializeObject(dr_setup), Encoding.UTF8, "application/json"), (passed, results) =>
                        {
                            if (passed)
                            {

                                if (!bool.Parse(results.success))
                                {
                                    frmError _error = new frmError();
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

                                DialogResult res = MessageBox.Show(this, "Do you want to print the delivery?", "Print DR?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                                if (res == DialogResult.Yes)
                                {
                                    Models.Exportables.frmReportDR rpt = new Models.Exportables.frmReportDR();

                                    rpt.setDS(list_dr,
                                              txtDeliveredTo.Text,
                                              dr_setup.address,
                                              dr_setup.total_amount,
                                              dr_setup.dr_no,
                                              DateTime.Parse(dr_setup.datetime).ToLongDateString(),
                                              DateTime.Parse(dr_setup.datetime_to_be_paid).ToLongDateString());

                                    rpt.ShowDialog();
                                }


                            }
                            return false;
                        });

                    }
                }
                else
                {
                    MessageBox.Show(this, "Item List must have atleast 1 item to transact.", "Opps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void txtDeliveredTo_MouseClick(object sender, MouseEventArgs e)
        {
            frmSearchCutomer SearchCust = new frmSearchCutomer(new Models.Selection_Model
            {
                control = new List<Control> { txtDeliveredTo, txtAddress },
                ID = 0
            });
            SearchCust.ShowDialog();
            this.dto_id = Models.GlobalSettings.Selection_Item_ID;
            Models.GlobalSettings.Selection_Item_ID = 0;
            resetSelection();
        }

        private void resetSelection() {
            dr_items.Clear();
            txtItem.Clear();
            numQuantity.Value = 1;
            txtItemSize.Clear();
            this.item_id = 0;
            numUnitPrice.Value = 0;
            numIC.Value = 0;
        }

        private void txtItem_MouseClick(object sender, MouseEventArgs e)
        {
            frmSearchItem si = new frmSearchItem(new Models.Selection_Model
            {
                control = new List<Control> { txtItem, numIC, txtItemSize, numUnitPrice },
                ID = 0
            },
            
            dto_id);
            si.ShowDialog();

            this.item_id = Models.GlobalSettings.Selection_II_ID;
            Models.GlobalSettings.Selection_II_ID = 0;

        }

        private void txtTerms_ValueChanged(object sender, EventArgs e)
        {
            DateTime DR_DATE = dtpDate.Value;
            dtpToBePaid.Value = DR_DATE.AddDays((Double)txtTerms.Value);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime DR_DATE = dtpDate.Value;
            dtpToBePaid.Value = DR_DATE.AddDays((Double)txtTerms.Value);
        }

        private void lblTA_Click(object sender, EventArgs e)
        {

        }
    }
}
