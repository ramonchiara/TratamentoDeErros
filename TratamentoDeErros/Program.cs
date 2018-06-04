using System;

namespace TratamentoDeErros
{
	class Program
	{
		public static void Main(string[] args)
		{
			try {
				Console.Write("n: ");
				int n = int.Parse(Console.ReadLine());

				Fatorial fatorial = new Fatorial();
				int resultado = fatorial.Calcula(n);

				Console.WriteLine("{0}! = {1}", n, resultado);
			} catch (FormatException ex) {
				Console.WriteLine("Entre com um número inteiro.");
			} catch (NumeroNegativoException ex) {
				Console.WriteLine("Entre com um número inteiro não-negativo.");
			} catch (Exception ex) {
				Console.WriteLine("Algo deu errado...");
			}
		}
	}
}
