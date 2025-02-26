using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScreenSound.Modelos;
[Table("Musica")]
public class Musica
{
    public Musica(string nome)
    {
        Nome = nome;
    }

    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public int? AnoLancamento { get; set; }
    public virtual Artista? Artista { get; set; }
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");      
    }
    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}";
    }
}