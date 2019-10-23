using System;
using System.IO;
using NUnit.Framework;

namespace Open_Lab_02._02
{
    [TestFixture]
    public class Tests
    {
        private TextWriter consoleOutput;
        private StringWriter stringWriter;

        [SetUp]
        public void SetUp()
        {
            consoleOutput = Console.Out;
            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            stringWriter.Dispose();
            Console.SetOut(consoleOutput);
        }

        [Test]
        public void Format()
        {
            var formatter = new Formatter();
            var numbers = new[] {1.23456, 2.34567, 3.45678, 4.56789, 5.67890};
            formatter.Format(numbers);
            stringWriter.Flush();
            Assert.That(stringWriter.ToString(), Is.EqualTo("1.23 2.35 3.46 4.57 5.68"));
        }
    }
}