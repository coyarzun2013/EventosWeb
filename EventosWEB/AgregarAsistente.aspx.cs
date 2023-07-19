using EventosModel;
using EventosModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosWEB
{
    public partial class AgregarAsistente : System.Web.UI.Page
    {
        private IRegionesDAL regionesDAL = new RegionesDALDB();
        private IAsistentesDAL asistentesDAL = new AsistentesDALDB();   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.regionDDL.DataSource = this.regionesDAL.ObtenerRegiones();
                this.regionDDL.DataTextField = "Nombre";
                this.regionDDL.DataValueField = "Id";
                this.regionDDL.DataBind();
            }
        }

        protected void ingresaBtn_Click(object sender, EventArgs e)
        {
            Asistente asistente = new Asistente();
            asistente.Rut = this.rutTXT.Text.Trim();
            asistente.Nombre = this.nombreTXT.Text.Trim();
            asistente.Apellido = this.apellidoTXT.Text.Trim();
            asistente.Edad = Convert.ToInt32(this.edadTXT.Text.Trim());
            asistente.Estado = this.estadoRbl.Text.Trim();
            asistente.Empresa = this.empresaTXT.Text.Trim();
            asistente.IdRegion = Convert.ToInt32(this.regionDDL.SelectedItem.Value);

            this.asistentesDAL.AgregarAsistente(asistente);
            Response.Redirect("MostrarAsistente.aspx");

        }
    }
}