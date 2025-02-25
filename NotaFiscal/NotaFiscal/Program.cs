using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscal
{
    //Classe para representar um item da nota fiscal
    public class ItemNotaFiscal
    {
        public string Descricao {  get; set; } //descrição do produto
        public decimal Valor { get; set; } //valor unitário do produto
        public int Quantidade { get; set; } //quantidade do produto

        //Classe para inicializar um item
        public ItemNotaFiscal(string descricao, decimal valor, int quantidade)
        {
            Descricao = descricao;
            Valor = valor;
            Quantidade = quantidade;
        }
    }

    //Classe principal que representa a nota fiscal
    public class NotaFiscal 
    {
        public int Numero { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public string RazaoSocialEmitente { get; private set; }
        public string CpfCnpjEmitente { get; private set; }
        public string RazaoSocialDestinatario { get; private set; }
        public string CpfCnpjDestinatario { get; private set; }
        public List<ItemNotaFiscal> Itens { get; private set; }
        public bool Emitida {  get; private set; }

        //classe para inicializar a nota fiscal
        public NotaFiscal(int numero, string razaoSocialEmitente, string cpfCnpjEmitente, string razaoSocialDestinatario, string cpfCnpjDestinatario)
        {
            Numero = numero;
            DataEmissao = DateTime.Now;
            RazaoSocialEmitente = razaoSocialEmitente;
            CpfCnpjEmitente = cpfCnpjEmitente;
            RazaoSocialDestinatario = razaoSocialDestinatario;
            CpfCnpjDestinatario = cpfCnpjDestinatario;
            Itens = new List<ItemNotaFiscal>();
            Emitida = false;
        }

        //para cancelar a nota fical
        public void CancelarNotaFiscal()
        {
            if (!Emitida)
            {
                Console.WriteLine("Nota fiscal não emitida, não pode ser cancelada");
                return; //Retorna se a nota não tiver sido emitida
            }

            Emitida = false; //Define a nota como não emitida
            Console.WriteLine($"Nota fiscal {Numero} cancelada com sucesso");
        }

        //para adicionar um produto a nota fiscal
        public void AdicionarProduto(string descricao, decimal valor, int quantidade)
        {
            Itens.Add(new ItemNotaFiscal(descricao, valor, quantidade)); //add um novo item a lista
            Console.WriteLine($"priduto '{descricao}' adicionado a nota fiscal {Numero}.");
        }

        //Para cancelar um produto específico da nota fiscal
        public void CancelarProduto(string descricao)
        {
            var item = Itens.Find(i => i.Descricao == descricao); //buscar o item pelo nome
            if (item != null)
            {
                Itens.Remove(item); //Remove o item da lista
                Console.WriteLine($"Produto '{descricao}' cancelar nota fical {Numero}.");
            }
            else
            {
                Console.WriteLine($"Produto '{descricao}' não encontrado n a nota fiscal {Numero}.");
            }
        }

        //para  mostrar os detalhes da nota fical
        public void ExibirDetalhesNotaFiscal()
        {
            Console.WriteLine($"nota fical {Numero}:");
            Console.WriteLine($"emitente: {RazaoSocialEmitente} - {CpfCnpjEmitente}");
            Console.WriteLine($"destinatário: {RazaoSocialDestinatario} - {CpfCnpjDestinatario}");
            Console.WriteLine($"Data de emissão: {DataEmissao}");
            Console.WriteLine("Itens:");

            //Exiba cada item da nota fiscal
            foreach (var item in Itens)
            {
                Console.WriteLine($"{item.Descricao} Quantidade: {item.Quantidade}, valor: {item.Valor}");
                Console.ReadKey();
            }
        }
    }
}
