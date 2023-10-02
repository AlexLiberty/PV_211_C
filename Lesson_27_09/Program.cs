using Lesson_27_09;

Transport tr = new Car();
tr.Move(); 
Console.WriteLine(tr);

Person person = new Person() { Name="Oleg"};//{ Name="null"}
person.Name = "Bogdan";
Console.WriteLine(person);

tr=new Bike();
tr.Move();



 

