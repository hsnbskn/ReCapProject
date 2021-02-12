using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false) //base yani Result'a true göndermek için
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}

