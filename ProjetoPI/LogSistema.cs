using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public static class LogSistema
    {
        private static readonly string caminhoLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");

        static LogSistema()
        {
            try
            {
                string pastaLogs = Path.GetDirectoryName(caminhoLog);
                if (!string.IsNullOrEmpty(pastaLogs))
                {
                    Directory.CreateDirectory(pastaLogs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inicializar LogSistema: {ex.Message}");
            }
        }
        public static void ResgistrarLogin(string usuario)
        {
            string log = $"{DateTime.Now:G} - LOGIN: Usuário '{usuario}' fez login";
            SalvarLog(log);
        }
        public static void RegistrarAcao(string usuario, string acao, string detalhes)
        {
            string log = $"{DateTime.Now:G} - AÇÃO: Usuário '{usuario}' realizou '{acao}' Detalhes: {detalhes}";
            SalvarLog(log);
            Console.WriteLine($"Resgistrando ação: {acao} com detalhes: {detalhes}");
        }
        private static void SalvarLog(string mensagem)
        {
            try
            {
                // Verifica se o arquivo de log existe, e cria se não existir
                if (!File.Exists(caminhoLog))
                {
                    try
                    {
                        File.Create(caminhoLog).Dispose(); // Cria o arquivo
                        Console.WriteLine($"Arquivo de log criado em: {caminhoLog}");
                    }
                    catch (Exception exCriacao)
                    {
                        Console.WriteLine($"Erro ao criar arquivo de log: {exCriacao.Message}");
                    }
                }

                File.AppendAllText(caminhoLog, mensagem + Environment.NewLine);
                Console.WriteLine($"Log salvo em: {caminhoLog}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar log: {ex.Message}");
            }
        }
    }
}
