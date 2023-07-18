namespace DucksLib;

public sealed class NoQuack : QuackBehaviour
{
    public override void Quack(IQuackState quackState)
    {
        quackState.QuackState = "Silence";
    }
}
