using System;
using firslib;

namespace firstcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ob  = new operation();
            
            System.Console.WriteLine(ob.addition(4,5));
        }
    }
}
// dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura