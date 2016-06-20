using System.Net;
using System.Collections.Specialized;

namespace V_1._2
{
    class sndMsg
    {
        public static void send(string _address, string _message, string _user, string _salt)
        {
            using (var client = new WebClient())
            {
                string final_message = RijndaelManagedEncryption.EncryptRijndael("[" + _user + "]> " + _message, _salt);
                var PHPPostValues = new NameValueCollection();
                PHPPostValues["msg"] = final_message;
                var response = client.UploadValues(_address, PHPPostValues);
            }
        }

        public static void sendhi(string _address, string _message)
        {
            using (var cliento = new WebClient())
            {
                var PHPPostValues = new NameValueCollection();
                PHPPostValues["msg"] = _message;
                var response = cliento.UploadValues(_address, PHPPostValues);
            }
        }
    }
}