using System;
using System.Collections.Generic;


namespace GradeBook
{
    public class Book
    {

        private List<double> grades = new List<double>();
        public String Name;


        public Book(String Name)
        {
            this.Name = Name;

        }


        public void SetNam(string Name)
        {
            this.Name = Name;
        }
        public String getName()
        {
            return Name;
        }
        public List<double> GetGrades()
        {
            return grades;
        }

        public void AddGrades(double grade)
        {

            if (grade >= 0.0 && grade <= 100.0)
            {
                GetGrades().Add(grade);
            }
            else
            {
                throw new ArgumentException($"{nameof(grade)}  is invalid");
            }
        }
        public double CalculateAverage()
        {
            var sum = 0.0;

            foreach (var grade in GetGrades())
            {
                sum += grade;

            }

            var average = sum / grades.Count;

            return average;
        }

        public double GetMaximumGrade()
        {

            var highest = double.MinValue;
            foreach (var grade in GetGrades())
            {
                if (highest < grade)
                {
                    highest = grade;
                }

            }
            return highest;

        }
        public double GetMinimumGrade()
        {

            var lowest = GetGrades()[0];
            foreach (var grade in GetGrades())
            {
                if (lowest > grade)
                {
                    lowest = grade;
                }

            }
            return lowest;

        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.average = CalculateAverage();
            result.low = GetMinimumGrade();
            result.high = GetMaximumGrade();
            var aver = CalculateAverage();
            switch (aver)
            {
                case var avg when avg >= 90.0:
                    result.Letter = 'A';
                    break;
                case var avg when avg >= 80.0 && avg <= 90.0:
                    result.Letter = 'B';
                    break;
                case var avg when avg >= 70.0 && avg <= 80.0:
                    result.Letter = 'C';
                    break;
                case var avg when avg >= 60.0 && avg <= 70.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
        public void DisplayStatisticsSummary()
        {

            Console.WriteLine($"{toString()} lowest grade is: {GetMinimumGrade():N2}");
            Console.WriteLine($"{toString()} highest grade is: {GetMaximumGrade():N2}");
            Console.WriteLine($"{toString()} average is: {CalculateAverage():N2}");
            Console.WriteLine($"{toString()} letter grade is: {GetStatistics().Letter:N2}");


        }

        public string toString()
        {
            return String.Format($"{getName()}'s GradeBook");
        }

    }


}