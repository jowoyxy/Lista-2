/*-------------------------------------------------------------------
Questão 4: Decisão de Ataque Especial
• Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
• Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
• Mana maior que 30.
• Vida do inimigo menor que 50%.
• Nível do jogador maior que 5.


@Lista: 02 - Condicionais
@Autor: Joanna Nobre
@Data: 25/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main()
    {
        int mana = ObterValor("Digite a quantidade de mana que você tem atualmente: ");
        double vidaInimigo = ObterValorDecimal("Digite a vida do inimigo em porcentagem (0 a 100): ");
        int nivel = ObterValor("Digite o seu nível atual: ");

        if (mana > 30 && vidaInimigo < 50 && nivel > 5)
        {
            Console.WriteLine("Ataque Especial Realizado");
        }
        else
        {
            if (mana <= 30)
                Console.WriteLine("Mana Insuficiente");
            else if (vidaInimigo >= 50)
                Console.WriteLine("Vida do inimigo muito alta");
            else if (nivel <= 5)
                Console.WriteLine("Nível Insuficiente");
        }

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }

    static int ObterValor(string mensagem)
    {
        int valor;
        Console.Write(mensagem);
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
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
            Console.WriteLine("Entrada inválida. Por favor, insira um valor decimal entre 0 e 100.");
            Console.Write(mensagem);
        }
        return valor;

    }
}