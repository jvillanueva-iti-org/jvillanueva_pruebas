class Car 
{
  string color = "red";

  static void Main(string[] args)
  {
    var a = double.NaN;

    if (a == double.NaN) // Noncompliant; always false
    {
      Console.WriteLine("a is not a number");  // this is dead code
    }
    if (a != double.NaN)  // Noncompliant; always true
    {
      Console.WriteLine("a is not NaN"); // this statement is not necessarily true
    }
    
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
  }
}
