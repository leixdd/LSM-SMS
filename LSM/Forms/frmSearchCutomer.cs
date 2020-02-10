using LSM.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Forms
{
    public partial class frmSearchCutomer : Form
    {

        protected Models.DGV_MODEL<Models.TABLE_CUSTOMER_LIST> TABLE_MODEL = new Models.DGV_MODEL<Models.TABLE_CUSTOMER_LIST>();

        protected List<Models.TABLE_CUSTOMER_LIST> temp_list = new List<Models.TABLE_CUSTOMER_LIST>();

        private Models.Selection_Model selection_model { get; set; }

        public frmSearchCutomer()
        {
            InitializeComponent();
            this.init();
        }

        public frmSearchCutomer(Models.Selection_Model controller_set_text)
        {
            InitializeComponent();
            selection_model = controller_set_text;
            init();
        }


        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.selection();
            this.Close();
        }

        private void selection()
        {
            if (dgvDeliveryItems.SelectedRows.Count == 1)
            {
                selection_model.control[0].Text = dgvDeliveryItems.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                selection_model.control[1].Text = dgvDeliveryItems.SelectedRows[0].Cells["CompanyAddress"].Value.ToString();
                Models.GlobalSettings.Selection_Item_ID = int.Parse(dgvDeliveryItems.SelectedRows[0].Cells["ID"].Value.ToString());
            }

        }


        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var list = temp_list.FindAll(data => (data.CustomerName + " " + data.CompanyName).ToLower().Contains(txtSearch.Text.ToLower()));

            TABLE_MODEL.get_list.Clear();

            foreach (var item in list)
            {
                TABLE_MODEL.get_list.Add(item);
            }

            TABLE_MODEL.get_model.ResetBindings();
            resetDGV();
        }

        private void init()
        {

            dgvDeliveryItems.DataSource = new BindingSource(TABLE_MODEL.get_model, null);
            TABLE_MODEL.get_model.ResetBindings();
        }

        private class JSON_DEF_MODEL
        {
            public int id { get; set; }
            public string customer_name { get; set; }
            public string company_name { get; set; }
            public string contact_number { get; set; }
            public string email { get; set; }
            public string company_address { get; set; }
        }

        protected void generate_data()
        {
            TABLE_MODEL.get_list.Clear();

            HttpServer.Get(Utilities.Routes.R_CUSTOMERS, (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<JSON_DEF_MODEL>>(results.data.ToString());

                        foreach (JSON_DEF_MODEL item in rs_object)
                        {
                            var model = new Models.TABLE_CUSTOMER_LIST
                            {
                                ID = item.id,
                                CompanyAddress = item.company_address,
                                CompanyName = item.company_name,
                                ContactNumber = item.contact_number,
                                CustomerName = item.customer_name
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

        private void resetDGV()
        {
            this.dgvDeliveryItems.Columns["ID"].Visible = false;
            this.dgvDeliveryItems.Columns["CompanyAddress"].Visible = false;
            this.dgvDeliveryItems.Columns["Email"].Visible = false;
            this.dgvDeliveryItems.Columns["CustomerName"].ReadOnly = true;
            this.dgvDeliveryItems.Columns["ContactNumber"].ReadOnly = true;
            this.dgvDeliveryItems.Columns["CompanyName"].ReadOnly = true;
        }

        private void frmSearchCutomer_Load(object sender, EventArgs e)
        {
            generate_data();
        }

        private void bunifuCards1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }

        private void dgvDeliveryItems_Click(object sender, EventArgs e)
        {
            this.selection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
