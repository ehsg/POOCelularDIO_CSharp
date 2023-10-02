using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "3350", imei: "77777", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Fotos");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "987654", modelo: "15", imei: "999999", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Banco");