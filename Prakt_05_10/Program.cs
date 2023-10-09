using Prakt_05_10;

Play play = new Play("viy", "Gogol", "scer", 10);
play.Print();//
play = null;// Знімаємо посилання на об'єкт, щоб він став доступним для зборки сміття
GC.Collect();// Викликаємо збірку сміття
