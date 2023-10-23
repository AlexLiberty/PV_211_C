using Lesson_18_10;
using System.Runtime.InteropServices;
using System.Xml;

//XmlDocument doc=new XmlDocument();
////кореневий елемент, може бути тільки один
//XmlElement root=doc.CreateElement("Library");
//doc.AppendChild(root);

//XmlElement elBook1 = doc.CreateElement("Book");
//elBook1.SetAttribute("Genre","Genre_1");

//elBook1.InnerText="Book 1";
//root.AppendChild(elBook1);

//XmlElement title1=doc.CreateElement("title");
//title1.InnerText="Book_1";
//elBook1.AppendChild(title1);

//XmlElement autor1 = doc.CreateElement("autor");
//autor1.InnerText = "Autor_1";
//elBook1.AppendChild(autor1);

//XmlElement year1 = doc.CreateElement("autor");
//year1.InnerText = "Autor_1";
//elBook1.AppendChild(year1);


//doc.Save("Library.xml");
//Console.ReadLine();

//XmlDocument doc = new XmlDocument();
//Створення root-element
//XmlElement root = doc.CreateElement("Library");
//doc.AppendChild(root);
//string title = Console.ReadLine();
//string genre = Console.ReadLine();
//string author = Console.ReadLine();
//short year = Convert.ToInt16(Console.ReadLine());
//XmlElement elBook1 = CreateBook(doc, genre, title, author, year);
//root.AppendChild(elBook1);
//doc.Save("Library.xml");
//Console.ReadLine();    

//List<Book> list = new List<Book>();
//list.Add(GetBook());
//list.Add(GetBook());
//XmlDocument doc = new XmlDocument();
////Створення root-element
//XmlElement root = doc.CreateElement("Library");
//doc.AppendChild(root);
//foreach (var book in list)
//{
//    root.AppendChild(CreateBook(doc, book));
//}

//doc.Save("Library.xml");
//Console.ReadLine();

//static XmlElement CreateBook(XmlDocument doc, Book b)
//{
//    XmlElement elBook1 = doc.CreateElement("Book");

//    //XmlAttribute genreAttr = doc.CreateAttribute("genre");
//    //genreAttr.Value = "genre_1";
//    //elBook1.Attributes.Append(genreAttr);

//    elBook1.SetAttribute("genre", b.Genre);

//    XmlElement title1 = doc.CreateElement("Title");
//    title1.InnerText = b.Title;
//    elBook1.AppendChild(title1);
//    XmlElement author1 = doc.CreateElement("Author");
//    author1.InnerText = b.Author;
//    elBook1.AppendChild(author1);
//    XmlElement year1 = doc.CreateElement("Year");
//    year1.InnerText = Convert.ToString(b.Year);
//    elBook1.AppendChild(year1);
//    return elBook1;
//}
//static Book GetBook()
//{
//    Console.WriteLine("Enter title: ");
//    string title = Console.ReadLine();
//    Console.WriteLine("Enter genre: ");
//    string genre = Console.ReadLine();
//    Console.WriteLine("Enter author: ");
//    string author = Console.ReadLine();
//    Console.WriteLine("Enter year: ");
//    short year = Convert.ToInt16(Console.ReadLine());
//    return new Book() { Title = title, Genre = genre, Author = author, Year = year };
//}

//doc.Save("Library.xml");
//Console.ReadLine();

        static Book GetBook()
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter genre: ");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter year: ");
            short year = Convert.ToInt16(Console.ReadLine());
            return new Book() { Title = title, Genre = genre, Author = author, Year = year };
        }
        static void Main(string[] args)
        {
            string pathToDoc = @"Library.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(pathToDoc);
            XmlElement root = doc.DocumentElement;
            foreach (XmlElement book in root.GetElementsByTagName("Book"))
            {
                Book b = new Book();
                if (book.HasAttribute("genre"))
                {
                    b.Genre = book.GetAttribute("genre");
                }

                foreach (XmlElement child in book.ChildNodes)
                {
                    switch (child.Name)
                    {
                        case "Title":
                            b.Title = child.InnerText;
                            break;
                        case "Author":
                            b.Author = child.InnerText;
                            break;
                        case "Year":
                            b.Year = Convert.ToInt16(child.InnerText);
                            break;
                    }
                }
                Console.WriteLine(b);
            }



            //List<Book> list = new List<Book>();
            //list.Add(GetBook());
            //list.Add(GetBook());
            //XmlDocument doc = new XmlDocument();
            ////Створення root-element
            //XmlElement root = doc.CreateElement("Library");
            //doc.AppendChild(root);
            //foreach(var book in list)
            //{
            //    root.AppendChild(CreateBook(doc,book));
            //}



            //doc.Save(pathToDoc);
            Console.ReadLine();
        }



         static XmlElement CreateBook(XmlDocument doc, Book b)
        {



            XmlElement elBook1 = doc.CreateElement("Book");



            //XmlAttribute genreAttr = doc.CreateAttribute("genre");
            //genreAttr.Value = "genre_1";
            //elBook1.Attributes.Append(genreAttr);



            elBook1.SetAttribute("genre", b.Genre);



            XmlElement title1 = doc.CreateElement("Title");
            title1.InnerText = b.Title;
            elBook1.AppendChild(title1);



            XmlElement author1 = doc.CreateElement("Author");
            author1.InnerText = b.Author;
            elBook1.AppendChild(author1);



            XmlElement year1 = doc.CreateElement("Year");
            year1.InnerText = Convert.ToString(b.Year);
            elBook1.AppendChild(year1);
            return elBook1;
        }
