using SampleConsoleApp.MoodAnalyser;
using SampleConsoleApp.MoodAnalyserException;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SampleConsoleApp.Reflector
{
    public class ObjectReflector<E> : ReflectionOfMoodAnalyser<E>
    {
        override
         public object GetInsatance(string className, ConstructorInfo constructor)
        {
            try
            {
                Type type = typeof(E);
                if (className != type.Name)
                {
                    throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.CLASS_NOT_FOUND, "No such class found");
                }
                if (constructor != type.GetConstructors()[0])
                {
                    throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.NO_CONSTRUCTOR_FOUND, "No such method found");
                }
                E reflectionGenratedObject = Activator.CreateInstance<E>();
                return reflectionGenratedObject;
            }
            catch (MoodAnalyserExceptionClass e)
            {

                return e.Message;
            }

        }
        override
        public object GetInsatance(string className, ConstructorInfo constructor, string message)
        {
            try
            {
                Type type = typeof(E);
                if (className != type.Name)
                {
                    throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.CLASS_NOT_FOUND, "No such class found");
                }
                if (constructor != type.GetConstructors()[1])
                {
                    throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.NO_CONSTRUCTOR_FOUND, "No such method found");
                }
                object reflectionGenratedObject = Activator.CreateInstance(type, message);
                return reflectionGenratedObject;
            }
            catch (MoodAnalyserExceptionClass e)
            {

                return e.Message;
            }
        }
        override
        public bool InvokeMethods(string method_name, string message)
        {
            try
            {
                Type type = typeof(E);
                if (message != null)
                {
                    object instance = Activator.CreateInstance(type, "I'm  Happy ");
                    MethodInfo method2 = type.GetMethod(method_name);
                    method2.Invoke(instance, new object[] { message });
                    return true;
                }
                else
                {
                    object instance = Activator.CreateInstance(type);
                    MethodInfo method = type.GetMethod("AnalysisMood");
                    method.Invoke(instance, null);
                    return true; 
                }
            }
            catch (MoodAnalyserExceptionClass e)
            {
                throw new MoodAnalyserExceptionClass(MoodAnalyserExceptionClass.ExceptionEnmu.NO_SUCH_METHOD, e.Message);
            }
        }

     
    }


}
