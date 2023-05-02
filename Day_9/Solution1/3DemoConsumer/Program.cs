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
            //string pathOfDll = "C:\\Users\\sachin\\Desktop\\PGDAC\\.net\\Sunbeam Lectures\\CODES\\Day_8\\Solution\\Maths\\bin\\Debug\\Maths.dll";
            Console.WriteLine("Enter the Path of The Assembly :");
            string pathOfDll = Console.ReadLine();

            //BELOW CODE IS RESPONSIBLE FOR LOADING TOP LEVEL TYPE METADATA
            //INFORMATION FROM MATHS.DLL

            
            Assembly assembly = Assembly.LoadFrom(pathOfDll);

            //NOW WE ASK ASSEMBLY OBJECT REST OF THE DETAILS.... 
            Type[] allTypes = assembly.GetTypes();
            object dynamicObject = null;
            
            
            foreach (Type type in allTypes)
            {
                Console.WriteLine(type.Name);
                //Console.WriteLine(type.FullName);

                dynamicObject = assembly.CreateInstance(type.FullName);
                

                MethodInfo[] allMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly); ;
                foreach (MethodInfo method in allMethods)
                {
                    Console.WriteLine(method.ReturnType+"  "+method.Name + " ( ");
                    
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (ParameterInfo para in parameters)
                    {
                        Console.WriteLine(para.ParameterType.ToString()+" "+para.Name + " ");
                    }
                    Console.Write(")");
                    Console.WriteLine();
                    object[] allparas = new object[] { 10, 20 };

                  object RESULT =  type.InvokeMember(method.Name,
                        BindingFlags.Public |//METHOD WITH PUBLIC ACCESS MODIFIER
                        BindingFlags.Instance |//WE CAN CREATE INSTANCE
                        BindingFlags.InvokeMethod,//METHOD SHOULD BE INVOCABLE
                        null,
                        dynamicObject, 
                        allparas);

                    Console.WriteLine("Result of "+method.Name+"executed is "+RESULT.ToString());

                    //WE PASS NULL TO THE BINDER BECAUSE THERE IS NO CONFUSION
                    //IF THERE IS A CONFUSION THEN WE NEED TO PASS BINDER
                }


            }
            Console.ReadLine();

        }
    }
}
