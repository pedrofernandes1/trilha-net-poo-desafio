using DesafioPOO.Models;

Console.WriteLine("Smarthphone Nokia:");
Nokia nokia = new Nokia(numero: "123546", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smarthphone Iphone:");
Iphone iphone = new Iphone (numero: "495865", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
