// OCP
using SolidPrinciples.LSP;
using SolidPrinciples.OCP;

var circle = new Circle(42);
var circleArea = circle.CalculateArea();
Console.WriteLine($"The area of the circle with radius 42 is {circleArea}");
circle.Draw();

var square = new SolidPrinciples.OCP.Square(42);
var squareArea = square.CalculateArea();
Console.WriteLine($"The square area of the square with side size 42 is {squareArea}");
square.Draw();

// LSP
Rectangle lspRectangle = new Rectangle();
lspRectangle.Width = 10;
lspRectangle.Height = 5;

Console.WriteLine(lspRectangle.GetArea()); // OK

Rectangle lspSquare = new SolidPrinciples.LSP.Square();
lspSquare.Width = 10;
lspSquare.Height = 5;

Console.WriteLine(lspSquare.GetArea()); // Wait, what?!