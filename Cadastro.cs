

using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CadastroPDS
{
    internal class Cadastro
    {
        public List<Empresa> em = new List<Empresa>();
        private string CaminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Empresa.txt");
      

        public void SalvarEmpresasEmBlocoDeNotas()
        {
           

            File.WriteAllLines(CaminhoArquivo, em.Select(empresa =>  //escrevendo as linhas especificadas em um arquivo de texto e em string representa informações
            {
                return $"Nome: {empresa.Nome}, Razão Social: {empresa.RazaoSocial}, Situação Cadastral: {empresa.SituacaoC}\ncnpj:{empresa.Cnpj},Nome Fantasia: {empresa.NomeF},Regime Tributario:{empresa.RegimeT}\nData de Início de Atividade: {empresa.DataInicioAtividade},Telefone: {empresa.Telefone},Capital Social: {empresa.CapitalS}\nEndereço: {empresa.Endereco},Tipo: {empresa.Tipo},Porte da Empresa: {empresa.PorteEmpresa}\nNatureza Jurídica: {empresa.NaturezaJ},CPF do Responsável: {empresa.Cpf}.";
            }));

            // Exibe uma mensagem indicando que o arquivo foi salvo com sucesso
            Process pro =  Process.Start("notepad.exe", CaminhoArquivo); // Abre o arquivo no Bloco de Notas
            //System.Threading.Thread.Sleep(4000); // Espera por 2 segundos

          //  Process.GetProcessById(pro.Id).Kill();
            pro.Kill(entireProcessTree: true); //fecha  o bloco de notas.
            MessageBox.Show("Os campus não foram preenchidos corretamente!");



        }


    }

}
