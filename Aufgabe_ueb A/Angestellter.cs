using System;

namespace AngVerwaltung
{
  //TODO: 1. Fuegen Sie in der Klasse 'Angestellter' das Feld 'vname' hinzu und implementieren Sie die entsprechenden get- und set-Methoden.

  public class Angestellter
  {
    #region Fields (auch Felder, Attribute...Achtung: Das Wort Attribut ist doppelt belegt in c#)

      private double _gehalt;
      private string _name;
      private string _vname;

      #endregion

    #region Methoden

      public double Gehalt
      {
          get { return _gehalt;}
          set
          {
              if(value > 0)                 //Ein Beispiel wie weitere Prüfungen der Werte für die Felder erfolgen können...
              _gehalt = value;
          }
      }

      public string Name
      {
          get { return _name; }
          set { _name = value; }
      }

      //Kurzform für get und set Methoden: Erstellt das Feld und die get und set Methoden...
      public string Adresse { get; set; }
      public string VName { get; set; }

      #endregion
  }//class Angestellter
}//namespace AngVerwaltung
