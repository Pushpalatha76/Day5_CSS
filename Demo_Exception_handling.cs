using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exception_handling
{
    class Class1
    {
    }

    /// <summary>
    ///  User Define Exception Handling using Base Exception Class 
    /// </summary>
    [Serializable]
    public class StudentNotFoundException : Exception
    {
        public string StudentName { get; set; }
        public StudentNotFoundException() { }
        public StudentNotFoundException(string message) : base(message) {}

        //Console.WriteLine(" Calling base class message defined in Exception class");

        public StudentNotFoundException(string Message, Exception InnerException) : base(Message, InnerException) { }

        public StudentNotFoundException(string message, string studentName)
       : this(message)
        {
            StudentName = studentName;
        }
    }
}