namespace DucksLib;

public class DecoyDuck : Duck
{
    public DecoyDuck() : base(new NoFly(), new NoQuack()) { }

    public DecoyDuck(IFlyBehaviour flyBehavior, IQuackBehaviour quackBehavior)
        : base(flyBehavior, quackBehavior) { }

    public override string Display => "I'm a decoy duck";
}
