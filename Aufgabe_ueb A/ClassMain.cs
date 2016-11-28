using System;

namespace AngVerwaltung
{
	public class ClassMain
	{    
    public static void Main()
		{
      //Erzeugen der Objekte      
      Angestellter ang1 = new Angestellter();
      Angestellter ang2 = new Angestellter();
      //TODO: 2. Erzeugen Sie ein zusaetzliches Objekt ang3 und geben Sie es auch auf der Konsole aus, die Attributwerte denken Sie sich aus.

      //Setzen der Attribute
      //TODO: 3. Fuegen Sie den vorhandenen Objekten jeweils einen Vornamen hinzu und geben Sie den Vornamen auch auf dem Bildschirm aus.
      ang1.Name= "Meier";
      ang1.Gehalt= 4500;
      ang2.Name= "Petersen";
      ang2.Gehalt= 6000;

      //Bildschirmausgaben
      Console.WriteLine("Name: " + ang1.Name);
      Console.WriteLine("Gehalt: " + ang1.Gehalt + " Euro");
      Console.WriteLine("\nName: " + ang2.Name);
      Console.WriteLine("Gehalt: " + ang2.Gehalt + " Euro");
      Console.Read();
		}//Main
	}//class ClassMain
}//namespace AngVerwaltung
