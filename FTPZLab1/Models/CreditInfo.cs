using System;
using System.Diagnostics;

namespace FTPZLab1.Models
{
    public class CreditInfo
    {
        private int sum;
        private int term;
        private int percent;
        public bool PercentInConstr { get; set; }
        public int Percent
        {
            get => percent;
            set
            {
                PercentInConstr = true;
                if (sum >= 40000 || term >= 10)
                {
                    percent = value;
                }
            }
        }

        public CreditInfo()
        {
            percent = 15;
        }
        public int Sum
        {
            get => sum;
            set
            {
                if (value >= 10000 && value < 20000)
                {
                    percent -= 1;
                }
                else if (value >= 20000 && value < 40000)
                {
                    percent -= 2;
                }
                sum = value;
            }
        }
        public int Term
        {
            get => term;
            set
            {
                if (value >= 3 && value < 5)
                {
                    percent += 1;
                }
                else if (value >= 5 && value < 10)
                {
                    percent += 2;
                }
                term = value;
            }
        }

        public double CalculateOverpayments()
        {
            const int forPercent = 100;
            double result = Term * Sum * Percent / forPercent;
            return result;
        }

        public override string ToString()
        {
            return "Sum = "+sum+"\nTerm = "+term+"\nPercent = "+percent+"\nOverpayments = "+Convert.ToString(CalculateOverpayments());
        }
    }
}