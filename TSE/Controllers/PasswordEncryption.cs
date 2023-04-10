using System.Text;

namespace TSE.Controllers
{
    public static class PasswordEncryption
    {
        // Sets the Key for the encryption
        public static string Key = "adef@@kntrcv@";

        public static string ConvertToEncrypt(string password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            password += Key;
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(passwordBytes);
        }

        public static string ConvertToDecrypt(string base64EncodeDate)
        {
            if (string.IsNullOrEmpty(base64EncodeDate)) return "";
            var base64EncodeBytes = Convert.FromBase64String(base64EncodeDate);
            var result = Encoding.UTF8.GetString(base64EncodeBytes);
            result = result.Substring(0,result.Length - Key.Length);
            return result;
        }
    }
}
