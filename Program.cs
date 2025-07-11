using System.ComponentModel;
using DesafioPOO.Models;


Smartphone nokia = new Nokia("91234-5678", "Nokia 3310", "IMEI-NOK-001", 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();


Smartphone iphone = new Iphone("92345-6789", "iPhone 15", "IMEI-IPH-002", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ChatGPT");