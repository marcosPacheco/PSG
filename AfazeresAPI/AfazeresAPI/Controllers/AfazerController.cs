using Afazeres.Models;
using Afazeres.Repository;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AfazeresAPI.Controllers
{
    [RoutePrefix("api/Afazeres")]
    public class AfazerController : ApiController
    {
        AfazerRepository db;

        public AfazerController()
        {
            db = new AfazerRepository();
        }

        [Route("Inserir")]
        [HttpPost]
        public bool InserirAfazer(Afazer obj)
        {
            try
            {
                db.Adicionar(obj);

                return true;
            }
            catch(Exception ex)
            {
                var erro = ex.Message;
                return false;
            }
        }

        [Route("Listar")]
        [HttpGet]
        public ICollection<Afazer> ListarAfazeres()
        {
            try
            {
                return db.GetAll();
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
                return null;
            }
        }

        [Route("Atualizar")]
        [HttpPost]
        public void AtualizarAfazer(Afazer obj)
        {
            try
            {
                db.Atualizar(obj);
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
            }
        }

        [Route("Excluir")]
        [HttpPost]
        public void ExcluirAfazer(Afazer obj)
        {
            try
            {
                db.Excluir(obj.IDAFAZER);
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
            }
        }
    }
}