class Car 
{
  string color = "red";
  
  sadasdasd

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
