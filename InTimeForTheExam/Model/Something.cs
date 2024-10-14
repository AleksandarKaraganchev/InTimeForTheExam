using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTimeForTheExam.Model
{
    public class Something
    {
        private int examHour;
        public int ExamHour
        {
            get { return examHour; }
            set { examHour = value; }
        }
        private int examMinute;
        public int ExamMinute
        {
            get { return examMinute; }
            set { examMinute = value; }
        }
        private int arrivalHour;
        public int ArrivalHour
        {
            get { return arrivalHour; }
            set { arrivalHour = value; }
        }
        private int arrivalMinute;
        public int ArrivalMinute
        {
            get { return arrivalMinute; }
            set { arrivalMinute = value; }
        }
        private int timeDifference;
        public int TimeDifference
        {
            get { return timeDifference; }
            set { timeDifference = value; }
        }
        public void CalculateTimeDifference()
        {
            int examTotalMinutes = ExamHour * 60 + ExamMinute;
            int arrivalTotalMinutes = ArrivalHour * 60 + ArrivalMinute;
            TimeDifference = arrivalTotalMinutes - examTotalMinutes;
        }
        public string ArrivalStatus()
        {
            if (TimeDifference > 0)
            {
                return "Late";
            }
            else if (TimeDifference >= -30)
            {
                return "On time";
            }
            else
            {
                return "Early";
            }
        }
        public string FormatDifference()
        {
            int absDifference = Math.Abs(TimeDifference); //връща абсолютната стойност на свойството TimeDifference
            int hours = absDifference / 60;
            int minutes = absDifference % 60;

            if (TimeDifference < 0)
            {
                if (hours > 0)
                {
                    return $"{hours}:{minutes:d2} hours before the start";
                }
                else
                {
                    return $"{minutes} minutes before the start";
                }
            }
            if (TimeDifference > 0)
            {
                if (hours > 0)
                {
                    return $"{hours}:{minutes:d2} hours after the start";
                }
                else
                {
                    return $"{minutes} minutes after the start";
                }
            }
            return "";
        }
    }
}
