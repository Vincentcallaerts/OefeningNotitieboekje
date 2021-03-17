using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningNotitieboekje
{
    class Notitie
    {
        private string opschrift;

        public string Opschrift
        {
            get { return opschrift; }
            set { opschrift = value; }
        }
        public Notitie() 
        {
            Console.Write("Schrijf iets op de notitie: ");
            Opschrift = Console.ReadLine();   
        }
        public Notitie(string opschrift)
        {
            
            Opschrift = opschrift;
        }
        public void Info()
        {
            Console.WriteLine($"Op deze notitie staat nu:\n{Opschrift}");
        }
        public void Bijschrijven()
        {
            Console.Write("Schrijf iets bij je oude notitie: ");
            Opschrift = opschrift +"\n"+ Console.ReadLine();
        }
    }
}
