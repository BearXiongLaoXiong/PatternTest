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
            System.Console.WriteLine("修改一下试试");
            System.Console.WriteLine("对齐一下试试");
            new _03Builder().Run();
            new _04Prototype().Run();

            new _05Adapter().Run();
            new _12Proxy().Run();

        }
    }
}
