using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool isSuccess { get; }
        public string Message { get; }

        // getter'lar constructor'da set edilebilir.
        public Result(bool success,string message):this(success) // this success'ı alır ve alttaki constructor'ı çağırır.Yani ikisi beraber çalışır.
        {
            Message = message;
        }

        public Result(bool success)
        {
            isSuccess = success;
        }
    }
}
