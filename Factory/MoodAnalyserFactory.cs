using SampleConsoleApp.MoodAnalyser;
using SampleConsoleApp.MoodAnalyserException;
using System;
using System.Reflection;


namespace SampleConsoleApp.Factory
{
   public class MoodAnalyserFactory
    {
        public object MoodAnalyserObject(String class_name)
        {
           if(class_name== "MoodAnalysis")
                return new MoodAnalysis();
             throw  new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.CLASS_NOT_FOUND, "Mood Should Not be Null");
        }

       
    }
}
