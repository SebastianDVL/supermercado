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
                lblNameAdmin.Text = name;

                oEntProductos.CodProducto = "";
                DataSet ds = new DataSet();
                ds = oRegProductos.consultarProducto(oEntProductos);

                if (ds.Tables[0].Rows.Count == 0)
                {

                }
                else
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        Panel p = new Panel { CssClass = "py-2 border px-4 border-2 border-dark mb-2 d-flex justify-content-between" };
                        Panel p2 = new Panel { CssClass = "w-100 d-flex" };
                        LinkButton lbModify = new LinkButton { Text = "<i class='fa-solid fa-pen'></i>" };
                        LinkButton lbDelete = new LinkButton { Text = "<i class='fa-solid fa-trash text-danger ms-5'></i>" };
                        p2.Controls.Add(lbModify);
                        p2.Controls.Add(lbDelete);
                        Label lblNombre = new Label { CssClass = "w-100", Text = ds.Tables[0].Rows[i]["nombre_producto"].ToString() };
                        Label lblMarca = new Label { CssClass = "w-100", Text = ds.Tables[0].Rows[i]["marca"].ToString() };
                        Label lblPrecio = new Label { CssClass = "w-100", Text = "$" + ds.Tables[0].Rows[i]["precio"].ToString() };
                        Label lblExistencias = new Label { CssClass = "w-100", Text = ds.Tables[0].Rows[i]["existencias"].ToString() };
                        Label lbl = new Label { CssClass = "w-50", Text = (i + 1).ToString() };
                        Label lblCodigo = new Label { CssClass = "w-75", Text = ds.Tables[0].Rows[i]["cod_produco"].ToString() };


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

            if (txtCodigo.Text =="" || txtDescuento.Text == "" || txtExistencias.Text ==""|| txtMarca.Text ==""||txtNombreProducto.Text ==""||txtPrecio.Text == "")
            {
                lblMensaje.Text = "Todos Los Campos Son Obligatorios";
                lblMensaje.CssClass ="text-danger";
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
                    lblMensaje.Text = "Producto Guardado Exitosamente";
                    lblMensaje.CssClass = "text-success";
                    txtCodigo.Text = "";
                    txtDescuento.Text = "";
                    txtPrecio.Text = "";
                    txtNombreProducto.Text = "";
                    txtMarca.Text = "";
                    txtExistencias.Text = "";
                    
                }
                else
                {
                    lblMensaje.CssClass = "text-danger";
                    lblMensaje.Text = "No se pudo guardar el producto";
                }

            }
        }
    }
}