


using LojaVirtual.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
namespace LojaVirtual.Test
{
    [TestClass]
    public class UnitTestLojaVirtual
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

         [TestMethod]
        public void TestarSePaginacaoEstaGerandoCorretamente()
        {
             HtmlHelper html = null;
             Paginacao paginacao = new Paginacao
             {
                 PaginaAtual = 2,
                 ItensPorPagina = 10,
                 ItensTotal = 28

             };

             Func<int, string> paginaUrl = i => "pagina" + i;
             //MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

             
        }
    }
}
