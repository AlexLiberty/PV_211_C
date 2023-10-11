using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_11_10
{
    internal class MyButton
    {
        public string Color {  get; set; }
        public string Text { get; set; }
        public int Рeight {  get; set; }
        public int Weight {  get; set; }
        public MyButton(string color,string text,int peight, int weight) 
        {
            Color = color;  
            Text = text;
            Рeight= peight;
            Weight = weight;
        }

        public event Action<Subscribers,string, string, int, int> OnClickButton;

        public void Click(Subscribers subscriber)//подія
        {
            Console.WriteLine("Button was clicked");
            OnClickButton?.Invoke(subscriber, Color, Text, Рeight, Weight);
        }

        public void ButtonClick(Subscribers subscriber, string color, string text, int peight, int weight)//дія
        {
            Console.WriteLine($"Button Color: {Color}, Text: {Text}, Height: {Рeight}, Weight: {Weight} on click for {subscriber.Name}, Age: {subscriber.Age}");
        }
    }
}
