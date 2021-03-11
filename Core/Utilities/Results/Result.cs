using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this-->resultın kendisi, resultın kendisine successi yolla
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //burayı da kapsar
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
