using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ControleFinanceiro
{
    internal class Financeiros
    {
        private List<Financeiro> _financeiros;
        public Financeiros()
        {
            this._financeiros = new List<Financeiro>();
        }
        public void Adicionar(Financeiro financeiro)
        {
            this._financeiros.Add(financeiro);
        }
        public void Remover(Financeiro financeiro)
        {
            this._financeiros.Remove(financeiro);
        }
        public List<Financeiro> ListarTodos()
        {
            return this._financeiros;
        }
        public void Salvar(string user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Financeiro>));
            string filePath = $"C:\\POOGrupo11Xml\\{user}.xml";

            // Abrir o FileStream com FileMode.Create para substituir o arquivo existente
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, this._financeiros);
            }
        }
        public void Atualizar(List<Financeiro> f)
        {
            this._financeiros= f;
        }

        public void Carregar(string user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Financeiro>));
            FileStream fs = new FileStream($"C:\\POOGrupo11Xml\\{user}.xml", FileMode.OpenOrCreate);
            try
            {
                this._financeiros = serializer.Deserialize(fs) as List<Financeiro>;
            }
            catch(InvalidOperationException e)
            {
                serializer.Serialize(fs,this._financeiros);
            }
            finally
            {
                fs.Close();
            }
        }

    }
}
