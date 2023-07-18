namespace DucksLib;

internal static class BehaviourService
{
    public static T CreateQuackBehaviour<T>()
        where T : class, IQuackBehaviour, new() => new();

    public static T CreateFlyBehaviour<T>()
        where T : class, IFlyBehaviour, new() => new();
}
