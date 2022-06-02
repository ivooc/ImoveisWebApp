namespace ImoveisWebApp.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public string ValorVenda { get; set; }
        public string ValorLocacao { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}