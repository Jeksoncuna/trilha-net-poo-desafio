using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia : ");
Smartphone nokia =  new Nokia(numero: "1234", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "2314", modelo: "Modelo 12", imei: "1132111", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");