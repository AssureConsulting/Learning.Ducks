namespace DucksLib
{
    public interface IDuck : IFlyingState, IQuackState
    {
        string Display { get; }

        void Fly();
        void Quack();
        void Swim();
    }
}