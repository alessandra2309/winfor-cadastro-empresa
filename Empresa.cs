
namespace CadastroPDS
{
    internal class Empresa
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeF { get; set; }
        public string SituacaoC { get; set; }
        public string RegimeT { get; set; }
        public string DataInicioAtividade { get; set; }
        public string Telefone { get; set; }
        public string CapitalS { get; set; }
        public string Endereco { get; set; }
        public string Tipo { get; set; }
        public string PorteEmpresa { get; set; }
        public string NaturezaJ { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Empresa()
        {

        }
        public Empresa(string Cnpj, string RazaoSocial, string NomeF, string SituacaoC, string RegimeT, string DataInicioAtividade, string Telefone, string CapitalS, string Endereco, string Tipo, string PorteEmpresa, string NaturezaJ, string Nome, string Cpf)
        {
            this.Cnpj = Cnpj;
            this.RazaoSocial = RazaoSocial;
            this.NomeF = NomeF;
            this.SituacaoC = SituacaoC;
            this.RegimeT = RegimeT;
            this.DataInicioAtividade = DataInicioAtividade;
            this.Telefone = Telefone;
            this.CapitalS = CapitalS;
            this.Endereco = Endereco;
            this.Tipo = Tipo;
            this.PorteEmpresa = PorteEmpresa;
            this.NaturezaJ = NaturezaJ;
            this.Nome = Nome;
            this.Cpf = Cpf;
        }
    }
}

