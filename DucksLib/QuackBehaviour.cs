namespace DucksLib;

public abstract class QuackBehaviour : IQuackBehaviour
{
    public abstract void Quack(IQuackState quackState);
    
}
