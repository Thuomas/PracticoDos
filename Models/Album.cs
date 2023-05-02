namespace TPdos.Models;

public class Album
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int AnioLanzamiento { get; set; }

    public virtual List<Banda> Bandas { get; set; } 

}