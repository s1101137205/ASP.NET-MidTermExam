using AopAlliance.Intercept;
using TestCore.Models;
using System;
using System.Diagnostics;

namespace TestCore.Interceptors 
{
    class UpdateCourseNameInterceptor : IMethodInterceptor
    {

        public object Invoke(IMethodInvocation invocation)
        {

            Console.WriteLine("UpdateCourseNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);
            Debug.Print("UpdateCourseNameInterceptor 攔截到一個方法呼叫 = [{0}]", invocation);

            object result = invocation.Proceed();

            if (result is Course)
            {
                Course course = (Course)result;
                course.Name = course.Name + " 上面偷偷加東西";
                result = course;
            }

            return result;
        }
    }
}
