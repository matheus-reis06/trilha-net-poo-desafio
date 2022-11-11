using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia 3310:");
Nokia nokia = new Nokia(numero: "1111111", modelo:"Nokia 3310", imei: "121212121212", memoria: 2);
nokia.Ligar();
nokia.InstalarAplicativo("Tone Editor");

Console.WriteLine("----------------------------------------------");

Console.WriteLine("Iphone 4:");
Iphone iphone = new Iphone(numero: "2222222", modelo:"Iphone 4", imei: "343434343434", memoria: 16);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

