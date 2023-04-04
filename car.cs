class Car 
{
  string color = "red";
  
   public void DoStuff([Optional][DefaultValue(4)]int i, int j = 5)  // Noncompliant
    {
        Console.WriteLine(i);
    }

  static void Main(string[] args)
  {
    Car myObj = new Car();
    Console.WriteLine(myObj.color);
    
    int target = -5;
    int num = 3;

    target =- num;  // Noncompliant; target = -3. Is that really what's meant?
    target =+ num; // Noncompliant; target = 3
  }
}
