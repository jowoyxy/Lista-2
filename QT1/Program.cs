/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Contextualização: Em um jogo de RPG, cada classe de personagem (Guerreiro, Arqueiro, Mago)
possui requisitos diferentes para a escolha da armadura ideal. A armadura é considerada ideal
se a defesa oferecida for alta o suficiente para a classe e se a penalidade de agilidade for
aceitável.
• Comando:
Crie um programa que receba a classe do personagem, o valor de defesa da armadura e a
penalidade de agilidade. O programa deve informar se a armadura é adequada ou não para a
classe.
• Para o Guerreiro, a defesa deve ser maior que 50 e a penalidade de agilidade menor que 20.
• Para o Arqueiro, a defesa deve ser maior que 30 e a penalidade de agilidade menor que 10.
• Para o Mago, a defesa deve ser maior que 20 e a penalidade de agilidade menor que 40.
@Lista: 02 - Condicionais
@Autor: Joanna Nobre
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a classe do personagem (Guerreiro, Arqueiro, Mago):");
        string? inputClasse = Console.ReadLine();
        
        if (string.IsNullOrEmpty(inputClasse))
        {
            Console.WriteLine("Classe inválida. A entrada não pode ser nula ou vazia.");
            return;
        }
        
        string classe = inputClasse.Trim().ToLower();

        if (classe != "guerreiro" && classe != "arqueiro" && classe != "mago")
        {
            Console.WriteLine("Classe inválida. Por favor, insira uma classe válida (Guerreiro, Arqueiro, Mago).");
            return;
        }

        Console.WriteLine("Digite o valor de defesa da armadura:");
        if (!int.TryParse(Console.ReadLine(), out int defesa))
        {
            Console.WriteLine("Valor inválido para defesa. Por favor, insira um número inteiro.");
            return;
        }

        Console.WriteLine("Digite o valor da penalidade de agilidade:");
        if (!int.TryParse(Console.ReadLine(), out int penalidadeAgilidade))
        {
            Console.WriteLine("Valor inválido para penalidade de agilidade. Por favor, insira um número inteiro.");
            return;
        }

        bool armaduraAdequada = classe switch
        {
            "guerreiro" => defesa > 50 && penalidadeAgilidade < 20,
            "arqueiro" => defesa > 30 && penalidadeAgilidade < 10,
            "mago" => defesa > 20 && penalidadeAgilidade < 40,
            _ => false
        };

        Console.WriteLine(armaduraAdequada ? "Armadura adequada" : "Armadura não adequada");

        Console.WriteLine("Aperte ENTER para fechar: ");
        Console.ReadLine();
    }
}
