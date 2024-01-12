using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace UnitTestProject
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void TestStudentName()
        {
            Student student = new Student();
            student.Name = "Anjali";
            string studentName = student.Name;
            Assert.AreEqual("Anjali", studentName);
        }
        [Test]
        public void TestStudentClass()
        {
            Student student = new Student();
            student.Class = 12;
            int studentClass = student.Class;
            Assert.AreEqual(12, studentClass);
        }
        [Test]
        public void TestStudentSection()
        {
            Student student = new Student();
            student.Section = 'A';
            char studentSection = student.Section;
            Assert.AreEqual('A', studentSection);
        }

    }
}

