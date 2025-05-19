using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message) // zaten sonuç success(true) olduğu için base'e true gönderiyoruz.
        {

        }
        public SuccessResult() : base(true) // sadece true gönderiyoruz.
        {

        }
    }
}
