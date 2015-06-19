using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Entidade
{
    public class Carrinho
    {
        private readonly List<ItensCarrinho> _itemCarrinho = new List<ItensCarrinho>(); 
        //Adicionar
        public void AdicionarItem(Produto pruduto, int quantidade)
        {
            //Retorna o produto na lista pelo id_Produto
            ItensCarrinho item = _itemCarrinho.FirstOrDefault(p => p.Produto.id_Produto == pruduto.id_Produto);

            if (item == null)
            {
                _itemCarrinho.Add(new ItensCarrinho
                {
                    Produto = pruduto,
                    Quantidade = quantidade
                });
            }
            else
            {
                item.Quantidade += quantidade;
            }
        
        }

        //Remover
        public void RemoverItem(Produto produto)
        {
            _itemCarrinho.RemoveAll(l => l.Produto.id_Produto == produto.id_Produto);
        }

        //Obter valor total
        public decimal ObterValorTotal()
        {
            return _itemCarrinho.Sum(e => e.Produto.vl_Produto*e.Quantidade);
        }

        //Limpar Carrinho
        public void LimparCarrinho()
        {
            _itemCarrinho.Clear();
        }

        //Itens Carrinho
        public IEnumerable<ItensCarrinho> ItensCarrinho
        {
            get { return _itemCarrinho; }
        } 

    }

    public class ItensCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
