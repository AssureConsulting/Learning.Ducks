using Savaged.Info.Ducks;

namespace DucksTest;

public class DucksLibTests
{
    private MallardDuck? _mallardDuck;
    private DecoyDuck? _decoyDuck;
    private RubberDuck? _rubberDuck;
    
    [SetUp]
    public void Setup()
    {
        _mallardDuck = new MallardDuck();
        _decoyDuck = new DecoyDuck();
        _rubberDuck = new RubberDuck();
    }

    [Test]
    public void TestDisplay()
    {
        Assert.That(_mallardDuck?.Display, Is.EqualTo("I'm a Mallard duck"));
        Assert.That(_decoyDuck?.Display, Is.EqualTo("I'm a decoy duck"));
        Assert.That(_rubberDuck?.Display, Is.EqualTo("I'm a rubber duck"));
    }

    [Test]
    public void TestQuacks()
    {
        Assert.That(_mallardDuck?.QuackState, Is.Null);
        _mallardDuck?.Quack();
        Assert.That(_mallardDuck?.QuackState, Is.EqualTo("Quack"));
        
        Assert.That(_decoyDuck?.QuackState, Is.Null);
        _decoyDuck?.Quack();
        Assert.That(_decoyDuck?.QuackState, Is.EqualTo("Silence"));
        
        Assert.That(_rubberDuck?.QuackState, Is.Null);
        _rubberDuck?.Quack();
        Assert.That(_rubberDuck?.QuackState, Is.EqualTo("Squeak"));
    }
    
    [Test]
    public void TestFlights()
    {
        Assert.That(_mallardDuck?.FlyingState, Is.Null);
        _mallardDuck?.Fly();
        Assert.That(_mallardDuck?.FlyingState, Is.EqualTo("Flying with wings"));
        
        Assert.That(_decoyDuck?.FlyingState, Is.Null);
        _decoyDuck?.Fly();
        Assert.That(_decoyDuck?.FlyingState, Is.EqualTo("Nothing"));
        
        Assert.That(_rubberDuck?.FlyingState, Is.Null);
        _rubberDuck?.Fly();
        Assert.That(_rubberDuck?.FlyingState, Is.EqualTo("Nothing"));
    }
    
