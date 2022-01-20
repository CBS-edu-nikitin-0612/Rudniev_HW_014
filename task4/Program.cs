using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker docWorker;
            string sw;

            Console.WriteLine("Ключ доступа pro: pro");
            Console.WriteLine("Ключ доступа expert: exp");
            Console.Write("Введите ключ доступа или проигнорируйте: ");
            string key = Console.ReadLine().ToLower();

            switch (key)
            {
                case "pro":
                    docWorker = new ProDocumentWorker() as DocumentWorker;
                    Console.WriteLine("Создался экземпляр ProDocumentWorker.");
                    break;
                case "exp":
                    docWorker = new ExpertDocumentWorker() as DocumentWorker;
                    Console.WriteLine("Создался экземпляр ExpertDocumentWorker.");
                    break;
                default:
                    docWorker = new DocumentWorker();
                    Console.WriteLine("Создался экземпляр DocumentWorker.");
                    break;
            }
            Console.WriteLine(new string('_', 50));

            do
            {
                Console.Write("Выберите действие 'O'-открыть, \n'E'-редактировать, 'S'-сохранить, 'C'-выйти: ");
                sw = Console.ReadLine().ToUpper();
                switch (sw)
                {
                    case "O":
                        docWorker.OpenDocument();
                        break;
                    case "E":
                        docWorker.EditDocument();
                        break;
                    case "S":
                        docWorker.SaveDocument();
                        break;
                }
            } while (sw != "C");
        }
    }
}
