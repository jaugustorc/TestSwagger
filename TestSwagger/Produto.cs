namespace TestSwagger
{
    public class Produto
    {
        public Produto(int id, string name, decimal valor)
        {
            this.id = id;
            this.Name = name;
            this.Valor = valor;
        }

        public int id { get; set; }
        public string Name { get; set; }
        public decimal Valor { get; set; }
    }
}
