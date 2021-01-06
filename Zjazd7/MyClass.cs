using System;

namespace Zjazd7
{
    interface IPrintable
    {
        void Print();
    }

    public class MyClass : ICloneable, IComparable<MyClass>, IPrintable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Tab { get; set; }

        public MyClass()
        {
        }

        public MyClass(int id, string name, int[] tab)
        {
            Id = id;
            Name = name;
            Tab = tab;
        }

        public object Clone()
        {
            var temporary = new MyClass();

            temporary.Id = this.Id;
            temporary.Name = this.Name;
            temporary.Tab = this.Tab;

            return temporary;
        }

        public int CompareTo(MyClass rhs)
        {
            return Name.CompareTo(rhs.Name);
        }

        public void Print()
        {
            Console.Write($"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Tab)}: ");
            foreach (var t in this.Tab)
            {
                Console.Write(t + " ");
            }

            Console.WriteLine();
        }
    }
}