using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Success ve Message get nasıl set edeceğiz -----> Constructor içerisinde set edilebilir.
    public class Result : IResult
    {
        public Result(bool success ,string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success) 
        {
            Success = success;
        }



        public bool Success { get; }
        public string Message { get; }
    }
}
