namespace TPdos.Models;

public class AlbumDebut
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int AnioLanzamiento { get; set; }

    public string BandaId { get; set; }

    public virtual Banda Banda { get; set; } 

}