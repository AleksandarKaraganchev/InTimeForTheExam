using InTimeForTheExam.Model;
using InTimeForTheExam.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTimeForTheExam.Controller
{
    public class SomethingActionController
    {
        private Something exam;
        private Display display;
        public SomethingActionController()
        {
            exam = new Something();
            display = new Display();
        }
        public void Start()
        {
            display.Input(exam);
            exam.CalculateTimeDifference();
            display.Output(exam);
        }
    }
}
