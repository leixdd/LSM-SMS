using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using LSM.Models;
namespace LSM
{
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        
        private void btnAccept_ClickAsync(object sender, EventArgs e)
        {
            login();
           
        }

        protected void login()
        {
            var user_def = new { txtUserID = txtUserID.Text, txtPass = txtPass.Text };

            //reset_errors
            txtUserID_error.Text = "";
            txtPass_error.Text = "";

            pb_loading.Visible = true;

            Utilities.HttpServer.Post(LSM.Utilities.Routes.R_LOGIN, new StringContent(JsonConvert.SerializeObject(user_def), Encoding.UTF8, "application/json"),
            (passed, result) => { 
                
                //Lambda Expression as a delegate, Getting the result from Post method 

                pb_loading.Visible = false; //since we got the result, we could now disable or hide the loader

                if (!passed)
                {
                    return false; // quitting the delegate function incase of connection lost
                }

                var d_res = result;

                if (d_res.data != null)
                {

                    if (bool.Parse(d_res.success))
                    {
                        //Successful login

                        //Setup the Global Settings for user

                        Models.GlobalSettings.CURRENT_USER = new Models.User
                        {
                            user_id = int.Parse(d_res.data.ToString()),
                            Username = txtUserID.Text
                        };
                        frmMain_Screen frm = new frmMain_Screen();
                        Models.GlobalSettings.main_screen = frm;
                        frm.Show();
                        this.Hide();
                    }


                    if (!bool.Parse(d_res.success))
                    {
                        var data_ = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(d_res.data.ToString());
                        foreach (String control in data_.Keys)
                        {
                            Label lst = Utilities.Helpers.FindWithName<Label>(control + "_error", this.panel1);

                            if (lst != null)
                            {
                                lst.Text = String.Join(",", data_[control]);
                            }

                        }


                    }


                }

                return true;
            });



        }

        private void txtUserID_Enter(object sender, EventArgs e)
        {
            if (txtUserID.Text == "Please Enter Username")
            {
                txtUserID.Text = "";
                txtUserID.ForeColor = Color.Gray;

            }
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                txtUserID.Text = "Please Enter Username";
                txtUserID.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Please Enter Password")
            {
                txtPass.UseSystemPasswordChar = true;
                txtPass.Text = "";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "Please Enter Password";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilities.AllowFormDraggable.applyFormDrag(Handle);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserID_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        } 
    }
    

}
