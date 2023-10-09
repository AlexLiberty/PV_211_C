Console.OutputEncoding = System.Text.Encoding.UTF8;

ShowMessage showMessageObj = new ShowMessage("ShowMessage.");

MessageDelegate showMessage = showMessageObj.DisplayMessage;

showMessage("Це перше повідомлення через делегат.");
showMessage("А це друге повідомлення через делегат.");

Console.ReadKey();
