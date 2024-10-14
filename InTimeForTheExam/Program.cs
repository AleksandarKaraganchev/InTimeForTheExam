using InTimeForTheExam.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomethingActionController controller = new SomethingActionController();
            controller.Start();
        }
    }
}
