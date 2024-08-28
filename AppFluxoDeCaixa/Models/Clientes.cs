namespace AppFluxoDeCaixa.Models
{
    public class Clientes
    {
        public Guid ClientesId { get; set; }
        public string ClientesNome { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateOnly DataNascFundacao { get; set; }
        public bool CadastroAtivo { get; set; }
        public string Observacao { get; set; }
    }
}