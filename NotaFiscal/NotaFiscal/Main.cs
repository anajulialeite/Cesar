using System;
using System.Collections.Generic;

namespace NotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso das classes
            var notaFiscal = new NotaFiscal(1, "Ana Júlia LTDA", "12.345.678/0001-90", "Destinatário alguém", "98.765.432/0001-01");

            notaFiscal.AdicionarProduto("Produto A", 5.000m, 2);
            notaFiscal.AdicionarProduto("Produto B", 500m, 1);

            notaFiscal.ExibirDetalhesNotaFiscal();

            // Cancelar um produto
            notaFiscal.CancelarProduto("Produto A");

            // Exibir detalhes novamente
            notaFiscal.ExibirDetalhesNotaFiscal();

            // Cancelar a nota fiscal
            notaFiscal.CancelarNotaFiscal();
        }
    }
}
