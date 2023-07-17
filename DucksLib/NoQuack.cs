namespace Savaged.Info.Ducks;

public sealed class NoQuack : QuackBehaviour
{
    public override void Quack(IQuackState quackState)
    {
        quackState.QuackState = "Silence";
    }
}
