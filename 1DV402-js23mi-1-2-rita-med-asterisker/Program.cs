using System;
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
            do
            {
                Console.WriteLine("Funkar");
            } while (IsContinuing());
        }

        /// <summary>
        ///     Presterar meddelande som frågar ifall skriptet ska fortsättas
        /// </summary>
        /// <returns> Retunerar en bool som säger ifall skriptet ska fortsättas</returns>
        static bool IsContinuing() {
            ViewMessage(Properties.Resources.Continue_Prompt);
            return Console.ReadKey(true).Key != ConsoleKey.Escape;
        }
      
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        static byte ReadOddByte(string prompt = null, byte maxValue = 255) {
         
            throw new Exception();       
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxCount"></param>
        static void RenderDiamond(byte maxCount) { 
        
        
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxCount"></param>
        /// <param name="asteriskCount"></param>
        static void RenderRow(int maxCount,int asteriskCount)
        {


        }


        /// <summary>
        /// Vissar meddelande för användaren
        /// </summary>
        /// <param name="message">Medelandet som ska visas</param>
        /// <param name="isError">Väljer färg på meddelandet</param>
        private static void ViewMessage(string message, bool isError = false)
        {
            if (isError)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.WriteLine("\n {0}", message);
            Console.ResetColor();
        }
    
    
    
    
    }
}
