namespace Listas.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        // public Produto(int v, string v1)
        // {
            
        // }

        public Produto(int _codigo, string _nome, float _preco)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

        public Produto()
        {

        }
    }
}