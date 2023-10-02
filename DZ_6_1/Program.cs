using DZ_6_1;
using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;
Kettle kettle = new Kettle("Чайник", "Об'єм: 2 літра");
Microwave microwave = new Microwave("Мікрохвильовка", "Потужність: 800 Вт");
Car car = new Car("Автомобіль", "Чорний");
Steamer steamship = new Steamer("Пароплав", "Тоннаж: 1000 тонн");

kettle.Show();
kettle.Sound();
kettle.Desc();

microwave.Show();
microwave.Sound();
microwave.Desc();

car.Show();
car.Sound();
car.Desc();

steamship.Show();
steamship.Sound();
steamship.Desc();
