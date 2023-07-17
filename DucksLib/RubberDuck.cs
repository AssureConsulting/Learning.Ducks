namespace Savaged.Info.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck() : base(new NoFly(), new Squeak()) { }

    public override string Display => "I'm a rubber duck";

