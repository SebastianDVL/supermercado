using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaReglas;
using System.Data;
namespace ProductosSupermercado
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ClsRegAdmin oRegAdmin = new ClsRegAdmin(); 
        ClsEntAdmin oEntAdmin = new ClsEntAdmin();

        [Obsolete]
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "" || txtPassword.Text == ""){
                lblMsg.Text = "Todos los campos son obligatorios";
                lblMsg.CssClass = "text-danger";
            }
            else
            {
                oEntAdmin.Id = txtId.Text;
                DataSet dsAdmin = new DataSet();
                dsAdmin = oRegAdmin.consultarAdmin(oEntAdmin);

                if (dsAdmin.Tables[0].Rows.Count == 0) {
                    lblMsg.Text = "El administrador con id " + txtId.Text + " No existe";
                    lblMsg.CssClass = "text-danger";
                }
                else
                {
                    if(dsAdmin.Tables[0].Rows[0]["contraseña"].ToString() != txtPassword.Text){
                        lblMsg.Text = "La contraseña es incorrecta";
                        lblMsg.CssClass = "text-danger";
                    }
                    else
                    {
                        lblMsg.Text = "Has ingresado correctamente";
                        lblMsg.CssClass = "text-success";
                    }
                }
            }
        }
    }
}