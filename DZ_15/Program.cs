using DZ_15;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
MyArray myArray = new MyArray(numbers);

int[] allIntegers = myArray.GetAllIntegers();
int[] evenNumbers = myArray.GetEvenNumbers();
int[] oddNumbers = myArray.GetOddNumbers();
int value = 5;
int[] numbersGreaterThanValue = myArray.GetNumbersGreaterThan(value);
int start = 3;
int end = 8;
int[] numbersInRange = myArray.GetNumbersInRange(start, end);
int[] multiplesOfSeven = myArray.GetMultiplesOfSevenAscending();
int[] multiplesOfEight = myArray.GetMultiplesOfEightDescending();

Console.WriteLine("Усі цілі числа: " + string.Join(", ", allIntegers));
Console.WriteLine("Парні числа: " + string.Join(", ", evenNumbers));
Console.WriteLine("Непарні числа: " + string.Join(", ", oddNumbers));
Console.WriteLine("Числа більше ніж " + value + ": " + string.Join(", ", numbersGreaterThanValue));
Console.WriteLine("Числа в діапазоні " + start + " - " + end + ": " + string.Join(", ", numbersInRange));
Console.WriteLine("Кратні семи (Висхідний): " + string.Join(", ", multiplesOfSeven));
Console.WriteLine("Кратні восьми (Низхідний): " + string.Join(", ", multiplesOfEight));
