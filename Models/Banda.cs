namespace TPdos.Models;

public class Banda
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Fundation { get; set; }

    public int ArtistaId { get; set; }
    public virtual Artista Artista { get; set; }

    public virtual List<Album> Albums { get; set; }

    public int AlbumDebutId { get; set; }

    public virtual AlbumDebut AlbumDebut { get; set; }

}