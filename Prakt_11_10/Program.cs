using Prakt_11_10;

Subscribers sub = new Subscribers("Oleg", 30);

MyButton button = new MyButton("Blue", "Click Me", 40, 100);
button.OnClickButton += MyButton.ButtonClick;

button.Click(sub);
