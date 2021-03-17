using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningNotitieboekje
{
    class Notitieboekje
    {
        public bool Gelamineerd { get; private set; }
        public ConsoleColor Color { get; private set; }
        public string Eigenaar { get; set; }
        public string Title { get; set; }
        private List<Notitie> notebook;
        public List<Notitie> Notebook
        {
            get { return notebook; }
            set { notebook = value; }
        }
        public Notitieboekje()
        {
            notebook = new List<Notitie>();
            Gelamineerd = false;
        }

        public void Lamineer()
        {
            Gelamineerd = true;
        }

        public Notitieboekje(string eigenaar, ConsoleColor color, string title)
        {
            Color = color;
            Eigenaar = eigenaar;
            Title = title;
            notebook = new List<Notitie>();
            Gelamineerd = false;
        }
        public void NewNote()
        {
            if (!Gelamineerd)
            {
                Notitie tempNote = new Notitie();
                notebook.Add(tempNote);
            }
        }
        public void AddNote(Notitie note)
        {
            if (!Gelamineerd)
            {
                notebook.Add(note);
            }
            
        }
        public void Uitscheuren(int index)
        {
            if (!Gelamineerd)
            {
                notebook.RemoveAt(index);
            }
        }
        public void BewerkNotitie(int index) 
        {
            if (!Gelamineerd)
            {
                notebook[index].Bijschrijven();
            }
        }
        public void BekijkNotitie(int index)
        {
            Console.ForegroundColor = Color;
            notebook[index].Info();
        }
        public void BekijkNotitie()
        {
            Console.ForegroundColor = Color;
            for (int i = 0; i < notebook.Count; i++)
            {
                notebook[i].Info();
            }
        }
        public void BekijkEigenschappen()
        {
            Console.WriteLine($"Dit is {Eigenaar} zijn {Color} notitieboekje, in dit boekje zitten momenteel {notebook.Count} notities.");
        }
    }
}
