using Base32;
using OtpSharp;
using TOTPSharp.Model.Model;

namespace TOTPSharp.Lib
{
    public class TotpHelper
    {
        public string GenerateCodeUrl(User user)
        {

            var key = KeyGeneration.GenerateRandomKey(OtpHashMode.Sha512);

            var barcodeUrl = $"{KeyUrl.GetTotpUrl(key, user.UserName, 30, OtpHashMode.Sha512)}&issuer=TOTPSharp";

            user.TotpKey = Base32Encoder.Encode(key).Replace("=", string.Empty);

            return barcodeUrl;
        }
    }
}
