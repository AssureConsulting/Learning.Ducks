namespace DucksLib;

public class Squeak : NaturalQuack
{
    public override void Quack(IQuackState quackState)
    {
        quackState.QuackState = "Squeak";
    }
}
