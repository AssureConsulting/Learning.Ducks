namespace Savaged.Info.Ducks;

public class NoFly : FlyBehaviour
{
    public override void Fly(IFlyingState flyingState)
    {
        flyingState.FlyingState = "Nothing";
    }
}
