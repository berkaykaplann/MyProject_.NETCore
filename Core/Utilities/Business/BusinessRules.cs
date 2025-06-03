using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        // Bu sınıf, iş kurallarını kontrol etmek için kullanılır. Params ifadesi sayesinde birden fazla IResult tipinde parametre gönderebiliriz peki nereden ProductManager'da bu fonksiyonu kullanarak. Bu sayede, iş kurallarını tek bir yerde toplayabilir ve kontrol edebiliriz.
        // Burada fonksiyona gelen IResult tipindeki parametreler, bizim ProductManager'da yazdığımız iş kurallarıdır. (CheckIfProductCountOfCategoryCorrect gibi)
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (logic.isSuccess == false)
                {
                    return logic; // Eğer herhangi bir kural başarısızsa, o kuralın sonucunu döndür. Yani o kuralı çalıştırırız aslında.
                }
            }
            return null; // Tüm kurallar başarılıysa null döndür
        }
    }
}
