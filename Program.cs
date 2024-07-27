using DesafioPOO.Models;

Iphone i14 = new Iphone("9999-9999", "Iphone 14", "123456", 128);
Console.WriteLine(i14);
i14.Ligar();
i14.ReceberLigacao();
i14.InstalarAplicativo("Whatsapp");

Nokia n1 = new Nokia("8888-8888", "Nokia 5200", "654321", 64);
Console.WriteLine(n1);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Telegram");
