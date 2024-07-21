using FileHandler.Services;
using System.Xml;
using System.Xml.Linq;

namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XService xService = new XService("C:\\Users\\adler\\source\\repos\\QuizMaker\\QuizMaker\\XMLFile1.xml");
            xService.QuestionOrAnswer();
            xService.Cli();
            Console.ReadLine();


        }






    }
}
