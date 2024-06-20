using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ControleFinanceiro
{
    class Usuarios
    {
        private List<Usuario> _usuarios;
        public Usuarios()
        {
            this._usuarios = new List<Usuario>();
        }
        public void Adicionar(Usuario user)
        {
            if (this._usuarios.Count(c => c.Username.Equals(user.Username)) > 0)
            {
                throw new Exception("Já existe um usuário com o mesmo username");
            }
            else
            {
                this._usuarios.Add(user);
            }
        }
        public void Remover(Usuario user)
        {
            this._usuarios.Remove(user);
        }
        public List<Usuario> ListarTodos()
        {
            return this._usuarios;
        }
        public void Atualizar(List<Usuario> usuarios)
        {
            this._usuarios = usuarios;
        }
        public void Salvar()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
            string filePath = $"C:\\POOGrupo11Xml\\Usuarios.xml";
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, this._usuarios);
            }
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
            //FileStream fs = new FileStream("C:\\POOGrupo11Xml\\Usuarios.xml", FileMode.OpenOrCreate);
            //serializer.Serialize(fs, this._usuarios);
            //fs.Close();
        }
        public void Carregar()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
            //System.IO.DirectoryNotFoundException
            try
            {
                FileStream fs = new FileStream(@"C:\\POOGrupo11Xml\\Usuarios.xml", FileMode.OpenOrCreate);
                try
                {
                    this._usuarios = serializer.Deserialize(fs) as List<Usuario>;
                }
                catch (InvalidOperationException e)
                {
                    serializer.Serialize(fs, this._usuarios);
                }
                finally
                {
                    fs.Close();
                }
            }
            catch(System.IO.DirectoryNotFoundException) 
            {
                System.IO.Directory.CreateDirectory(@"C:\\POOGrupo11Xml\\");
            }

        }

    }
}