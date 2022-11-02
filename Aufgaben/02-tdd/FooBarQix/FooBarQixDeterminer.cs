namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int number)
        {
            string result = "";
            if (number % 3 == 0) result += "Foo";
            if (number % 5 == 0) result += "Bar";
            if (number % 7 == 0) result += "Qix";
            if (result == "") result += number.ToString();

            return result;
        }
    }
}