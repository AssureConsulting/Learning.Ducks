namespace Savaged.Info.Ducks;

public class DecoyDuck : Duck
{
    public DecoyDuck() : base(new NoFly(), new NoQuack()) { }

    public override string Display => "I'm a decoy duck";
}
