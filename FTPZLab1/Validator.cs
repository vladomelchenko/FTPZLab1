using System;
using System.Text;
using FTPZLab1.Models;

namespace FTPZLab1
{
    class Validator
    {
        public static bool HasError { get; set; }
        public static string ErrorMessage { get; set; }
        private static readonly string _separator = Environment.NewLine;
        public bool Validate(CreditInfo creditInfo)
        {
            HasError = false;
            StringBuilder stringBuilder = new StringBuilder();
            if (creditInfo.Sum >= 40000 || creditInfo.Term >= 10)
            {
                stringBuilder.Append("Ставка обговаривается индивидуально").Append(_separator);
                HasError = true;
            }
            if (creditInfo.Sum < 1000)
            {
                stringBuilder.Append("Кредит на такую сумму не выдается").Append(_separator);
                HasError = true;
            }
            if (creditInfo.Term <= 0)
            {
                stringBuilder.Append("Не правильно введен срок").Append(_separator);
                HasError = true;
            }
            if (HasError)
            {
                ErrorMessage = stringBuilder.ToString();
                return false;
            }
            return true;
        }

        public string ErrorsToStr()
        {
            return ErrorMessage;
        }
    }
}
