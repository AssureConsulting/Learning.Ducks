namespace Savaged.Info.Ducks;

public class Squeak : NaturalQuack
{
    public override void Quack(IQuackState quackState)
    {
        quackState.QuackState = "Squeak";
    }
