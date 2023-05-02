using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsumer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string pathOfDll =
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

                    Console.WriteLine(" Calling "+method.Name+" Method ");
                    ParameterInfo[] allparams = method.GetParameters();
                    
                    
                    object[] argument = new object[allparams.Length] ;
                    for(int i =0; i < allparams.Length; i++ )
                    {
                        Console.WriteLine(" Enter " + allparams[i].ParameterType.ToString() +" value for "+
                            allparams[i].Name);

                        argument[i] = Convert.ChangeType(Console.ReadLine(),
                            allparams[i].ParameterType);
                    }

                    object RESULT = type.InvokeMember(method.Name,
                          BindingFlags.Public |//METHOD WITH PUBLIC ACCESS MODIFIER
                          BindingFlags.Instance |//WE CAN CREATE INSTANCE
                          BindingFlags.InvokeMethod,//METHOD SHOULD BE INVOCABLE
                          null,
                          dynamicObject,
                          argument);

                    Console.WriteLine("Result of " + method.Name + " executed is " + RESULT.ToString());

                    //WE PASS NULL TO THE BINDER BECAUSE THERE IS NO CONFUSION
                    //IF THERE IS A CONFUSION THEN WE NEED TO PASS BINDER
                }


            }
            Console.ReadLine();

        }
    }
}
