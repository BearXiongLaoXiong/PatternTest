using System;
using testclasslib;



/*
dotnet new sln -n myPro
dotnet new console -n myPro.App
dotnet sln add myPro.App
dotnet new classlib -n Infrastructur
dotnet add myPro.App reference Infrastructure
*/
namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                new _03Builder().Run();
                new _04Prototype().Run();
            }
        }
    }
}
