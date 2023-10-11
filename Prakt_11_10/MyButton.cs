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

        public event Action OnClickButton;

        public void Click()
        {
            Console.WriteLine("Button was clicked");
            OnClickButton?.Invoke();
        }

        internal static void ButtonClick()
        {
            Console.WriteLine("Button on click");
        }
    }
}
