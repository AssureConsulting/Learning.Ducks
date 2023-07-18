namespace DucksLib;

public class NoFly : FlyBehaviour
{
    public override void Fly(IFlyingState flyingState)
    {
        flyingState.FlyingState = "Nothing";
    }
}
