using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message)
        {
        //sadece mesaj döndürür

              }
        public SuccessResult() : base(true)
        {
            //tek parametre.mesaj vermek istemezse
        }
    }
}
