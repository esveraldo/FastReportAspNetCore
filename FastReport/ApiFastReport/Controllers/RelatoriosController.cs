using ApiFastReport.Data;
using ApiFastReport.Entity;
using ApiFastReport.Helpers;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFastReport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class RelatoriosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RelatoriosController(ApplicationDbContext context)
        {
            _context = context;
        }

        /*[HttpGet("ListagemUsuariosSimples")]
        public ActionResult GetListagemUsuariosSimples()
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(new { message = "Usuário ou senha inválidos" });

                var webReport = new WebReport();
                webReport.Report.Load(Path.Combine("Reports\\ListagemUsuarios.rfx"));

                var usuarioList = _context.Usuarios.Where(u => u.Nome != string.Empty).ToList();
                var usuarios = new DataTable();
                usuarios.Columns.Add("Nome");
                usuarios.Columns.Add("Email");

                foreach (var item in usuarioList)
                {
                    usuarios.Rows.Add(item.Nome, item.Email);
                }

                webReport.Report.RegisterData(usuarios, "usuarios");
                webReport.Report.Prepare();

                byte[] reportArray = null;

                using (MemoryStream ms = new MemoryStream())
                {
                    var pdfExport = new PDFSimpleExport();
                    pdfExport.Export(webReport.Report, ms);
                    ms.Flush();
                    reportArray = ms.ToArray();
                }

                return File(reportArray, "application/pdf", "ListagemDeUsuarios.pdf");
            }
            catch (Exception)
            {

                return BadRequest(new { Message = "Houve um erro no seu processo, por favor tenten mais tarde" });
            }
        }*/

        /// <summary>
        /// FastReport otimizado
        /// </summary>
        /// <returns></returns>
        [HttpGet("ListagemUsuariosSimples")]
        public ActionResult GetListagemUsuariosSimples()
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(new { message = "Usuário ou senha inválidos" });

                var webReport = HelperFastReport.WebReport("ListagemUsuarios.frx");

                var usuarioList = _context.Usuarios.Where(u => u.Nome != string.Empty).ToList();
                
                var usuarios = HelperFastReport.GetTable<Usuario>(usuarioList, "usuarios");
                webReport.Report.RegisterData(usuarios, "usuarios");
                return File(HelperFastReport.ExportarPdf(webReport), "application/pdf", "ListagemDeUsuarios.pdf");
            }
            catch (Exception)
            {

                return BadRequest(new { Message = "Houve um erro no seu processo, por favor tenten mais tarde" });
            }
        }
    }
}
