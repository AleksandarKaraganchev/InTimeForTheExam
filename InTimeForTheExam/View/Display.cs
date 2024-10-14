using InTimeForTheExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTimeForTheExam.View
{
    public class Display
    {
        public void Input(Something exam)
        {
            Console.Write("Enter exam hour:");
            exam.ExamHour = int.Parse(Console.ReadLine());
            Console.Write("Enter exam minute:");
            exam.ExamMinute = int.Parse(Console.ReadLine());
            Console.Write("Enter arrival hour:");
            exam.ArrivalHour = int.Parse(Console.ReadLine());
            Console.Write("Enter arrival minute:");
            exam.ArrivalMinute = int.Parse(Console.ReadLine());
        }
        public void Output(Something exam)
        {
            string status = exam.ArrivalStatus();
            Console.WriteLine(status);
            if (exam.TimeDifference != 0)
            {
                string formattedDifference = exam.FormatDifference();
                Console.WriteLine(formattedDifference);
            }
        }
    }
}
