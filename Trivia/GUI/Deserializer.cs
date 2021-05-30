using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GUI
{
    class Deserializer
    {
        public const int Start_Index = 5;
        public struct StatusStruct
        {
            public string status;
        }
        /// <summary>
        /// Function extract the status for the server response
        /// </summary>
        /// <param string with the server response="res"></param>
        /// <returns></returns>
        public static StatusStruct deserializeStatusMsg(ref string res) {
            res = res.Substring(Start_Index);
            StatusStruct serverRes = JsonConvert.DeserializeObject<StatusStruct>(res);

            return serverRes;
        }
    }
}
