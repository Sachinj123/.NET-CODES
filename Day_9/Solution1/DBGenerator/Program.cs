using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MyOwnAttributes;

namespace DBGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Path of Your Class Library: ");
            string path = Console.ReadLine();

            Assembly assembly = Assembly.LoadFrom(path);

            Type[] allTypes = assembly.GetTypes();
            string query = " ";

            foreach(Type type in allTypes)
            {
                List<Attribute> allAttributes = type.GetCustomAttributes().ToList();

                foreach(Attribute attribute in allAttributes)
                {

                    if(attribute is Table)
                    {
                        Table tableAttributeObject = (Table)attribute;
                        string tableName = tableAttributeObject.TableName;

                        query = query + " Create Table " + tableName +" (";
                        break;
                    }

                   
                }

                PropertyInfo[] allGettersSetters = type.GetProperties();

                foreach (PropertyInfo propertyInfo in allGettersSetters)
                {
                    List<Attribute> AllAttributeOnCurrentGetterSetter =
                        propertyInfo.GetCustomAttributes().ToList();

                    foreach (Attribute attributeOnGetterSetter in AllAttributeOnCurrentGetterSetter)
                    {
                        if (attributeOnGetterSetter is Column)
                        {
                            Column columnAttributeObject = (Column)attributeOnGetterSetter;

                            query = query + columnAttributeObject.ColumnName + " " +
                                columnAttributeObject.ColumnType + " , ";
                                 break;
                        }
                    }
                }
                query = query.TrimEnd(new char[] {','});
                query = query + " ) ";

                //Console.WriteLine(query);
            }
            Console.WriteLine(query);
            Console.ReadLine();
        }
    }
}
 