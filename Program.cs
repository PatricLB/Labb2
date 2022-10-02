// See https://aka.ms/new-console-template for more information

using Shapes;
using System.Numerics;

Vector2 vec2 = new Vector2();
vec2.X = 2.0f;
vec2.Y = 1.0f;

Console.WriteLine(vec2);



Circle cirkel = new Circle(vec2, 4);
Console.WriteLine($"Omkretsen är: {cirkel.Circumference}");
Console.WriteLine($"Arean är: {cirkel.Area}");

Console.WriteLine(new Circle(new Vector2(3.0f, 4.0f), 2.0f));

