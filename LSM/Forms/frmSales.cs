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
    public partial class frmSales : Form
    {
        public static long TRANSACTION_NUMBER = 0;
        protected static List<Models.DR> list_dr = new List<Models.DR>();
        protected static BindingList<Models.DR> dr_items = new BindingList<Models.DR>(list_dr);

        public frmSales()
        {
            InitializeComponent();
            dgvDeliveryItems.DataSource = new BindingSource(dr_items, null);
            resetDGV();
            generate_combo_units();
        }

        private void openSetTN()
        {
            Forms.frmSetDR set_tn = new frmSetDR();
            set_tn.setLabelTitle("Transaction Number", 1);
            set_tn.ShowDialog();
            this.btnTransactionNumber.Text = TRANSACTION_NUMBER.ToString();
        }


        protected void generate_combo_units()
        {
            //comboUnit.Items.Clear();
            //foreach (var unit in Models.GlobalSettings.UNIT_LIST)
            //{
            //    comboUnit.Items.Add(unit.unit_name);
            //}

            //if (comboUnit.Items.Count > 0)
            //{
            //    comboUnit.SelectedIndex = 0;
            //}
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


        private void btnTransactionNumber_Click(object sender, EventArgs e)
        {
            openSetTN();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
        }

        private void frmSales_Shown(object sender, EventArgs e)
        {
            openSetTN();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            var dr_setup = new Models.TransactionRPT
            {
                
                address = (txtAddress.Text.Equals("") ? "No Input" : txtAddress.Text),
                datetime = dtpDate.Value.ToString("yyyy-MM-dd"),
                b_style = txtBusStyle.Text.Equals("") ? "No Input" : txtBusStyle.Text,
                sold_to = txtSoldTo.Text,
                item_list = list_dr,
                trans_no = btnTransactionNumber.Text,
                terms = (txtTerms.Text.Equals("") ? "No Input" : txtTerms.Text),
                po = (txtPO.Text.Equals("") ? "No Input" : txtPO.Text),
                updated_by = Models.GlobalSettings.CURRENT_USER.user_id.ToString() //getting the current user
            };

            if (list_dr.Count > 0)
            {

                MOP rp = new MOP();
                rp.setItems(dr_setup);
                rp.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Item List must have atleast 1 item to transact.", "Opps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected void generate_total_amount(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                    try
                    {
                        dgvDeliveryItems.Rows[e.RowIndex].Cells["Amount"].Value = (Double.Parse(dgvDeliveryItems.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString()) * Double.Parse(dgvDeliveryItems.Rows[e.RowIndex].Cells["Quantity"].Value.ToString())).ToString("C", CultureInfo.CurrentCulture);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }              
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Boolean passed = true;

            if (txtItem.Text.Equals(""))
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
                    ItemID = Models.GlobalSettings.Selection_Item_ID,
                    UnitPrice = (Double)numUnitPrice.Value,
                    Amount = ((Double)numUnitPrice.Value * (Double)numQuantity.Value).ToString("C", CultureInfo.CurrentCulture)
                });


                dr_items.ResetBindings();
                //resetDGV();
            }
        }

        protected void resetDGV()
        {
            this.dgvDeliveryItems.Columns["ItemID"].Visible = false;
            this.dgvDeliveryItems.Columns["Amount"].ReadOnly = true;
            this.dgvDeliveryItems.Columns["UnitPrice"].HeaderText = "Unit Price";
            this.dgvDeliveryItems.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
        }


        private void txtItem_Click(object sender, EventArgs e)
        {
            frmSearchItem si = new frmSearchItem(new Models.Selection_Model
            {
                control = new List<Control> { txtItem, numIC, txtItemSize, numUnitPrice },
                ID = 0
            });
            si.ShowDialog();
        }

        private void dgvDeliveryItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
