using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Script.Serialization;

namespace WSContato25112017
{
    /// <summary>
    /// Descrição resumida de WSContatos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 

    [System.Web.Script.Services.ScriptService]
    public class WSContatos : System.Web.Services.WebService
    {

        [WebMethod]
        public void ObterContatos()
        {

            List<Contato> listaContatos = new List<Contato>();

            listaContatos.Add(new Contato() { Codigo = 11, Nome = "Bryon Hetrick", Data = "25/05/2005",  NomeOperadora = "Embratel", Telefone = "44447-7894", cor="black" });
            listaContatos.Add(new Contato() { Codigo = 22, Nome = "Nicole Wilcox", Data = "25/05/2005", NomeOperadora = "OI", Telefone = "11111-3652", cor = "green" });
            listaContatos.Add(new Contato() { Codigo = 33, Nome = "Adrian Martinson", Data = "25/05/2005", NomeOperadora = "Vivo", Telefone = "22222-9875", cor = "orange" });
            listaContatos.Add(new Contato() { Codigo = 44, Nome = "Nora Osborn", Data = "25/05/2005", NomeOperadora = "Tim", Telefone = "33333-3569", cor = "blue" });

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(listaContatos));
        }

        [WebMethod]
        public void ObterOperadoras()
        {
            List<Operadora> listaOperadoras = new List<Operadora>();

            listaOperadoras.Add(new Operadora() { nome= "Oi", codigo= 14, categoria= "Celular", preco= 7.15 });
            listaOperadoras.Add(new Operadora() { nome= "Vivo", codigo= 15, categoria= "Celular", preco= 1.25 });
            listaOperadoras.Add(new Operadora() { nome= "Tim", codigo= 41, categoria= "Celular", preco= 3.78 });
            listaOperadoras.Add(new Operadora() { nome= "GVT", codigo= 25, categoria= "Fixo", preco= 4.87 });
            listaOperadoras.Add(new Operadora() { nome= "Embratel", codigo= 21, categoria= "Fixo", preco= 2.98 });

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(listaOperadoras));
        }

    }  
}
