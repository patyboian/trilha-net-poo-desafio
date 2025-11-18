using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone ("123", "123", "123", 28);
iphone.Ligar();
iphone.InstalarAplicativo("Wpp");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia ("321", "321", "321", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo");