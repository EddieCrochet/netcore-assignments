using System;

namespace Lesson00_PreWork
{
    class Program
    {
        static void Main(string[] args)
        {
            View.DisplayMethod();
        }
    }

    public class Controller
    {
        public Controller()
        {
        }

        public static void LoopNum(int RepeatingChar)
        {
            int RepeatNum = 10;
            for (int i = 0; i < RepeatNum; i++)
            {
                Console.Write(Model.RepeatingChar);
            }
        }
    }

    public class Model
    {
        public static int RepeatingChar { get; set; }

        public Model (int repeatingChar)
        {
            RepeatingChar = repeatingChar;
        }
    }

    class View
    {
        public static void DisplayMethod()
        {
            Model myModel = new Model(8);
            Controller.LoopNum(Model.RepeatingChar);
        }
    }
}
