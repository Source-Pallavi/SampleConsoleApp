using SampleConsoleApp.MoodAnalyserException;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp.MoodAnalyser
{
    public class MoodAnalysis
    {
      
        private string mood;

        public MoodAnalysis(String mood)
        {
            this.mood = mood;
        }


        public string AnalysisMood()
        {
            try
            {   if (mood.Length == 0)
                    throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.EMPTY_EXCEPTION, "Mood Should Not be Empty");

                if(mood == null)
                    throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.NULL_EXCEPTION, "Mood Should Not be Null");
                if (this.mood.Contains("Happy"))
                    return "Happy";
                if (mood.Contains("Sad"))
                    return "Sad";
               
                return "I am not sure about mood";
            }
            catch(MoodAnalyserExceptionClass e)
            {
                throw e;
            }
            
        }
       
    }
}
