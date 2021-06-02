using Newtonsoft.Json;
using System.Collections.Generic;

namespace GUI
{
    internal class Deserializer
    {
        public const int startIndex = 5;

        /// <summary>
        ///     Function extract the status from the server response
        /// </summary>
        /// <param string with the server response="res"></param>
        /// <returns></returns>
        public static StatusStruct DeserializeStatusMsg(ref string res)
        {
            res = res.Substring(startIndex);
            StatusStruct serverRes = JsonConvert.DeserializeObject<StatusStruct>(res);

            return serverRes;
        }
        /// <summary>
        ///     Function extract the rooms from the server response
        /// </summary>
        /// <param string with the server response="res"></param>
        /// <returns></returns>
        public static RoomsStruct DeserializeRoomsMsg(ref string res) {
            res = res.Substring(startIndex);
            RoomsStruct serverRes = JsonConvert.DeserializeObject<RoomsStruct>(res);

            return serverRes;
        }
        public struct StatusStruct
        {
            public string status;
        }
        public struct RoomsStruct {
            public string status; 
            public List<string> roomsNames;
        }
    }
}