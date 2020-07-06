using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp.MoodAnalyserException
{
    public class MoodAnalyserExceptionClass:System.Exception
    {
        public enum ExceptionEnmu
        {
            INVAILD_VALUE, NULL_EXCEPTION,EMPTY_EXCEPTION, CLASS_NOT_FOUND, NO_SUCH_METHOD,
            NO_CONSTRUCTOR_FOUND
        }
        public ExceptionEnmu exceptionEnmu;

        public MoodAnalyserExceptionClass(ExceptionEnmu exceptionType,String message) : base(message)
        {
            this.exceptionEnmu = exceptionType;
        }

      
    }
}
