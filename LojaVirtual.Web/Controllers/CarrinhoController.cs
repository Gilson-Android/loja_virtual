using System.Linq;
using System.Web.Mvc;
using LojaVirtual.Entidade;
using LojaVirtual.Repositorio;
using LojaVirtual.Web.Models;

namespace LojaVirtual.Web.Controllers
{
    
    public class CarrinhoController : Controller
    {
        private Repositorios _repositorio;
        public RedirectToRouteResult Adicionar(int id_Produto,string returnUrl)
        {
            _repositorio = new Repositorios();

            Produto produto = _repositorio.Produto.FirstOrDefault(c => c.id_Produto == id_Produto);
            
            if (produto != null)
            {
                ObterCarrinho().AdicionarItem(produto,1);
            }
            return RedirectToAction("Index", new {returnUrl});
        }

        public RedirectToRouteResult Remover(int id_Produto, string returnUrl)
        {
            _repositorio = new Repositorios();

            Produto produto = _repositorio.Produto.FirstOrDefault(c => c.id_Produto == id_Produto);

            if (produto != null)
            {
                ObterCarrinho().RemoverItem(produto);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Carrinho ObterCarrinho()
        {
            Carrinho carrinho = (Carrinho) Session["Carrinho"];
            if (carrinho == null)
            {
                carrinho = new Carrinho();
                Session["Carrinho"] = carrinho;
            }

            return carrinho;
        }

        public ViewResult Index(string returnurl)
        {
            return View(new CarrinhoViewModel
            {
                Carrinho = ObterCarrinho(),
                ReturnUrl = returnurl
            });
        }

        public PartialViewResult Resumo()
        {
            Carrinho carrinho = ObterCarrinho();
            return PartialView(carrinho);
        }
    }
}