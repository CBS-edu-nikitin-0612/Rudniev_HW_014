using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public ExpertDocumentWorker() { }
        public override void SaveDocument()
            => Console.WriteLine("Документ сохранен в новом формате");
    }
}
