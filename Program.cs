using DesafioPOO.Models;

Nokia nokia = new Nokia("36-632783446", "NK-CKL22", "CKJ3KSJ24NS89", 2);
Iphone iphone = new Iphone("42-836222785", "IP-JK24N", "AKD3KSJ5BNS89", 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Clash Royale");

Console.WriteLine("\n\nMudando para o Iphone...\n\n");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Subway Surfers");
