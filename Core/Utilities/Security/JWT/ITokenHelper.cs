using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        // Kullanıcı, sistemde kullanıcı adı ve şifresini girdikten sonra bu bilgiler api ye gider ve burada bizim bu operasyonumuz çalışacak eğer doğru ise.
        // İlgili kullanıcı(User user) için veritabanına gidecek ve ordan kullanıcının claimlerini bulacak ve json web token(jwt) üretecek ve onları giriş kısmına verecek.
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
