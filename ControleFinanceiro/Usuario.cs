using System;

namespace ControleFinanceiro
{
    public class Usuario
    {
        private string _name;
        private string _email;
        private string _username;
        private string _password;
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }

    }

    
}