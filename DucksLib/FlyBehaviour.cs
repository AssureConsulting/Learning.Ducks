namespace DucksLib;

public abstract class FlyBehaviour : IFlyBehaviour
{
    public abstract void Fly(IFlyingState flyingState);
    
}
