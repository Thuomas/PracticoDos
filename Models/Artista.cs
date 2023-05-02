namespace TPdos.Models;

public class Artista
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Edad { get; set; }

    public virtual List<Banda> Bandas { get; set; } 

    public int AlbumDebutId { get; set; }

    public virtual AlbumDebut AlbumDebut { get; set; }

}