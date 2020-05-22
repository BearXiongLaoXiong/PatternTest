using System.Threading.Tasks;
using System;
using System.Diagnostics;

namespace CSharp8_0Test
{
    class Program
    {
        // 01.axync Main方法
        // 02.默认表达式
        static Func<string, bool> whereClause = default;
        static async Task Main(string[] args)
        {
            SpanTest();
            Console.WriteLine("Hello World!");
            await Test();

            whereClause = TestDefault;
            whereClause("123334556");

            Index i1 = 3;
            Index i2 = ^4;
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"{a[i1]}, {a[i2]}");
            var slice = a[5..10];
            foreach (var item in slice) System.Console.WriteLine(item);

            System.Console.ReadLine();
        }

        static async Task Test()
        {
            await Task.FromResult(12);

        }

        static bool TestDefault(string s) => s.Length > 5;

        static void SpanTest()
        {
            var count = 100_0000;
            var sw = new Stopwatch();

            var subContent = "333313333";
            var content = "393939i92jfijf9ifjiewfjifjijijfoifje93f39fj39fj3";

            sw.Start();
            for (var i = 0; i < count; i++)
            {
                content.Contains(subContent);
            }
            sw.Stop();
            Console.WriteLine($"string.Contains {count} 次用时：{sw.ElapsedMilliseconds} 毫秒");

            var subStrSpan = subContent.AsSpan();
            var strSpan = content.AsSpan();

            sw.Restart();
            for (var i = 0; i < count; i++)
            {
                strSpan.Contains(subStrSpan, StringComparison.OrdinalIgnoreCase);
            }
            sw.Stop();
            Console.WriteLine($"Span<T>.Contains {count} 次用时：{sw.ElapsedMilliseconds} 毫秒");
        }
    }


}
