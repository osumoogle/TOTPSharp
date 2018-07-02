using Microsoft.AspNet.Identity.EntityFramework;
using TOTPSharp.Model.Model;

namespace TOTPSharp.Model
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext() :base("Totp")
        {
            
        }
    }
}
