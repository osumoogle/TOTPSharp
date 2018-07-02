using Microsoft.AspNet.Identity.EntityFramework;

namespace TOTPSharp.Model.Model
{
    public class User : IdentityUser
    {
        public string TotpKey { get; set; }
    }
}
