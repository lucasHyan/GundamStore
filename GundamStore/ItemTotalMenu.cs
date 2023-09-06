using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GundamStore
{
    internal class ItemTotalMenu
    {
        public static void RequestTotalMenu()
        {
            ItemRequest pedido = new ItemRequest();
            bool exit = false;
            int NumberRequestZeta = ItemRequest.QuantityZeta;
            int NumberRequestGundam = ItemRequest.QuantityGundam;
            int NumberRequestZaku = ItemRequest.QuantityZaku;
            double Total = pedido.CalculateTotal();
            string textToEnter = @"

 _____                    _                     _____  _                     _  _ 
|  __ \                  | |                   /  ___|| |                   | || |
| |  \/ _   _  _ __    __| |  __ _  _ __ ___   \ `--. | |_  ___   _ __  ___ | || |
| | __ | | | || '_ \  / _` | / _` || '_ ` _ \   `--. \| __|/ _ \ | '__|/ _ \| || |
| |_\ \| |_| || | | || (_| || (_| || | | | | | /\__/ /| |_| (_) || |  |  __/|_||_|
 \____/ \__,_||_| |_| \__,_| \__,_||_| |_| |_| \____/  \__|\___/ |_|   \___|(_)(_)
                                                                                  
                                                                                  

                           
 ";


            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(textToEnter);

                if (NumberRequestGundam > 0 || NumberRequestZaku > 0 || NumberRequestZeta > 0)
                {
                    Console.WriteLine("O número do seu pedido é: " + pedido.RequestNumber);

                }
                else
                {
                    Console.WriteLine("Você não adicionou nenhum item ao pedido.");
                }
                if (Total > 100)
                {
                    double TotalDiscount = Total * 0.9;
                    Console.WriteLine("O valor total do seu pedido é: R$" + TotalDiscount.ToString("F2") + " (com desconto de 10% aplicado)");
                }
                else if (Total < 100)
                {
                    Console.WriteLine("O valor total do seu pedido é: R$" + Total);
                }

                if (NumberRequestZeta > 0)
                {
                    Console.WriteLine("Gundam MG ZETA MSZ-006 1/100 MODEL KIT. (R$99.99):" + NumberRequestZeta + " unidades");
                }

                if (NumberRequestGundam > 0)
                {
                    Console.WriteLine("Mobile Suit Gundam EG RX-78-2 1/144 MODEL KIT. (R$30.00): " + NumberRequestGundam + " unidades");
                }

                if (NumberRequestZaku > 0)
                {
                    Console.WriteLine("Zaku II HG 1/144 MODEL KIT. (R$75.50):" + NumberRequestZaku + " unidades");
                }

                try
                {
                    Console.WriteLine("(1) Voltar ao menu principal.");

                    int choice = Convert.ToInt32(Console.ReadLine() ?? "0");

                    switch (choice)
                    {
                        case 1:
                            exit = true;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
