using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamStore
{
    internal class MainMenu
    {
        public static void StartMenu()
        {
            bool exit = false;
            int opcao;

            while (!exit)
            {
                string textToEnter = @"

 _____                    _                     _____  _                     _  _ 
|  __ \                  | |                   /  ___|| |                   | || |
| |  \/ _   _  _ __    __| |  __ _  _ __ ___   \ `--. | |_  ___   _ __  ___ | || |
| | __ | | | || '_ \  / _` | / _` || '_ ` _ \   `--. \| __|/ _ \ | '__|/ _ \| || |
| |_\ \| |_| || | | || (_| || (_| || | | | | | /\__/ /| |_| (_) || |  |  __/|_||_|
 \____/ \__,_||_| |_| \__,_| \__,_||_| |_| |_| \____/  \__|\___/ |_|   \___|(_)(_)
                                                                                  
                                                                                  

                           
 ";
                Console.WriteLine(textToEnter);

                Console.WriteLine("(1) Adicionar um item ao pedido.");
                Console.WriteLine("(2) Mostrar os itens e o valor total a pagar.");
                Console.WriteLine("(3) Sair do programa");

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine() ?? "0");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                switch (opcao)
                {
                    case 1:
                        RequestMenu.StartRequestMenu();
                        break;
                    case 2:
                        ItemTotalMenu.RequestTotalMenu();
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, insira um número valido.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            Console.WriteLine("Saindo do programa.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
