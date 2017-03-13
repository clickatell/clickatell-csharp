using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Clickatell_Service
{
    class Api
    {
        //This function is in charge of converting the data into a json array and sending it to the rest sending controller.
        public static string SendSMS(string Token, Dictionary<string, string> Params)
        {
            Params["to"] = CreateRecipientList(Params["to"]);
            string JsonArray = JsonConvert.SerializeObject(Params, Formatting.None);
            JsonArray = JsonArray.Replace("\\\"", "\"").Replace("\"[", "[").Replace("]\"", "]");
            return Rest.Post(Token, JsonArray);
        }

        //This function converts the recipients list into an array string so it can be parsed correctly by the json array.
        public static string CreateRecipientList(string to)
        {
            string[] tmp = to.Split(',');
            to = "[\"";
            to = to + string.Join("\",\"", tmp);
            to = to + "\"]";
            return to;
        }
        
    }
}
