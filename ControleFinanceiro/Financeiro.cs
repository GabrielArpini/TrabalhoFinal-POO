using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro
{
    public class Financeiro
    {
        private string _name;
        private string _categoria;
        private double _income;
        private double _expenses;
        private DateTime _date;

        public string Name { get { return _name; } set { _name = value; } }
        public string Categoria { get { return _categoria; } set { _categoria = value; } }
        public double Income { get { return _income; } set { _income = value; } }
        public double Expenses { get { return _expenses; } set { _expenses = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
    }
}
