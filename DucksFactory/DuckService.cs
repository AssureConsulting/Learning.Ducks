using System.Collections.Generic;

namespace DucksFactory;

public static class DuckService
{
    private static readonly IDictionary<Type, IDuck> _ducks;

    static DuckService()
    {
        _ducks = new ReadOnlyDictionary
        {
            { typeof(MallardDuck), DuckBuilder.Create<T, FlyWithWings, NaturalQuack>() },
            { typeof(RubberDuck), DuckBuilder.Create<T, NoFly, Squeak>() },
            { typeof(DecoyDuck), DuckBuilder.Create<T, NoFly, NoQuack>() }
        };
    }

    public static T? Create<T>()
        where T : class, IDuck, new() => _ducks.ContainsKey(typeof(T)) ? _ducks[typeof(T)] : default;

}
