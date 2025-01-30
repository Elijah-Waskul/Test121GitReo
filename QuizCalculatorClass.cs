// Written by Elijah Waskul
// 1/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCalculator
{
    public class QuizCalculatorClass
    {
        // class variables 
        private double quiz1 = -9999.99;
        private double quiz2 = -9999.99;
        private double quiz3 = -9999.99;
        private double quiz4 = -9999.99;
        
        //private double total = -39999.96;
        //private double average = -9999.99;
        //private string letterGrade = "n/a";

        // Gets and Sets

        // Beware magic numbers 
        public double Quiz1
        { 
          get { return quiz1; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz1 = -9999.99;
                }
                else
                {
                    this.quiz1 = value;
                }


            }
        }
        public double Quiz2
        {
            get { return quiz2; }
            set 
            { 
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz2 = -9999.99;
                }
                else
                {
                    this.quiz2 = value;
                }
                    
                        
            }
        }
        public double Quiz3
        {
            get { return quiz3; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz3 = -9999.99;
                }
                else
                {
                    this.quiz3 = value;
                }


            }
        }
        public double Quiz4
        {
            get { return quiz4; }
            set
            {
                if (value > 100.0 || value < 0.0)
                {
                    this.quiz4 = -9999.99;
                }
                else
                {
                    this.quiz4 = value;
                }


            }
        }

        // methods

        public double CalcTotal()
        {
            double aTotal = 0.0;

            aTotal = Quiz1 + Quiz2 + Quiz3 + Quiz4;

            return aTotal;
        }
        public double CalcAverage()
        {
            double aAverage = 0.0;

            // The 4 is a classic "Magic Number"
            aAverage = Quiz1 + Quiz2 + Quiz3 + Quiz4 / 4;

            return aAverage;
        }
        public string CalcLetterGrade()
        {
            double aAverage = 0.0;
            string aLetterGrade = "n/a";

            aAverage = (Quiz1 + Quiz2 + Quiz3 + Quiz4) /4;

            if(aAverage >= 0.0 && aAverage < 60.0)
            {
                aLetterGrade = "F";
            }
            if (aAverage >= 0.0 && aAverage < 70.0)
            {
                aLetterGrade = "D";
            }
            if (aAverage >= 0.0 && aAverage < 80.0)
            {
                aLetterGrade = "C";
            }
            if (aAverage >= 0.0 && aAverage < 90.0)
            {
                aLetterGrade = "B";
            }
            if (aAverage >= 0.0 && aAverage < 100.0)
            {
                aLetterGrade = "A";
            }

            return aLetterGrade;
        }




    }
}
