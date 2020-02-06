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

        protected class JSON_DEF_MODEL
        {
            public long item_id { get; set; }
            public string item_name { get; set; }
            public double item_cost { get; set; }
            public string item_size { get; set; }
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

        private void frmSearchItem_Load(object sender, EventArgs e)
        {
            this.generate_data();
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
                Models.GlobalSettings.Selection_Item_ID = int.Parse(dgvDeliveryItems.SelectedRows[0].Cells["ID"].Value.ToString());
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
    }
}
