namespace DucksLib;

public class MallardDuck : Duck
{
    public MallardDuck() : base(new NoFly(), new NoQuack()) { }

    public MallardDuck(IFlyBehaviour flyBehavior, IQuackBehaviour quackBehavior)
        : base(flyBehavior, quackBehavior) { }

    public override string Display => "I'm a Mallard duck";
}
