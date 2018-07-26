using AlgebraExam;
using NUnit.Framework;
using System;
using System.IO;

namespace AlgebraExamTest
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void Exam()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader(String.Format("3{0}2{0}1{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.Exam();

                    string expected = string.Format("X:{0}Y:{0}Z:{0}1 + 1 - 3 + 2 = 1{0}", Environment.NewLine);

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
