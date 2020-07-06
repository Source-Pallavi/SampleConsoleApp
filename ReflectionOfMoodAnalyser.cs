using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using SampleConsoleApp.MoodAnalyser;
using SampleConsoleApp.MoodAnalyserException;
using SampleConsoleApp.Reflector;

namespace SampleConsoleApp
{
    public abstract class ReflectionOfMoodAnalyser<E>
    {

        public ConstructorInfo GetConstuctor()
        {
            try
            {
                Type type = typeof(E);
                ConstructorInfo[] constructor = type.GetConstructors();
                return constructor[0];
            }
            catch (MoodAnalyserExceptionClass e)
            {
                throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.CLASS_NOT_FOUND, e.Message);
            }
        }

        public ConstructorInfo GetConstuctor(string className)
        {
            try
            {
                Type type = Type.GetType(className);
                ConstructorInfo[] constructor = type.GetConstructors();
                return constructor[0];
            }
            catch (MoodAnalyserExceptionClass e)
            {
                throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.CLASS_NOT_FOUND, e.Message);
            }
        }
        public ConstructorInfo GetConstuctor(int numberOfParameters)
        {
            try
            {
                Type type = typeof(E);

                ConstructorInfo[] constructor = type.GetConstructors();
                foreach (ConstructorInfo index in constructor)
                {
                    int numberOfParam = index.GetParameters().Length;
                    while (numberOfParam == numberOfParameters)
                    {
                        return index;
                    }
                }
                return constructor[0];
            }
            catch (MoodAnalyserExceptionClass e)
            {
                throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.CLASS_NOT_FOUND, e.Message);
            }
        }

        public abstract object GetInsatance(string className, ConstructorInfo constructor, string message);
        public abstract object GetInsatance(string className, ConstructorInfo constructor);
        public abstract bool InvokeMethods(string method_name, string message);


    }
}
