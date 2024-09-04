using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDS
{
    internal class Pessoa
    {
        public string nome;
        public string telefone;
        public string email;
        public double altura;
        public double peso;
        public double imc;
        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu telefone:");
            telefone = Console.ReadLine();

            Console.WriteLine("Digite seu email:");
            email = Console.ReadLine();
        }
        public void mostrarDados()
        {
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Nome: {0}", telefone);
            Console.WriteLine("Nome: {0}", email);
        }
        public void calculoImc()
        {
            Console.WriteLine("Digite seu peso:");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
        }
        public void mostrarResultado()
        {
            if (imc < 16)
            {
                Console.WriteLine("IMC: {0} - Magreza grave", imc);
            }
            else if (imc >= 16 && imc <= 16.9)
            {
                Console.WriteLine("IMC: {0} - Magreza moderada", imc);
            }
            else if (imc >= 17 && imc <= 18.5)
            {
                Console.WriteLine("IMC: {0} - Magreza leve", imc);
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                Console.WriteLine("IMC: {0} - Peso ideal", imc);
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("IMC: {0} - Sobrepeso", imc);
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("IMC: {0} - Obesidade grau I", imc);
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("IMC: {0} - Obesidade grau II ou severa", imc);
            }
            else
            {
                Console.WriteLine("IMC: {0} - Obesidade grau III ou mórbida", imc);
            }
        }
        
    }
}
