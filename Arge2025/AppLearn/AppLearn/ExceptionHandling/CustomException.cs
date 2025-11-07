using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn.ExceptionHandling
{
    public class CustomException : Exception
    {
        public string FilePath { get; set; }
        public override IDictionary Data => base.Data;

        public override string? HelpLink { 
            get => base.HelpLink; 
            set => base.HelpLink = value; 
        }

        public override string Message => base.Message;

        public override string? Source { 
            get => base.Source; 
            set => base.Source = value; 
        }

        public override string? StackTrace => base.StackTrace;

        public CustomException()
        {
        }

        public CustomException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public CustomException(string? message, string filePath, Exception? innerException) : base(message, innerException)
        {
            FilePath = filePath;
        }

        public override Exception GetBaseException()
        {
            return base.GetBaseException();
        }
    }
}
