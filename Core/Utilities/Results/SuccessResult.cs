using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true) //base yani Result'a true göndermek için
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
