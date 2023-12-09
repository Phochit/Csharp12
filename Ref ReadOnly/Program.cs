using System.Drawing;

class Program
{
    record struct Point(decimal X, decimal Y, decimal Z);
    void Main()
    {
        Point p = new(4.5m, 7.31m, -1.3m);
        In(p);
        RefReadonly(ref p);
    }

    void In(in Point value)
    {
        Console.WriteLine(value);
        // value.X++;   // not allowed
    }

    void RefReadonly(ref readonly Point value)
    {
        Console.WriteLine(value);
        // value.X++;   // not allowed
    }

    // In both cases, variable p is passed to the method efficiently - without creating a copy.
    // In other words, variables 'p' and 'value' end up referring to the same memory location.

    // But now consider what happens when you pass a constant or expression into the methods
    // instead of a variable:

    void InefficientIn()
    {
        In(new Point(4.5m, 7.31m, -1.3m));
    }

    //// Because the expression is not backed by a memory location, the compiler must copy the struct
    //// (passing by value). The code still works, but we miss out on the optimization that we set out
    //// to achieve. Now, let's try the same thing with ref readonly:

    void InefficientRefReadonly()
    {
        RefReadonly(new Point(4.5m, 7.31m, -1.3m));   // Generates a warning
    }

    //// Again it works, but the compiler now generates a warning.
    //// This is the main advantage of 'ref readonly' over 'in'.

    //// The compiler also generates a warning when you call a 'ref readonly' method without the 'ref' modifier.

    void OptionalOrNot()
    {
        Point p = new(4.5m, 7.31m, -1.3m);

        In(in p);  // OK 
        In(p);     // OK (still passes by reference)

        RefReadonly(ref p);     // OK
        RefReadonly(p);         // Works (still passes by reference) - but generates a warning
    }

    // To make it easy to refactor existing 'in' parameters into 'ref readonly' parameters,
    // you can call 'ref readonly' methods with the old 'in' annotation:

    void Transition()
    {
        Point p = new(4.5m, 7.31m, -1.3m);
        RefReadonly(in p);
    }
}