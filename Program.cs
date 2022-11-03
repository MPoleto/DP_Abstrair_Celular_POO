using DesafioPOO.Models;

Console.WriteLine("Iphone");
Smartphone iphone12 = new Iphone("988349743", "Iphone 12", "5641987129687", 64);
iphone12.Ligar();
iphone12.ReceberLigacao();
Console.WriteLine(iphone12.Numero);
iphone12.InstalarAplicativo("Notion.so");

Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

Console.WriteLine("Nokia");
Smartphone nokiaC30 = new Nokia("994857731", "Nokia C30  ", "9871987198736", 64);
nokiaC30.Ligar();
nokiaC30.ReceberLigacao();
nokiaC30.Numero = "992047593";
Console.WriteLine("Trocando o número para " + nokiaC30.Numero);
nokiaC30.InstalarAplicativo("Ifood");


