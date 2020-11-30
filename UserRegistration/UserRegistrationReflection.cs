using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationReflection
    {
        public static object SetFieldValue(string message, string fieldName, string methodName)
        {
            // Get the type of the class
            Type type = typeof(Pattern);

            // Create an object of class
            object instance = Activator.CreateInstance(type);

            //Get the field and If the field is not found it throws null exception and if message is empty throw exception
            // catch the exception if thrown
            try
            {
                // Get the field by using reflections
                FieldInfo fieldInfo = type.GetField(fieldName);

                // set the field value of a particular field in particular object
                fieldInfo.SetValue(instance, message);

                // Get the method using reflection
                MethodInfo method = type.GetMethod(methodName);

                // Invoke the method using reflection
                object methodReturn = method.Invoke(instance, null);
                return methodReturn;
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException("No such Field found", UserRegistrationException.ExceptionType.NO_SUCH_FIELD);
            }
            catch
            {
                throw new UserRegistrationException( "Input parameter should not be NULL",UserRegistrationException.ExceptionType.NULL_MESSAGE);
            }
        }
    }
}
