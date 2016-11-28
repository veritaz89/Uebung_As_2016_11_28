using System;

namespace AngVerwaltung
{
  public class Angestellter
  {
    //TODO: 1. Implementieren Sie alle Attribute ueber Self-Implemented-Properties, die Klasse soll nur den Standard-Konstruktor enthalten.
    //TODO: 4. (Zusatzaufgabe) Implementieren Sie eine readonly-Eigenschaft 'Vollname', die den vollen Namen (Vor- und Zuname) als string zurückgibt.
      public string Name { get; set; }
      public string Vname{get;set;}
      public double Gehalt{get;set;}
    #region TODO 4
      public string Vollname(string vname, string name)
      {
          return vname + " " + name;
      }
    #endregion
  }
}