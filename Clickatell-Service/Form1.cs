using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickatell_Service
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string api;
        private string to;
        private string from;
        private string delivery;
        private string message;
        private string response;

        public Form()
        {
            InitializeComponent();
        }

        private void btn_sendsms_Click(object sender, EventArgs e)
        {
            //assigning text boxes to private variables
            api = txt_api.Text;
            to = txt_to.Text;
            from = txt_from.Text;
            delivery = txt_delivery.Text;
            message = txt_message.Text;
            
            //creating a dictionary to store all the parameters that needs to be sent
            Dictionary<string, string> Params = new Dictionary<string, string>();

            //adding the parameters to the dictionary
            Params.Add("content", message);
            Params.Add("to", to);
            if (from != "") { Params.Add("from", from); }
            if (delivery != "") { Params.Add("scheduledDeliveryTime", delivery); }

            if (api != "")
            {
                response = Api.SendSMS(api, Params);
                MessageBox.Show(response);
            }
            else
            {
                MessageBox.Show("Error: API Key cannot be blank");
            }
        }
    }
}
