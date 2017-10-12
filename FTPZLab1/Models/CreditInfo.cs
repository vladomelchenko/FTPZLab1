using System;
using System.Diagnostics;

namespace FTPZLab1.Models
{
    public class CreditInfo
    {
        private int sum;
        private int term;

        public CreditInfo()
        {
            Percent = 15;
        }
        public int Sum
        {
            get => sum;
            set
            {
                if (value >= 10000 && value < 20000)
                {
                    Percent -= 1;
                }
                else if (value >= 20000 && value < 40000)
                {
                    Percent -= 2;
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
                    Percent += 1;
                }
                else if (value >= 5 && value < 10)
                {
                    Percent += 2;
                }
                term = value;
            }
        }
        public int Percent { get; private set; }

        public double CalculateOverpayments()
        {
            const int forPercent = 100;
            double result = Term * Sum * Percent / forPercent;
            return result;
        }
    }
}