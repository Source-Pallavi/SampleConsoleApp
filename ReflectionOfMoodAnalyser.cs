using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp
{
    class ReflectionOfMoodAnalyser
    {
        //a custom attribute BugFix to be assigned to a class and its members
        [AttributeUsage(
           AttributeTargets.Class |
           AttributeTargets.Constructor |
           AttributeTargets.Field |
           AttributeTargets.Method |
           AttributeTargets.Property,
           AllowMultiple = true)]

        public class MoodAnalyserRef : System.Attribute
        {

        }
    }
}
