using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTPZLab1.Models;
namespace FTPZLab1
{
    static class Tests
    {
        public static bool Test(int Sum,int Term)
        {
            CreditInfo creditInfo = new CreditInfo();
            creditInfo.Sum = Sum;
            creditInfo.Term = Term;
            Validator validator=new Validator();
            if (!validator.Validate(creditInfo))
            {
                return false;
            }
            return true;

        }
    }
}
