using System;

class Program 
{
   static void Main () 
  {
    const double cmperinch = 2.54;
    double inches = 5;

    double centimeters = inches * cmperinch;
    
    Console.WriteLine($"{centimeters} centimeters.");
  }
}