using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using CapaReglas;
using System.Data;
using System.Threading.Tasks;
using System.Threading;

namespace ProductosSupermercado
{
    public partial class productos : System.Web.UI.Page
    {
        ClsEntProductos oEntProductos = new ClsEntProductos();
        ClsRegProductos oRegProductos = new ClsRegProductos();


        [Obsolete]
        
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!this.IsPostBack)
            {

                string name = Request.QueryString["name"];
                lblNameAdmin.Text =""+ name;

                
                if(lblNameAdmin.Text == "")
                {
                      Response.Redirect("admin.aspx");
                }

                oEntProductos.CodProducto = "";
                DataSet ds = new DataSet();
                ds = oRegProductos.consultarProducto(oEntProductos);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    Label err = new Label { Text="Sin Productos..."};
                    
                    panelProductos.Controls.Add(err);
                }
                else
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        Panel p = new Panel { CssClass = "py-2 border px-4 border-2 border-dark mb-2 d-flex flex-column flex-md-row bg-dark text-white" };
                        Panel p2 = new Panel { CssClass = "w-100 d-flex" ,ID="xd"};
                        
                        Label lblNombre = new Label { CssClass = "w-100", Text = ds.Tables[0].Rows[i]["nombre_producto"].ToString() };
                        Label lblMarca = new Label { CssClass = "w-100", Text = ds.Tables[0].Rows[i]["marca"].ToString() };
                        Label lblPrecio = new Label { CssClass = "w-100", Text = "$" + ds.Tables[0].Rows[i]["precio"].ToString() };
                        Label lblExistencias = new Label { CssClass = "w-100", Text = ds.Tables[0].Rows[i]["existencias"].ToString() };
                        Label lbl = new Label { CssClass = "w-50", Text = (i + 1).ToString() };
                        Label lblCodigo = new Label { CssClass = "w-75 text-info fw-bold", Text = ds.Tables[0].Rows[i]["cod_produco"].ToString() };

                        p.Controls.Add(lbl);
                        p.Controls.Add(lblCodigo);
                        p.Controls.Add(lblNombre);
                        p.Controls.Add(lblMarca);
                        p.Controls.Add(lblPrecio);
                        p.Controls.Add(lblExistencias);
                        p.Controls.Add(p2);

                        panelProductos.Controls.Add(p);
                    }
                }
            }
        }
        [Obsolete]

        protected void btAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtDescuento.Text == "" || txtExistencias.Text == "" || txtMarca.Text == "" || txtNombreProducto.Text == "" || txtPrecio.Text == "")
            {
                lblMensaje.Text = "Todos Los Campos Son Obligatorios";
                lblMensaje.CssClass = "text-danger";
            }
            else
            {
                oEntProductos.CodProducto = txtCodigo.Text;
                oEntProductos.Nombre = txtNombreProducto.Text;
                oEntProductos.Marca = txtMarca.Text;
                oEntProductos.Descuento = Convert.ToInt32(txtDescuento.Text);
                oEntProductos.Precio = Convert.ToInt32(txtPrecio.Text);
                oEntProductos.Existencias = Convert.ToInt32(txtExistencias.Text);

                if (oRegProductos.guardarProducto(oEntProductos))
                {
                    lblMensaje.Text = "El producto ha sido agregado correctamente";
                    lblMensaje.CssClass = "text-success mb-3";
                    txtCodigo.Text = "";
                    txtDescuento.Text = "";
                    txtMarca.Text = "";
                    txtNombreProducto.Text = "";
                    txtPrecio.Text = "";
                    txtExistencias.Text = "";
                    txtCodigo.Focus();
                }
                else
                {
                    lblMensaje.CssClass = "text-danger mb-3";
                    lblMensaje.Text = "No se pudo guardar el producto";
                }
            }
        }

        protected void btCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect(Page.Request.Url.ToString(), true);
        }
        [Obsolete]
        protected void btConfirmar_Click(object sender, EventArgs e)
        {
            if(txtConfirmarCodigo.Text != codBorrable.Text)
            {
                lblCodigos.Text = "Los codigos no coinciden";
                lblCodigos.CssClass = "text-danger mb-3";
            }
            else
            {
                oEntProductos.CodProducto = txtConfirmarCodigo.Text;

                if (oRegProductos.borrarProducto(oEntProductos))
                {

                    Response.Redirect(Page.Request.Url.ToString(),true);
                }
                else
                {
                    lblCodigos.Text = "No se pudo borrar el prodcuto";
                    lblCodigos.CssClass = "text-danger mb-3";
                }
            }
        }
        [Obsolete]
        protected void btModificar_Click(object sender, EventArgs e)
        {
            if (txtModCod.Text == "" || txtModDesc.Text == "" || txtModExist.Text == "" || txtModMarca.Text == "" || txtModNom.Text == "" || txtModPrecio.Text == "")
            {
                Label14.Text = "Todos Los Campos Son Obligatorios";
                Label14.CssClass = "text-danger mb-3";
            }
            else
            {
                oEntProductos.CodProducto = txtModCod.Text;
                oEntProductos.Nombre = txtModNom.Text;
                oEntProductos.Marca = txtModMarca.Text;
                oEntProductos.Descuento = Convert.ToInt32(txtModDesc.Text);
                oEntProductos.Precio = Convert.ToInt32(txtModPrecio.Text);
                oEntProductos.Existencias = Convert.ToInt32(txtModExist.Text);

                if (oRegProductos.actualizarProducto(oEntProductos))
                {
                    txtModExist.Enabled = false;
                    txtModMarca.Enabled = false;
                    txtModNom.Enabled = false;
                    txtModPrecio.Enabled = false;
                    txtModDesc.Enabled = false;

                    Label14.Text = "Producto Modificado Correctamente";
                    Label14.CssClass = "text-success mb-3";
                }
                else
                {
                    Label14.Text = "No se pudo modificar el producto!";
                    Label14.CssClass = "text-danger mb-3";
                }

            }
        }

        protected void btCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");
        }
    }
}