using System;

namespace Classes
{
    public class GenericClass<T1, T2>
    {
        public T1 Field1;
        public T2 Field2;

        public int Number;
        public string Text;

        public GenericClass(T1 field1, T2 field2, int number, string text)
        {
            Field1 = field1;
            Field2 = field2;
            Number = number;
            Text = text;
        }

        public void ShowFields()
        {
            Console.WriteLine("Field1: " + Field1);
            Console.WriteLine("Field2: " + Field2);
            Console.WriteLine("Number: " + Number);
            Console.WriteLine("Text: " + Text);
        }
    }
}
