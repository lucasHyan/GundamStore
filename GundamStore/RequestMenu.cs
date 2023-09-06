using System;

namespace GundamStore
{
    internal class RequestMenu
    {
        public static void StartRequestMenu()
        {
            ItemRequest itemRequest = new ItemRequest();
            bool exit = false;
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
                Console.WriteLine("(1) Adicionar Gundam MG ZETA MSZ-006 1/100 MODEL KIT. (R$99.99)");
                Console.WriteLine("(2) Adicionar Mobile Suit Gundam EG RX-78-2 1/144 MODEL KIT. (R$30.00)");
                Console.WriteLine("(3) Adicionar Zaku II HG 1/144 MODEL KIT. (R$75.50)");
                Console.WriteLine("(4) Menu principal.");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine() ?? "0");

                    switch (choice)
                    {
                        case 1:
                            itemRequest.AddZeta();
                            break;
                        case 2:
                            itemRequest.AddGundam();
                            break;
                        case 3:
                            itemRequest.AddZaku();
                            break;
                        case 4:
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
                    Console.WriteLine("Opção inválida. Por favor, Digite um número.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
