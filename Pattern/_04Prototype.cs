using System;
namespace Pattern
{
    public class _04Prototype
    {
        public void Run()
        {
            Console.WriteLine("04.[ 原型 ].Prototype");

            var sheep = new Sheep { Name = "AAA", Birthday = "111" };
            Console.WriteLine(sheep.GetHashCode());

            var sheep1 = sheep;
            System.Console.WriteLine($"修改前:{sheep1.GetHashCode()},name = {sheep1.Name}");
            sheep.Name = "修改一下";
            System.Console.WriteLine($"修改后:{sheep1.GetHashCode()},name = {sheep1.Name}");

            var sheep2 = sheep.Clone() as Sheep;
            System.Console.WriteLine($"{sheep2.GetHashCode()},name = {sheep2.Name}");
            sheep.Name = "继续修改";
            System.Console.WriteLine($"{sheep2.GetHashCode()},name = {sheep2.Name}");

            Console.WriteLine("============================================");
        }
    }

    public class Sheep : ICloneable
    {

        public string Name { get; set; }
        public string Birthday { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}