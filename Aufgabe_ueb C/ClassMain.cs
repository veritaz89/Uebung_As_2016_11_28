using System;
using System.Collections.Generic;

namespace AngVerwaltung
{
	public class ClassMain
	{
        public static void Main()
		{
      //TODO: 2. Erzeugen Sie drei Objekte der Klasse 'Angestellter', setzen Sie die Werte indem Sie ueber den Standard-Konstruktor die Eigenschaften ansprechen.
      //TODO: 3. Geben Sie alle Objekte mit ihren Attributen unter Verwendung der Eigenschaften aus.
      //TODO: 5. (Zusatzaufgabe) geben Sie die Eigenschaft 'Vollname' der Objekte aus.
     #region TODO 2
       Angestellter Tim = new Angestellter { Vname = "Tim", Name = "Toll", Gehalt = 200 };
       Angestellter Vivi = new Angestellter { Vname = "Vivi", Name = "Lus", Gehalt = 500 };
       Angestellter Alex = new Angestellter { Vname = "Alex", Name = "Gibbs", Gehalt = 1000};
     #endregion
     #region TODO 3
      Console.WriteLine(Vivi.Vname + " " + Vivi.Name + ": " + Vivi.Gehalt);
      Console.WriteLine(Tim.Vname + " " + Tim.Name + ": " + Tim.Gehalt);
      Console.WriteLine(Alex.Vname + " " + Alex.Name + ": " + Alex.Gehalt);
     #endregion
     #region TODO 5
      Console.WriteLine(Vivi.Vollname(Vivi.Vname, Vivi.Name));
     #endregion
      Console.Read();
		}//Main
	}//class ClassMain
}//namespace AngVerwaltung
