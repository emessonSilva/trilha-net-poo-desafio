using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone (checked)
Console.WriteLine("\n");

Console.WriteLine("Smartphone - Nokia:");
Smartphone nokia = new Nokia(numero: "(81)912345678", modelo: "Modelo POO", imei: "987654-98-987654-9", memoria: 236);
nokia.Ligar();
nokia.InstalarAplicativo("Wild Rift");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone - iPhone:");
Smartphone iphone = new Iphone(numero: "(81)909876543", modelo: "Modelo CTOR", imei: "123456-12-123456-1", memoria: 512);
iphone.InstalarAplicativo("Call Of Duty");
iphone.ReceberLigacao();



