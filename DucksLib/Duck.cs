namespace Savaged.Info.Ducks;

public abstract class Duck : IFlyingState, IQuackState
{
    private readonly IFlyBehaviour _flyBehavior;
    private readonly IQuackBehaviour _quackBehavior;

    protected Duck(IFlyBehaviour flyBehavior, IQuackBehaviour quackBehavior)
    {
        _flyBehavior = flyBehavior ??
            throw new System.ArgumentNullException(nameof(flyBehavior));
        _quackBehavior = quackBehavior ??
            throw new System.ArgumentNullException(nameof(quackBehavior));
    }

    public string? FlyingState { get; set; }

    public string? QuackState { get; set; }

    public void Quack()
    {
        _quackBehavior?.Quack(this);
    }

    public void Fly()
    {
        _flyBehavior?.Fly(this);
    }

    public void Swim()
    {
        // TODO all ducks don't swim (e.g. bronze duck statue)
    }

    public abstract string Display { get; }

}
