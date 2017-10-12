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
            if (creditInfo.Percent < 0)
            {
                stringBuilder.Append("Не правильно введенa процентная ставка").Append(_separator);
                HasError = true;
            }
            if ((creditInfo.Sum >= 40000 && creditInfo.PercentInConstr == false)|| (creditInfo.Term >= 10 && creditInfo.PercentInConstr == false))
            {
                stringBuilder.Append("Укажите процентную ставку").Append(_separator);
                HasError = true;
            }
            if (creditInfo.Sum / Int32.MaxValue >= 1)
            {
                stringBuilder.Append("Сумма кредита вышла за граници 32-битного числа").Append(_separator);
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
