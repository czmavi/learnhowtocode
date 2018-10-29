using ConditionsExam;
using NUnit.Framework;
using System;
using System.IO;

namespace ConsoleExamTest
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void ExamPlus()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader(String.Format("3{0}+{0}1{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.Exam();

                    string expected = string.Format("4", Environment.NewLine);

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }

        [Test]
        public void UnknownOperation()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader(String.Format("1{0}x{0}2{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.Exam();

                    string expected = string.Format("Unknown operation", Environment.NewLine);

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }

        [Test]
        public void DivisionByZero()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader(String.Format("3{0}/{0}0{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.Exam();

                    string expected = string.Format("Unable to divide by zero", Environment.NewLine);

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }

        [SetUp]
        public void Init()
        {
            // Reset console
            var standardOut = new StreamWriter(Console.OpenStandardOutput());

            standardOut.AutoFlush = true;

            Console.SetOut(standardOut);
        }
    }
}
