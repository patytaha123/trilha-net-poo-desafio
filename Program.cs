using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
﻿using DesafioPOO.Models;

Iphone iphone = new Iphone(numero:"219817172",imei:"21",modelo:"Iphone 10",memoria:20);
Nokia nokia = new Nokia(numero: "21921092", imei: "21", modelo: "Nokia tijolão", memoria: 10);

nokia.instalarAplicativo(nomeApp: "WhatsApp");
nokia.receberLigacao();
nokia.ligar();
iphone.instalarAplicativo(nomeApp: "WhatsApp");
iphone.receberLigacao();
iphone.ligar();