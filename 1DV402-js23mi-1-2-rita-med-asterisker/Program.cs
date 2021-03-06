﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402_js23mi_1_2_rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte maxValue = 79;
            do
            {
                RenderDiamond(ReadOddByte(string.Format(Properties.Resources.Ask_Count, maxValue), maxValue));

            } while (IsContinuing());
        }

        /// <summary>
        ///     Presterar meddelande som frågar ifall skriptet ska fortsättas
        ///     
        /// (EXTRA) Lagt till så den renasr och resetar höjden på consolen
        /// </summary>
        /// <returns> Retunerar en bool som säger ifall skriptet ska fortsättas</returns>
        static bool IsContinuing() {
            bool stop;
            ViewMessage(Properties.Resources.Continue_Prompt);
            stop = Console.ReadKey(true).Key != ConsoleKey.Escape;
            if (stop)
            {
                Console.Clear();
                Console.WindowHeight = 25;

            }
            return stop;
        }
      
        
        /// <summary>
        ///  Frågar användaren efter ett värde och därefter berabetas värdet och det säkerställs att värdet är korrekt för programet
        /// </summary>
        /// <param name="prompt"> Texten som skrivs ut till användaren för att be hen mata in ett värde</param>
        /// <param name="maxValue">Det högsta värdet som användaren kan mata in från början är det 255</param>
        /// <returns></returns>
        static byte ReadOddByte(string prompt = null, byte maxValue = 255) {
            byte value;
            string text;
            while (true) {
            Console.Write(prompt);
            text = Console.ReadLine();

                try
                {
                    value = byte.Parse(text);
                    if (value % 2 == 0 || value > maxValue || value < 1)
                        throw new Exception();
                    return value;
                }
                catch {
                    ViewMessage(string.Format(Properties.Resources.Error_Message, text), true);
                }
            }

        }

        /// <summary>
        ///  Renderar diamanten genom 2 for loppar den första hanterar den över delen och den nedre for loppen renderar den nere delen av diamenten 
        ///  
        /// (EXTRA) Lagt till så att rutan blir störe så diamanten får plats och så rutan ändrar storleken igen efter 3sekunder
        /// </summary>
        /// <param name="maxCount">bredden på diamantens mitt</param>
        static void RenderDiamond(byte maxCount) 
        {

            if (maxCount == 1) {
                Console.WriteLine();
                Console.WriteLine(Properties.Resources.Ask_Mats);
                return;
            }
            if (maxCount >= 79)
                Console.WindowHeight = 82;
            else
                Console.WindowHeight = maxCount + 4;

            for ( byte amountAsterisk = 1; amountAsterisk < maxCount; amountAsterisk += 2) 
                RenderRow(maxCount, amountAsterisk);
            
            for (int amountAsterisk = maxCount; amountAsterisk >= 0 ; amountAsterisk -= 2)
                RenderRow(maxCount, amountAsterisk);

        }
        
        
        
        /// <summary>
        /// Renderar en rad
        /// </summary>
        /// <param name="maxCount">Högsta anatalet</param>
        /// <param name="asteriskCount">Antalet asterisker</param>
        static void RenderRow(int maxCount,int asteriskCount)
        {
            Console.WriteLine("");
            for (int rowPosition = 0; rowPosition < maxCount; rowPosition++)
            {
                if (maxCount == asteriskCount || rowPosition >= maxCount / 2 - asteriskCount / 2 && rowPosition <= maxCount / 2 + asteriskCount / 2)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
        
        }


        /// <summary>
        /// Vissar meddelande för användaren
        /// </summary>
        /// <param name="message">Medelandet som ska visas</param>
        /// <param name="isError">Väljer färg på meddelandet</param>
        private static void ViewMessage(string message, bool isError = false)
        {
            if (isError)
                Console.BackgroundColor = ConsoleColor.Red;
            else
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n {0}", message);
            Console.ResetColor();
        }

    
    
    
    }
}
