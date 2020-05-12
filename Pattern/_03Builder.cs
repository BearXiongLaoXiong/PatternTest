using System;
namespace Pattern
{
    public class _03Builder
    {
        public void Run()
        {
            Console.WriteLine("03.[ 建造者 ].Builder");
            var director = new AirShipDirect6(new AirshipBuilder6());
            var ship = director.DirectAirShip();
            var name = ship.Engine.Name;
            System.Console.WriteLine($"获取到Name:{name}");
            Console.WriteLine("============================================");
        }
    }

    public class AirShip
    {
        public OrbitalModule OrbitalModule { get; set; }
        public Engine Engine { get; set; }
        public EscapeTower EscapeTower { get; set; }
        public void Launch()
        {
            System.Console.WriteLine("走你!!!!!!!!");
        }
    }
    public class OrbitalModule
    {
        public string Name { get; set; }
    }
    public class Engine
    {
        public string Name { get; set; }
    }
    public class EscapeTower
    {
        public string Name { get; set; }
    }


    public interface IAirShipBuilder
    {
        Engine BuilderEngine();
        OrbitalModule BuilderOrbitalModule();
        EscapeTower BuilderEscapeTower();
    }
    public class AirshipBuilder6 : IAirShipBuilder
    {
        public OrbitalModule BuilderOrbitalModule()
        {
            Console.WriteLine($"创建{nameof(OrbitalModule)}");
            return new OrbitalModule() { Name = "A" };
        }

        public Engine BuilderEngine()
        {
            Console.WriteLine($"创建{nameof(Engine)}");
            return new Engine() { Name = "B" };
        }

        public EscapeTower BuilderEscapeTower()
        {
            Console.WriteLine($"创建{nameof(EscapeTower)}");
            return new EscapeTower() { Name = "C" };
        }
    }

    public interface IAirShipDirector
    {
        AirShip DirectAirShip();
    }
    public class AirShipDirect6 : IAirShipDirector
    {
        private IAirShipBuilder _builder;

        public AirShipDirect6(IAirShipBuilder builder)
        {
            _builder = builder;
        }

        public AirShip DirectAirShip()
        {
            var engine = _builder.BuilderEngine();
            var module = _builder.BuilderOrbitalModule();
            var escape = _builder.BuilderEscapeTower();

            var ship = new AirShip { Engine = engine, OrbitalModule = module, EscapeTower = escape };
            ship.Launch();
            return ship;
        }
    }

}