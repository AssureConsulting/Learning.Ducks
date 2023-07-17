namespace Savaged.Info.Ducks;

public class NaturalQuack : QuackBehaviour
{
    public override void Quack(IQuackState quackState)
    {
        quackState.QuackState = "Quack";
    }
