using DZ_8_1;

Console.OutputEncoding = System.Text.Encoding.UTF8;

MyArray array = new MyArray(5);

array[0] = 1;
array[1] = 2;
array[2] = 3;
array[3] = 4;
array[4] = 5;

array.Print();

int valueToCompare = 5;

int lessCount = array.Less(valueToCompare);
int greaterCount = array.Greater(valueToCompare);

Console.WriteLine($"Кількість елементів менших за {valueToCompare}: {lessCount}");
Console.WriteLine($"Кількість елементів більших за {valueToCompare}: {greaterCount}");

array.ShowEven();
array.ShowOdd();


