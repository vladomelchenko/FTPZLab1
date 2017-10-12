using System;
using FTPZLab1.Models;
namespace FTPZLab1
{
    static class Tests
    {
        public static bool Test(int sum,int term,int? percent)
        {
            CreditInfo creditInfo = new CreditInfo();
            creditInfo.Sum = sum;
            creditInfo.Term = term;
            if ((sum >= 40000 & percent != null) || (term >= 10 && percent != null))
            {
                creditInfo.Percent = (int) percent;
            }
            Validator validator=new Validator();
            
            if (!validator.Validate(creditInfo))
            {
                Console.WriteLine(validator.ErrorsToStr());
                return false;
            }
            Console.WriteLine(creditInfo.ToString());
            return true;

        }
    }
}
