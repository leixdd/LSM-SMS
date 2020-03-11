using LSM.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSM.Utilities
{

    public class HttpServer
    {

        public static async void Get(string route, Func<bool, Response, bool> function, Boolean needLoader = true)
        {
            HttpClient httpClient = new HttpClient();
            frmWebRes res = new frmWebRes();
            var result = "";
            var to_be_res = new Response
            {
                data = "",
                success = "false"
            };

            if (needLoader)
            {
                res.TopMost = true;
                res.Show();
            }


            var data_retrieved = await httpClient.GetAsync(route);
            result = data_retrieved.Content.ReadAsStringAsync().Result;

            Boolean rules_passed = false;

            try
            {
                try
                {
                    to_be_res = JsonConvert.DeserializeObject<Utilities.Response>(result);
                    rules_passed = true;
                }
                catch (Exception ServerException)
                {
                    Console.WriteLine(ServerException);
                    Console.WriteLine(result);
                    MessageBox.Show("Server Error");
                    rules_passed = false;
                }

            }
            catch (HttpRequestException ex)
            {
                //TODO: Create a logger
                MessageBox.Show("Can't Connect to server");
                rules_passed = false;
            }


            res.Close();

            function(rules_passed, to_be_res);

        }

        public static async void Post(string route, HttpContent content, Func<bool, Response, bool> function)
        {
            HttpClient httpClient = new HttpClient();
            var result = "";
            var to_be_res = new Response
            {
                data = "",
                success = "false"
            };

            frmWebRes res = new frmWebRes();
            res.TopMost = true;
            res.Show();


            Boolean rules_passed = false;

            try
            {
                var data_retrieved = await httpClient.PostAsync(route, content);
                result = data_retrieved.Content.ReadAsStringAsync().Result;
                rules_passed = true;

                try
                {
                    to_be_res = JsonConvert.DeserializeObject<Utilities.Response>(result);
                }
                catch (Exception ServerException)
                {
                    MessageBox.Show("Server Error");
                    rules_passed = false;
                }

            }
            catch(HttpRequestException ex)
            {
                //TODO: Create a logger
                MessageBox.Show("Can't Connect to server");
                rules_passed = false;
            }

            res.Close();

            function(rules_passed, to_be_res);

        }

    }
}
