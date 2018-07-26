using NUnit.Framework;
using System;
using System.IO;

namespace Algebra.Test
{
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void HelloWorld()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(""))
                {
                    Console.SetIn(sr);

                    Program.HelloWorld();

                    string expected = string.Format("Hello World!{0}", Environment.NewLine);

                    Assert.AreEqual(expected, sw.ToString());
                }

            }
        }

        [Test]
        public void Readline()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader("Bla"))
                {
                    Console.SetIn(sr);

                    Program.Readline();

                    string expected = string.Format("Input: Bla{0}", Environment.NewLine);

                    Assert.AreEqual(expected, sw.ToString());
                }

            }
        }

        [Test]
        public void Addition()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader(String.Format("1{0}2{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.Addition();

                    string expected = string.Format("X:{0}Y:{0}1 + 2 = 3{0}", Environment.NewLine);

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }

        [Test]
        public void Substraction()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader(String.Format("3{0}2{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.Substraction();

                    string expected = string.Format("X:{0}Y:{0}3 - 2 = 1{0}", Environment.NewLine);

                    Assert.AreEqual(expected, sw.ToString());
                }
            }
        }

        [Test]
        public void AdditionAndSubstraction()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (var sr = new StringReader(String.Format("3{0}2{0}1{0}", Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Program.AdditionAndSubstraction();

                    string expected = string.Format("X:{0}Y:{0}Z:{0}3 + 2 - 1 = 4{0}", Environment.NewLine);

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
