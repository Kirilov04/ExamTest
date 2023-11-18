﻿    // · On the first line – quantity food in kilograms - a floating-point number in the range [0.0…10000.0].
    //
    // · On the second line – quantity hay in kilograms - a floating-point number in the range [0.0…10000.0].
    //
    // · On the third line – quantity cover in kilograms - a floating-point number in the range [0.0…10000.0].
    //
    // · On the fourth line – guinea's weight in kilograms - a floating-point number in the range [0.0…10000.0].


double food = double.Parse(Console.ReadLine()) * 1000;
double hay = double.Parse(Console.ReadLine()) * 1000;
double cover = double.Parse(Console.ReadLine()) * 1000;
double weight = double.Parse(Console.ReadLine()) * 1000;


for (int day = 1; day <= 30; day++)
{
    food -= 300;

    if (day % 2 == 0)
    {
        double hayAmount = food * 0.05;
        hay -= hayAmount;
    }

    if (day % 3 == 0)
    {
        double coverAmount = weight / 3;

        cover -= coverAmount;
    }

    if (food <= 0 || hay <= 0 || weight <= 0)
    {
        Console.WriteLine("Merry must go to the pet store!");
        return;
    }
    
}
Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(food / 1000):F2}, Hay: {(hay / 1000):F2}, Cover: {(cover / 1000):F2}");
