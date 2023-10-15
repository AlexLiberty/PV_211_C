using Lesson_12_10;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

//string payhToFile = "product.json";
//Product prod1 = new Product("Apple", 1.54f, 5);

//string json=JsonConvert.SerializeObject(prod1);
//Console.WriteLine(json);
//File.WriteAllText(payhToFile, json);

//string content = File.ReadAllText(payhToFile);
//Product prod2=JsonConvert.DeserializeObject<Product>(content);
//Console.WriteLine(prod2);

int[] arr = new int[] {1,2,3,4,5 };
Product prod3=new Product("Apple", 1.54f, 5, arr);

//using (FileStream fs = new FileStream("product.bin", FileMode.Create))
//{
//    BinaryFormatter bf = new BinaryFormatter();
//#pragma warning disable SYSLIB0011 // Type or member is obsolete
//    bf.Serialize(fs, prod3);
//#pragma warning restore SYSLIB0011 // Type or member is obsolete
//    fs.Close();
//}

using (FileStream fs = new FileStream("product.bin", FileMode.Open))
{
    BinaryFormatter bf = new BinaryFormatter();

#pragma warning disable SYSLIB0011 // Type or member is obsolete
    Product obj = (Product)bf.Deserialize(fs);
#pragma warning restore SYSLIB0011 // Type or member is obsolete

    Console.WriteLine(obj);

    foreach (var el in obj.ints)
    {
        Console.WriteLine(el);
    }

}



