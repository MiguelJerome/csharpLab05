// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var p1 = new Point();
var p2 = new Point(5);
var p3 = new Point( 2, 5);
var p4 = new Point( 4,6);

p1.Translater(2,3);
Console.WriteLine($"Apres le Translater de p1 est : {p1.ToString()}");
Console.WriteLine($"La distance entre p1 et p3 est : {p1.Distance(p3)}");
Console.WriteLine($"La distance entre p1 le point abcisse = 6 et oronnee = 4 est : {p1.Distance(6,4)}");

// J ai fait les 7 premiere questions de Test

// egualite testing
var p5 =new Point(5,5);
var p6 =new Point(5,5);
var p7 = new Point(1, 120);
Console.WriteLine();
Console.WriteLine($"Les points p5 et p6 : ");
p5.Egualite(p6);

Console.WriteLine();
Console.WriteLine($"Les points p5 et p6 : ");
p5.Egualite(p7);

