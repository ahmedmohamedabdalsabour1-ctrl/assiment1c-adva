using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assiment1c_adva
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region
            /*A generic class is a class that can work with different data types without rewriting the class for each type
             * It uses a type parameter, commonly written as <T>
             */
            /*Container<string> stringContainer = new Container<string>();

            stringContainer.Add("Hello");

            Console.WriteLine(stringContainer.Get());
            */
            /* Multiple type parameters means that a generic class can use more than one type parameter.
            For example, Pair<T1, T2> can store two values of different types.*/

            /*  Pair<int, string> p = new Pair<int, string>(10, "Ahmed");

              Console.WriteLine(p.GetFirst());
              Console.WriteLine(p.GetSecond());
            */
            /*A generic method is a method that can work with different data types by using a type parameter such as <T>.*/
            /*static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }*/


            /*static T FindMax<T>(T a, T b) where T : IComparable<T>
            {
            if (a.CompareTo(b) > 0)
            return a;
            else
            return b;
            }*/
            /*A generic interface is an interface that uses a type parameter such as <T>. It allows the same interface to work with different data types
             * class Repository<T> : IRepository<T>
            {
                private T item;

                public void Add(T item)
                {
                    this.item = item;
                }

                public T Get(int id)
                {
                    return item;
                }
            }
            */
            // means that the generic type T must be a value type
            /*static void PrintValue<T>(T value) where T : struct
            {
            Console.WriteLine(value);
            }*/
            /*means that the generic type T must be a reference type, such as string or a user-defined class
             * static void PrintObject<T>(T value) where T : class
            {
                Console.WriteLine(value);
            }*/
            /*means that the generic type T must have a public parameterless constructor
             * static T CreateObject<T>() where T : new()
            {
                return new T();
            }*/
            /*the generic type T must implement a specific interface
             * interface IPrintable
            {
                void Print();
            }

            static void PrintObject<T>(T obj) where T : IPrintable
            {
                obj.Print();
            }*/

            //generic type T must inherit from a specific base class
            //generic type by putting them together after where T
            /*interface IPrintable
            {
            void Print();
            }

            class Student : IPrintable
            {
            public Student()
            {
            }

            public void Print()
            {
            Console.WriteLine("Student");
            }
            }

            static void PrintObject<T>(T obj)
            where T : class, IPrintable, new()
            {
            obj.Print();
            }*/
            //returns the default value of a generic type T
            /*class SafeList<T>
            {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
            items.Add(item);
            }

            public T Get(int index)
            {
            if (index >= 0 && index < items.Count)
            return items[index];

            return default;
            }
            }*/
            //Covariance allows a generic type to use a more derived type where a base type is expected
            //Contravariance allows a generic type with a base type to be used where a derived type is expected

            //16  Contravariance allows a generic type with a base type to be used where a derived type is expected
            //Covariance	Contravariance
            //Contravariance
            /* Uses out	Uses in
 Works with return/ output    Works with input
 Derived → Base Base → Derived
 Example: IProducer < Dog > → IProducer<Animal> Example: IConsumer < Animal > → IConsumer<Dog>*/
            //A static member in a generic class is separate for each type argument.




            #endregion
        }
    }
}
