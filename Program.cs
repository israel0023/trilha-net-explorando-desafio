﻿using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
//Reserva reservar = new Reserva();
//reservar.Hospedes = new List<Pessoa>();
List<Pessoa> hospedes = new List<Pessoa>();

 Pessoa p1 = new Pessoa(nome: "Hóspede", sobrenome:"1");
 Pessoa p2 = new Pessoa(nome: "Hóspede", sobrenome: "2" );
 Pessoa p3 = new Pessoa(nome: "Hóspede", sobrenome: "3" );

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);


// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 20);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}"); 