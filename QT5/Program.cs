﻿/*-------------------------------------------------------------------
Questão 5: Resgate no Labirinto
• Contextualização: Em uma missão de resgate em um jogo, o jogador deve decidir se continua
em frente para resgatar um aliado ou recua, considerando a vida restante, o número de
armadilhas conhecidas no caminho e a distância do aliado.
• Comando: Crie um programa que receba a porcentagem de vida do jogador, o número de
armadilhas conhecidas no caminho e a distância do aliado em metros. O programa deve decidir
se o jogador deve seguir em frente, tentar um resgate rápido, ou recuar, conforme as seguintes
condições:
• Se a vida for maior que 50% e as armadilhas forem menores que 3, seguir em frente.
• Se a vida for menor que 50%, as armadilhas forem menores que 2, e a distância do aliado for
menor que 10m, tentar resgate rápido.
• Caso contrário, recuar.


@Lista: 02 - Condicionais
@Autor: Joanna Nobre
@Data: 25/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main()
    {
        double vida = ObterValorDecimal("Digite a vida atual do personagem, em porcentagem (0 a 100): ");
        int armadilhas = ObterValorInteiro("Digite a quantidade de armadilhas conhecidas: ");
        int distancia = ObterValorInteiro("Digite a distância do aliado, em metros: ");

        if (vida > 50 && armadilhas < 3)
        {
            Console.WriteLine("Seguir em frente");
        }
        else if (vida < 50 && armadilhas < 2 && distancia < 10)
        {
            Console.WriteLine("Tentar resgate rápido");
        }
        else
        {
            Console.WriteLine(" RECUAR!!!!!");
        }

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }

    static int ObterValorInteiro(string mensagem)
    {
        int valor;
        Console.Write(mensagem);
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida. Insira um número inteiro.");
            Console.Write(mensagem);
        }
        return valor;
    }

    static double ObterValorDecimal(string mensagem)
    {
        double valor;
        Console.Write(mensagem);
        while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0 || valor > 100)
        {
            Console.WriteLine("Entrada inválida. Insira um valor decimal entre 0 e 100.");
            Console.Write(mensagem);
        }
        return valor;
    }
}
