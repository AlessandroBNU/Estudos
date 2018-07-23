namespace Alura.Loja.Testes.ConsoleApp
{
    internal class Comprar
    {
        public Comprar()
        {
        }

        public int Id { get; set; }
        public int Quantidade { get; internal set; }
        public int ProdutoId { get; set; }
        public Produto Pruduto { get; internal set; }
        public double Preco { get; internal set; }
    }
}