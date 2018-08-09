using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Models;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        [Route("produtos", Name = "ListaProdutos")]
        public ActionResult Index()
        {
            ProdutosDAO dao = new ProdutosDAO();
            var produtos = dao.Lista();
            return View(produtos);
        }

        public ActionResult Form()
        {
            ViewBag.Produto = new Produto();
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = dao.Lista();
            ViewBag.Categorias = categorias;
            return View(categorias);

        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            int idDaInformatica = 1;
            if (produto.CategoriaId.Equals(idDaInformatica) && produto.Preco < 100)
            {
                ModelState.AddModelError("produto.InformaticaComPrecoInvalido", "Produtos da categoria informática devem ter preço maior do que 100");
            }
            if (ModelState.IsValid)
            {
                ProdutosDAO dao = new ProdutosDAO();
                dao.Adiciona(produto);
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                ViewBag.Produto = produto;
                CategoriasDAO categoriasDAO = new CategoriasDAO();
                ViewBag.Categorias = categoriasDAO.Lista();
                return View("Form");
            }
        }
        [Route("produtos/{id}", Name ="VisualizaProduto")]
            public ActionResult Visualiza(int Id)
            {
                ProdutosDAO dao = new ProdutosDAO();
                Produto produto = dao.BuscaPorId(Id);
                ViewBag.Produto = produto;
                return View();
            }
        
    }
}