using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DZ_13
{
    internal class SaveToFile : Save
    {
        private CreditCard creditCard;

        public SaveToFile(CreditCard card)
        {
            creditCard = card;
        }
        public void Save(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"Номер карти: {creditCard.Number}");
                sw.WriteLine($"Ім'я: {creditCard.Name}");
                sw.WriteLine($"Дата: {creditCard.Data}");
                sw.WriteLine($"Пін-код: {creditCard.Pin}");
                sw.WriteLine($"Баланс: {creditCard.Balance}");
                sw.WriteLine($"Власні кошти: {creditCard.Repl}");
                sw.WriteLine($"Кредитні кошти: {creditCard.CreditLimit}");
            }

            Console.WriteLine($"Інформація записана у файл: {filename}");
        }
        public void Read(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }

}
