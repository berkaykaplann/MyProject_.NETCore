using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        // Bu metod, verilen bir securityKey ve algoritma ile SigningCredentials oluşturur.
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey, string algorithm = SecurityAlgorithms.HmacSha256)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
