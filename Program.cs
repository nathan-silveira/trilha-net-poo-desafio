using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone cel1 = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
cel1.Ligar();
cel1.InstalarAplicativo("Facebook");

Smartphone cel2 = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
cel2.Ligar();
cel2.InstalarAplicativo("Facebook");