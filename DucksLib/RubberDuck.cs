namespace DucksLib;

public class RubberDuck : Duck
{
    public RubberDuck() : base(new NoFly(), new Squeak()) { }

    public RubberDuck(IFlyBehaviour flyBehavior, IQuackBehaviour quackBehavior)
        : base(flyBehavior, quackBehavior) { }

    public override string Display => "I'm a rubber duck";

}
