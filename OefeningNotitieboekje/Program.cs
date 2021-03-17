using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningNotitieboekje
{
    class Program
    {
        static void Main(string[] args)
        {
            Notitieboekje notebook = new Notitieboekje("Vincent",ConsoleColor.Green,"Taken");
            Notitie note = new Notitie("Dit is het opschrift van deze note");
            notebook.AddNote(note);
            notebook.AddNote(note);
            notebook.AddNote(note);
            notebook.AddNote(note);
            notebook.AddNote(note);
            notebook.BekijkNotitie(0);
            notebook.BekijkEigenschappen();
            notebook.Lamineer();
            notebook.AddNote(note);
            notebook.BekijkEigenschappen();
            Console.ReadLine();
        }
    }
}
