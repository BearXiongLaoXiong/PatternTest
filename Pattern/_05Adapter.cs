using System;
namespace Pattern
{
    public class _05Adapter
    {
        public void Run()
        {
            Console.WriteLine("05.[ 适配器 ].Adapter.   常见应用:旧系统改造、FileStream Stream之类的个转换使用");
            // 原本功能
            var adaptee = new Adaptee();
            adaptee.Star();

            System.Console.WriteLine("不推荐使用继承的方式，最好使用传入参数的方式");
            // 适配功能更
            ITarget target = new Adapter(adaptee);
            target.HandleStar(); 


            Console.WriteLine("============================================");
        }
    }


    public interface ITarget
    {
        //用户需要的功能
        void HandleStar();
    }

    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            System.Console.WriteLine("我自己处理了点东西");
            _adaptee = adaptee;
        }
        public void HandleStar() => _adaptee.Star();
    }
    // 被适配的class
    public class Adaptee
    {
        public void Star() => System.Console.WriteLine("我是原本的老功能，被适配class");
    }
}