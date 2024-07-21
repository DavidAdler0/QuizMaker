using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FileHandler.Services
{
    internal class XService
    {

        XDocument Doc;
        public string _path;

        public XService(string path)
        {
            _path = path;
            Doc = XDocument.Load(path);
        }
        public void demo()
        {
            var children = Doc.Root.Elements().ToList();

            foreach (var child in children)
            {
                Console.WriteLine($"Element Name: {child.Name}");
                Console.WriteLine($"Element Value: {child.Value}");
                Console.WriteLine();
            }
        }
        public int QuestionOrAnswer()
        {
            var message = @"
                            1. Create questions
                            2. Answer Questions";
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        public void CLIq()
        {
            Console.WriteLine("Enter a question");
            string question = Console.ReadLine();
            Console.WriteLine("Enter an answer");
            string answer = Console.ReadLine();
            XElement newQA = new XElement("Item", new XElement("Question", question), new XElement("Answer", answer));
            Doc.Root.Add(newQA);
            Doc.Save(_path);

            Console.WriteLine($"added question: {question} \n answer: {answer}");
        }
        public void CLIa()
        {
            Console.WriteLine("Enter an answer");
            string answer = Console.ReadLine();
            Console.WriteLine($"answer: {answer}");
        }

        public void Cli()
        {
            int option = QuestionOrAnswer();
            switch (option)
            {
                case 1:
                    CLIq();
                    break;
                case 2:
                    CLIa();
                    break;
            }
        }


    }
}