namespace ListaExercicio.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Categoria Categoria { get; set; }

    }
}