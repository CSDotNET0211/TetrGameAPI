// See https://aka.ms/new-console-template for more information

using TetrGameAPI;

var token=File.ReadAllText("../../../token.txt");
Console.WriteLine(token);
var api = new API(token);
Console.WriteLine("Hello, World!");
Console.ReadKey();