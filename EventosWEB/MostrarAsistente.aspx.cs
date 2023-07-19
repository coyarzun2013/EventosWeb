using EventosModel;
using EventosModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosWEB
{
    public partial class MostrarAsistente : System.Web.UI.Page
    {
        private IAsistentesDAL asistentesDAL = new AsistentesDALDB();

        private void cargaGrilla(List<Asistente> asistentes)
        {
            this.grillaAsistente.DataSource = asistentes;
            this.grillaAsistente.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                this.cargaGrilla(this.asistentesDAL.ObtenerAsistentes());
            }
        }

        protected void estadoDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = this.estadoDDL.SelectedValue;
            List<Asistente> asistentes = this.asistentesDAL.ObtenerAsistentes(estado);
            this.cargaGrilla(asistentes);

        }
    }
}