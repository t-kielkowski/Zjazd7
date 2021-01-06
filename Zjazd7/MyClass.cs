// Stwórz dowolną klasę. Dodaj do niej publiczne pola lub właściwości do przechowania Id i dowolnej wartości tekstowej. Dodaj do klasy tablicę 10 liczb całkowitych.
// Zaimplementuj w klasie interfejs ICloneable [https://docs.microsoft.com/en-us/dotnet/api/system.icloneable?view=net-5.0#remarks]. Metoda Clone powinna tworzyć głęboką kopię obiektu - przepisywać wartości proste i przepisywać wartości do nowej tablicy.
// Zaimplementuj w klasie interfejs IComparable<T> (gdzie T to nazwa tej samej klasy) [https://docs.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=net-5.0#examples]. Metoda CompareTo powinna sprawić, że elementy ułożą się alfabetycznie względem pola tekstowego.
// Stwórz interfejs IPrintable i dodaj do niego metodę void Print( ). Zaimplementuj w klasie interfejs IPrintable. Metoda powinna wypisywać w przyjazny sposób wszystkie dane zapisane w klasie.
//
// Stwórz tablicę 100 losowych elementów tej klasy (id powinny być w kolejności 1,2,3..., tekst może być dowolny/losowy, tablicę wypełnij losowymi liczbami).
// Stwórz listę, do której dodasz klony elementów tablicy. Wyzeruj tablice w oryginalnych obiektach (tablice klonów powinny pozostać nienaruszone). Wywołaj na kolekcji metodę Sort. Wywołaj metodę Print z każdego elementu posortowanej kolekcji.

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

        public int CompareTo(MyClass other)
        {
            return Name.CompareTo(other.Name);
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