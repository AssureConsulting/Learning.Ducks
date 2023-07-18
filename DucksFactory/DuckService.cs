namespace DucksFactory;

public static class DuckService
{
    public static T? Create<T>()
        where T : class, IDuck, new()
    {
        if (typeof(T) == typeof(MallardDuck))
            return DuckBuilder.Create<T, FlyWithWings, NaturalQuack>();
        else if (typeof(T) == typeof(RubberDuck)) 
            return DuckBuilder.Create<T, NoFly, Squeak>();
        else 
            return DuckBuilder.Create<T, NoFly, NoQuack>();
    }

}
