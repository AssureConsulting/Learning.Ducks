namespace DucksLib;

public static class DuckBuilder
{
    public static T? Create<T, F, Q>()
        where T : class, IDuck, new()
        where F : class, IFlyBehaviour, new()
        where Q : class, IQuackBehaviour, new()
    {
        object o = Activator.CreateInstance(
            typeof(T),
            BehaviourService.CreateFlyBehaviour<F>(),
            BehaviourService.CreateQuackBehaviour<Q>());
        if (o is T t) return t;
        else return default;
    }
}
