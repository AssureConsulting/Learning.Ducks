using System.Collections.Generic;

namespace DucksFactory;

public static class DuckService
{
    private static readonly IDictionary<Type, IDuck> _ducks;

    static DuckService()
    {
        _ducks = new Dictionary<Type, IDuck>
        {
            { typeof(MallardDuck), DuckBuilder.Create<MallardDuck, FlyWithWings, NaturalQuack>() },
            { typeof(RubberDuck), DuckBuilder.Create<RubberDuck, NoFly, Squeak>() },
            { typeof(DecoyDuck), DuckBuilder.Create<DecoyDuck, NoFly, NoQuack>() }
        };
    }

    public static T? Create<T>()
        where T : class, IDuck, new() => _ducks.ContainsKey(typeof(T)) ? _ducks[typeof(T)] as T : default;
}
