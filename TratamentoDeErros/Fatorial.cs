using System;

namespace TratamentoDeErros
{
	public class Fatorial
	{
		public int Calcula(int n)
		{
			if (n < 0) {
				throw new NumeroNegativoException();
			}

			int resultado = 1;

			for (int i = 1; i <= n; i++) {
				resultado = resultado * i;
				if (resultado < 0) {
					throw new OverflowException();
				}
			}

			return resultado;
		}
	}
}
