using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123659", modelo: "Modelo A0796", imei: "25987496879", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "254846546", modelo: "Iphone 12", imei: "649521114165", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");