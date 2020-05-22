using System;
namespace Pattern
{
    public class _12Proxy
    {
        public void Run()
        {
            Console.WriteLine("12.[ 代理 ].Proxy.   常见应用:AOP,安全，远程，延迟,静态,动态;抽象角色:代理角色,真实角色都必须实现抽象角色");
            IStar real = new RealStar();
            var proxy = new ProxyStar(real);
            proxy.Confer();
            proxy.SignContract();
            proxy.BookTicket();
            proxy.Sing();
            proxy.CollectMoney();

            Console.WriteLine("============================================");
        }
    }

    // 静态代理案例
    public interface IStar
    {
        void Confer();
        void SignContract();
        void BookTicket();
        void Sing();
        void CollectMoney();
    }

    public class RealStar : IStar
    {
        public void BookTicket() => Console.WriteLine("RealStar . 1");
        public void CollectMoney() => Console.WriteLine("RealStar . 2");
        public void Confer() => Console.WriteLine("RealStar . 3");
        public void SignContract() => Console.WriteLine("RealStar . 4");
        public void Sing() => Console.WriteLine("RealStar . 5");
    }

    public class ProxyStar : IStar
    {
        private IStar _star;

        public ProxyStar(IStar star)
        {
            _star = star;
        }

        public void BookTicket() => Console.WriteLine("ProxyStar . 1");
        public void CollectMoney() => Console.WriteLine("ProxyStar . 2");
        public void Confer() => Console.WriteLine("ProxyStar . 3");
        public void SignContract() => Console.WriteLine("ProxyStar . 4");
        public void Sing() => _star.Sing();
    }
}