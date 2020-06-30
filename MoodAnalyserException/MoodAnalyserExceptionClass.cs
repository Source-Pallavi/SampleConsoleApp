using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp.MoodAnalyserException
{
    public class MoodAnalyserExceptionClass:System.Exception
    {
        public enum ExceptionEnmu
        {
            INVAILD_VALUE, NULL_EXCEPTION,EMPTY_EXCEPTION

        }
        public ExceptionEnmu exceptionEnmu;   
        public MoodAnalyserExceptionClass(ExceptionEnmu exceptionType,String message) : base(message)
        {
            this.exceptionEnmu = exceptionType;
        }
    }
}
