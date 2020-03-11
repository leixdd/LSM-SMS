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
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace LSM.Forms
{
    public partial class frmSearchItem : Form
    {
        protected Models.DGV_MODEL<Models.TABLE_ITEM_LIST> TABLE_MODEL = new Models.DGV_MODEL<Models.TABLE_ITEM_LIST>();

        protected List<Models.TABLE_ITEM_LIST> temp_list = new List<Models.TABLE_ITEM_LIST>();

        private Models.Selection_Model selection_model { get; set; }

        private Boolean useBind = false;
        private long customer = 0;

        protected class JSON_DEF_MODEL
        {
            public long item_id { get; set; }
            public string item_name { get; set; }
            public double item_cost { get; set; }
            public string item_size { get; set; }
        }

        protected class CUSTOMER_BINDED_ITEMS
        {
            public long item_id;
            public string item_name;
            public string item_size;
            public double selling_price;
            public double discount;
        }

        public frmSearchItem()
        {
            InitializeComponent();
            dgvDeliveryItems.MultiSelect = false;
            init();
        }

        public frmSearchItem(Models.Selection_Model controller_set_text)
        {
            InitializeComponent();
            selection_model = controller_set_text;
            init();
        }

        public frmSearchItem(Models.Selection_Model controller_set_text, long customer_id = 0)
        {
            InitializeComponent();
            selection_model = controller_set_text;
            if (customer_id > 0)
            {
                this.useBind = true;
                this.customer = customer_id;
            }

            init();
        }


        private void init()
        {

            dgvDeliveryItems.DataSource = new BindingSource(TABLE_MODEL.get_model, null);
            TABLE_MODEL.get_model.ResetBindings();
        }

        protected void resetDGV()
        {
            this.dgvDeliveryItems.Columns["ID"].Visible = false;
            this.dgvDeliveryItems.Columns["Name"].ReadOnly = true;
            this.dgvDeliveryItems.Columns["Cost"].ReadOnly = true;
            this.dgvDeliveryItems.Columns["Size"].ReadOnly = true;
            this.dgvDeliveryItems.Columns["Cost"].DefaultCellStyle.Format = "N2";
        }

        protected void generate_data()
        {
            TABLE_MODEL.get_list.Clear();

            HttpServer.Get(Utilities.Routes.R_ITEMS_LIST, (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<JSON_DEF_MODEL>>(results.data.ToString());

                        foreach (JSON_DEF_MODEL item in rs_object)
                        {
                            var model = new Models.TABLE_ITEM_LIST
                            {
                                Cost = item.item_cost,
                                ID = item.item_id,
                                Name = item.item_name,
                                Size = item.item_size.ToString()
                            };

                            TABLE_MODEL.get_list.Add(model);
                            temp_list.Add(model);

                        }

                        TABLE_MODEL.get_model.ResetBindings();

                        resetDGV();

                        return true;
                    }

                    return false;
                }

                return false;
            });

           

        }

        private void getBinds(long id)
        {
            TABLE_MODEL.get_list.Clear();

            HttpServer.Get(Utilities.Routes.R_CUSTOMERS_BIND_ITEM_GET + id.ToString(), (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<CUSTOMER_BINDED_ITEMS>>(results.data.ToString());

                        foreach (CUSTOMER_BINDED_ITEMS item in rs_object)
                        {
                            var model = new Models.TABLE_ITEM_LIST
                            {
                                ID = item.item_id,
                                Name = item.item_name,
                                Size = item.item_size,
                                Cost = (item.selling_price - (item.selling_price * (item.discount / 100))),
                            };

                            TABLE_MODEL.get_list.Add(model);
                            temp_list.Add(model);

                        }

                        TABLE_MODEL.get_model.ResetBindings();

                        resetDGV();

                        return true;
                    }

                    return false;
                }

                return false;
            });
        }
  

        private void frmSearchItem_Load(object sender, EventArgs e)
        {
            if (!this.useBind)
            {
                this.generate_data();
            }
            else
            {
                this.getBinds(customer);
            }
        }

        private void frmSearchItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }

        private void bunifuCards1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {;
            var list = temp_list.FindAll(data => (data.Name + " " + data.Size).ToLower().Contains(txtSearch.Text.ToLower()));

            TABLE_MODEL.get_list.Clear();

            foreach (var item in list)
            {
                TABLE_MODEL.get_list.Add(item);
            }

            TABLE_MODEL.get_model.ResetBindings();
            resetDGV();

            if (e.KeyCode == Keys.Enter)
            {
                this.dgvDeliveryItems.Focus();
            }
        }

        private void dgvDeliveryItems_DoubleClick(object sender, EventArgs e)
        {
            selection();
            this.Close();
        }

        private void selection()
        {
            if (dgvDeliveryItems.SelectedRows.Count == 1)
            {
                selection_model.control[0].Text = dgvDeliveryItems.SelectedRows[0].Cells["Name"].Value.ToString();
                ((System.Windows.Forms.NumericUpDown)selection_model.control[1]).Value = Decimal.Parse(dgvDeliveryItems.SelectedRows[0].Cells["Cost"].Value.ToString());
                ((System.Windows.Forms.NumericUpDown)selection_model.control[3]).Value = Decimal.Parse(dgvDeliveryItems.SelectedRows[0].Cells["Cost"].Value.ToString());
                selection_model.control[2].Text = dgvDeliveryItems.SelectedRows[0].Cells["Size"].Value.ToString();
                Models.GlobalSettings.Selection_II_ID = int.Parse(dgvDeliveryItems.SelectedRows[0].Cells["ID"].Value.ToString());
                Console.WriteLine(Models.GlobalSettings.Selection_II_ID);
            }

        }
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            selection();
            this.Close();
        }

        private void dgvDeliveryItems_Click(object sender, EventArgs e)
        {
            selection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDeliveryItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selection();
                e.Handled = true;
                this.Close();
            }
        }
    }
}
