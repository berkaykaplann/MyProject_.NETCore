using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data , string message):base(data, true, message) // data ve message gönderiyoruz. success true olduğu için base'e true gönderiyoruz.
        {

        }
        public SuccessDataResult(T data ):base(data, true) // sadece data gönderiyoruz. success true olduğu için base'e true gönderiyoruz.
        {
        }
        public SuccessDataResult(string message):base(default, true, message) // data default değeri null olduğu için default gönderiyoruz. success true olduğu için base'e true gönderiyoruz.
        {

        }
        public SuccessDataResult():base(default, true) // data default değeri null olduğu için default gönderiyoruz. success true olduğu için base'e true gönderiyoruz.
        {
            
        }
    }
}
