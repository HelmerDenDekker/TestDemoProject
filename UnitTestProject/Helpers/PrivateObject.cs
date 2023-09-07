using System;
using System.Reflection;

namespace UnitTestProject.Helpers
{
    internal class PrivateObject
    {
        private readonly object o;

        internal PrivateObject(object o)
        {
            this.o = o;
        }

        internal object Invoke(string methodName, params object[] args)
        {
            var methodInfo = o.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (methodInfo == null)
            {
                throw new Exception($"Method'{methodName}' not found is class '{o.GetType()}'");
            }
            return methodInfo.Invoke(o, args);
        }
    }
}
