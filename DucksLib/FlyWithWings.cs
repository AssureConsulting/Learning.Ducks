namespace Savaged.Info.Ducks;

public class FlyWithWings : FlyBehaviour
{
    public override void Fly(IFlyingState flyingState)
    {
        flyingState.FlyingState = "Flying with wings";
    }
