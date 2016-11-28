namespace AngVerwaltung
{
  public class Angestellter
  {
    #region Felder(Attribute)
    /// <summary>
    /// Der Nachname des Angestellten
    /// </summary>
    private readonly string name;

    /// <summary>
    /// Der Vorname des Angestellten
    /// </summary>
    private readonly string vname;

    /// <summary>
    /// Das Gehalt des Angestellten
    /// </summary>
    private readonly double gehalt;
    #endregion

    #region Eigenschaften
    //TODO: 1. Implementieren Sie fuer alle Felder (Attribute) Read-Only-Properties
    #endregion

    #region Methoden
    //TODO: 2. Implementieren Sie einen Konstruktor, der alle Felder (Attribute) initialisiert.
    public Angestellter (string name, string vname, double gehalt)
    {
        this.name = name;
        this.vname = vname;
        this.gehalt = gehalt;
    }
    #endregion    
  }
}