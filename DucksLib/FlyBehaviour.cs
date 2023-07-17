namespace Savaged.Info.Ducks;

public abstract class FlyBehaviour : IFlyBehaviour
{
    public abstract void Fly(IFlyingState flyingState);
    
