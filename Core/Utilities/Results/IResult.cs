using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{ //void başlangıçları
  public  interface IResult
    {
       bool Success { get; }
        string Message { get; }
    }
}
