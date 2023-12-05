using System;

// Component interface
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

// Concrete Component
public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 2.0;
    }
}

// Decorator abstract class
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }
}

// Concrete Decorator 1
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, with Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}

// Concrete Decorator 2
public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, with Sugar";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.2;
    }
}

class Program
{
    static void Main()
    {
        // Creating a simple coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

        // Decorating the coffee with Milk
        ICoffee milkCoffee = new MilkDecorator(coffee);
        Console.WriteLine($"Description: {milkCoffee.GetDescription()}, Cost: ${milkCoffee.GetCost()}");

        // Decorating the coffee with Sugar
        ICoffee sweetCoffee = new SugarDecorator(milkCoffee);
        Console.WriteLine($"Description: {sweetCoffee.GetDescription()}, Cost: ${sweetCoffee.GetCost()}");
    }
}