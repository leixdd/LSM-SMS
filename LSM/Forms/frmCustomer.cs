﻿using LSM.Utilities;
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

    public partial class frmCustomer : Form
    {
        private List<rDF> list_object;

        protected Models.DGV_MODEL<Models.TABLE_ITEM_BIND_LIST> TABLE_MODEL = new Models.DGV_MODEL<Models.TABLE_ITEM_BIND_LIST>();

        protected List<Models.TABLE_ITEM_BIND_LIST> temp_list = new List<Models.TABLE_ITEM_BIND_LIST>();
        

        public frmCustomer()
        {
            InitializeComponent();

            this.listAllCustomers();

            dgvDeliveryItems.DataSource = new BindingSource(TABLE_MODEL.get_model, null);
            TABLE_MODEL.get_model.ResetBindings();
        }

        private void listAllCustomers()
        {

            lstCustomers.Items.Clear();

            HttpServer.Get(Utilities.Routes.R_CUSTOMERS, (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<rDF>>(results.data.ToString());
                        list_object = rs_object;
                        foreach (var data in rs_object)
                        {
                            lstCustomers.Items.Add(data.customer_name + " - " + data.company_name);
                        }

                        lstCustomers.SelectedIndex = 0;
                        return true;
                    }

                    return false;
                }

                return false;
            });

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.ShowDialog();
            this.listAllCustomers();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _id = list_object[lstCustomers.SelectedIndex].id;
            frmAddItemSetup frm = new frmAddItemSetup();
            frm.setCID(_id);
            frm.ShowDialog();
            this.getBinds(_id);
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
            var item = list_object[lstCustomers.SelectedIndex];
            txtCompanyAddress.Text = item.company_address;
            txtCompanyName.Text = item.company_name;
            txtContactNumber.Text = item.contact_number;
            txtCustomerName.Text = item.customer_name;
            txtEmailAddress.Text = item.email;

            this.getBinds(item.id);

        }
           
        protected class JSON_DEF_MODEL
        {
            public long id;
            public string item_name;
            public string item_size;
            public double selling_price;
            public double discount;
        }

        private void getBinds(int id)
        {
            TABLE_MODEL.get_list.Clear();

            HttpServer.Get(Utilities.Routes.R_CUSTOMERS_BIND_ITEM_GET + id.ToString(), (passed, results) =>
            {

                if (passed)
                {

                    if (bool.Parse(results.success))
                    {
                        var rs_object = JsonConvert.DeserializeObject<List<JSON_DEF_MODEL>>(results.data.ToString());

                        foreach (JSON_DEF_MODEL item in rs_object)
                        {
                            var model = new Models.TABLE_ITEM_BIND_LIST
                            {
                                BindID = item.id,
                                Discount = item.discount,
                                ItemName = item.item_name,
                                Size = item.item_size,
                                FinalPrice = (item.selling_price - (item.selling_price * (item.discount / 100) )),
                                SellingPrice = item.selling_price
                            };

                            TABLE_MODEL.get_list.Add(model);
                            temp_list.Add(model);

                        }

                        TABLE_MODEL.get_model.ResetBindings();

                        //resetDGV();

                        return true;
                    }

                    return false;
                }

                return false;
            });
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Models.GlobalSettings.pastScreen = this;
            Models.GlobalSettings.main_screen.mdi_module_load(new frmTransactions());
        }
    }

    class rDF
    {
        public int id { get; set; }
        public string customer_name { get; set; }
        public string company_name { get; set; }
        public string contact_number { get; set; }
        public string email { get; set; }
        public string company_address { get; set; }
    }


}
