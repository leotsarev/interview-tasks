using System;
using System.Collections.Generic;

public sealed class Circle
{
  private double radius;

  public Circle(double r)
  {
    radius = r;
  }

  public double Calculate(Func<double, double> op)
  {
    return op(radius);
  }
}

public static class CircleExtensions
{
  IEnumerable<double> GetСircumferences(IEnumerable<Circle> circles)
  {











  }
}
