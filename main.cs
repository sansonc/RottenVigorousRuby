using System;

class Program 
{
   static void Main () 
  {
    const double cmperinch = 2.54;
    double inches = 15994;

    double centimeters = inches * cmperinch;
    
    Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
  }
}