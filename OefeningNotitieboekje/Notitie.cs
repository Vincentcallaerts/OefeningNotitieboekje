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
        public DateTime AanmaakMoment { get; private set; }
        public string Opschrift
        {
            get { return opschrift; }
            set { opschrift = value; }
        }
        public Notitie() 
        {
            Console.Write("Schrijf iets op de notitie: ");
            Opschrift = Console.ReadLine();
            AanmaakMoment = DateTime.Now;
        }
        public Notitie(string opschrift)
        {          
            Opschrift = opschrift;
            AanmaakMoment = DateTime.Now;
        }
        public void Info()
        {
            Console.WriteLine($"Notitie aangemaakt op {AanmaakMoment.ToString("dd/MM/yyyy HH:mm:ss")}:\n{Opschrift}");
        }
        public void Bijschrijven()
        {
            Console.Write("Schrijf iets bij je oude notitie: ");
            Opschrift = opschrift +"\n"+ Console.ReadLine();
        }
    }
}
