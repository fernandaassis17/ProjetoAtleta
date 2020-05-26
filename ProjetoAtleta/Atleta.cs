using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private int idade;
        private double altura;
        private double peso;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser preenchido!");
                }

            }
            get { return this.nome; }
        }

        public int Idade
        {
            set { this.idade = value; }
            get { return this.idade; }
        }
        public double Altura
        {
            set
            {
                if (value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura mínima deve ser de 1.00!");
                }

            }
            get { return this.altura; }
        }

        public double Peso
        {
            set
            {
                if (value > 0.00)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso deve ser preenchido!");
                }

            }
            get { return this.peso; }
        }

        public string ImprimeDados()
        {

            return "Dados do Atleta: \n\nNome:" + this.nome
                + "\n\nIdade: " + this.idade + "\n\nAltura: " + this.altura +
                "\n\nPeso: " + this.peso;
        }

        public double CalcularIMC()
        {
            return (this.peso / (this.altura * this.altura));
        }


    }
}
