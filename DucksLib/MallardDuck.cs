namespace Savaged.Info.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck() : base(new FlyWithWings(), new NaturalQuack()) { }

    public override string Display => "I'm a Mallard duck";
}
