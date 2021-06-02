using Newtonsoft.Json;

namespace GUI
{
    internal class Deserializer
    {
        public const int startIndex = 5;

        /// <summary>
        ///     Function extract the status for the server response
        /// </summary>
        /// <param string with the server response="res"></param>
        /// <returns></returns>
        public static StatusStruct DeserializeStatusMsg(ref string res)
        {
            res = res.Substring(startIndex);
            var serverRes = JsonConvert.DeserializeObject<StatusStruct>(res);

            return serverRes;
        }

        public struct StatusStruct
        {
            public string status;
        }
    }
}