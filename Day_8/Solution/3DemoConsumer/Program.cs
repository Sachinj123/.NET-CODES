using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace _3DemoConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathOfDll = "C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_8\\Solution\\Maths\\bin\\Debug\\Maths.dll";


            //BELOW CODE IS RESPONSIBLE FOR LOADING TOP LEVEL TYPE METADATA
            //INFORMATION FROM MATHS.DLL

            Assembly assembly = Assembly.LoadFrom(pathOfDll);

            Type[] allTypes = assembly.GetTypes();
            
            foreach (Type type in allTypes)
            {
                Console.WriteLine(type.Name);
                Console.WriteLine(type.FullName);

                MethodInfo[] allMethods = type.GetMethods();
                foreach (MethodInfo method in allMethods)
                {
                    Console.WriteLine(method.ReturnType+"  "+method.Name);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (ParameterInfo para in parameters)
                    {
                        Console.WriteLine(para.ParameterType.ToString()+" "+para.Name + " ");
                    }
                    Console.Write(" ) ");
                    Console.WriteLine();
                }


            }
            Console.ReadLine();

        }
    }
}
