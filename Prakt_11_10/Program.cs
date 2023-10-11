using Prakt_11_10;

Subscribers sub = new Subscribers("Oleg", 30);

MyButton button = new MyButton("Blue", "Click clac", 5, 10);
button.OnClickButton += MyButton.ButtonClick;

button.Click();
