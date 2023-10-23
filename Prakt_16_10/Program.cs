using Prakt_16_10;

Console.OutputEncoding = System.Text.Encoding.UTF8;

List<Student> students = new List<Student>
        {
            new Student { FirstName = "Борис", LastName = "Бровко", Age = 21, Uni = "МІТ" },
            new Student { FirstName = "Анна", LastName = "Петренко", Age = 18, Uni = "Оксфорд" },
            new Student { FirstName = "Марія", LastName = "Бродовська", Age = 22, Uni = "МІТ" },
            new Student { FirstName = "Іван", LastName = "Ковальчук", Age = 20, Uni = "Гарвард" },
            new Student { FirstName = "Богдан", LastName = "Савченко", Age = 19, Uni = "МІТ" },
        };

// Запит 1: Отримати весь масив студентів
var allStudents = students;

// Запит 2: Отримати список студентів з ім'ям "Борис"
var borisStudents = students.Where(s => s.FirstName == "Борис").ToList();

// Запит 3: Отримати список студентів з прізвищем, яке починається на "Бро"
var broStudents = students.Where(s => s.LastName.StartsWith("Бро")).ToList();

// Запит 4: Отримати список студентів старших за 19 років
var olderThan19Students = students.Where(s => s.Age > 19).ToList();

// Запит 5: Отримати список студентів, які навчаються у "МІТ"
var mitStudents = students.Where(s => s.Uni == "МІТ").ToList();

// Запит 6: Отримати список студентів старших 20 років і молодших за 23
var between20And23Students = students.Where(s => s.Age > 20 && s.Age < 23).ToList();

// Запит 7: Отримати список студентів, які навчаються у "Оксфорд" і вік яких старше 18 років
var oxfordStudentsOver18 = students.Where(s => s.Uni == "Оксфорд" && s.Age > 18).ToList();

// Сортування за віком у спадаючому порядку
var sortedStudents = students.OrderByDescending(s => s.Age).ToList();

Console.WriteLine("Весь масив студентів:");
PrintStudents(allStudents);

Console.WriteLine("\nСтуденти з ім'ям 'Борис':");
PrintStudents(borisStudents);

Console.WriteLine("\nСтуденти з прізвищем, що починається на 'Бро':");
PrintStudents(broStudents);

Console.WriteLine("\nСтуденти старші за 19 років:");
PrintStudents(olderThan19Students);

Console.WriteLine("\nСтуденти, які навчаються у 'МІТ':");
PrintStudents(mitStudents);

Console.WriteLine("\nСтуденти старші за 20 і молодші за 23 роки:");
PrintStudents(between20And23Students);

Console.WriteLine("\nСтуденти у 'Оксфорд' старші за 18 років (відсортовано за віком у спадаючому порядку):");
PrintStudents(oxfordStudentsOver18);

Console.WriteLine("\nВсі студенти відсортовані за віком у спадаючому порядку:");
PrintStudents(sortedStudents);

static void PrintStudents(IEnumerable<Student> students)
{
    foreach (var student in students)
    {
        Console.WriteLine($"Ім'я: {student.FirstName}, Прізвище: {student.LastName}, Вік: {student.Age}, Навчальний заклад: {student.Uni}");
    }
}