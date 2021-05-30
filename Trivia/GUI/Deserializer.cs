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
        public struct StatusStruct
        {
            public bool status;
        }
        /// <summary>
        /// Function extract the status for the server response
        /// </summary>
        /// <param string with the server response="res"></param>
        /// <returns></returns>
        public static StatusStruct deserializeStatusMsg(ref string res) {
             StatusStruct serverRes = JsonConvert.DeserializeObject<StatusStruct>(res);
            return serverRes;
        }
    }
}
