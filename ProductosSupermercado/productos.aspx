<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productos.aspx.cs" Inherits="ProductosSupermercado.productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://kit.fontawesome.com/30ec5c3528.js" crossorigin="anonymous"></script>
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="estilos.css" rel="stylesheet" />
    <title>Productos</title>
    
</head>
<body class=" position-relative bg-light">
    <header>
         <nav class="navbar navbar-dark bg-dark">
            <div class="container">
                <img src="imgs/productos.png" width="80" height="80" />  
                <div class="d-flex">
                    <asp:Label ID="lblAdmin" runat="server" CssClass="fs-1 fw-bolder text-info" text="Administrador/"></asp:Label>
                    <asp:Label ID="lblNameAdmin" runat="server" CssClass="fs-1 fw-bolder text-white" ></asp:Label>
                </div>
              
            
            </div>
        </nav>
    </header>
    <main>
        <form id="form2" runat="server" class="container mt-3">
            <asp:ScriptManager runat="server">

            </asp:ScriptManager>

            <div class="d-flex justify-content-between align-align-items-center">
                <h2 class="mb-3">Productos:</h2>
                 <asp:Button runat="server" CssClass="btn btn-outline-danger h-50" ID="btCerrarSesion" Text="Cerrar Sesion" OnClick="btCerrarSesion_Click" ></asp:Button>
                <button class="btn btn-success h-50 add" runat="server" id="perra"><i class="fa-solid fa-plus"></i></button>
                 
            </div>
            <div class="mb-1 container-fluid px-2 ">
                <div class="d-hide d-md-flex justify-content-between px-4">
                    <p class="w-50">#</p>
                    <p class="w-75">Codigo</p>
                    <p class="w-100">Nombre</p>
                    <p class="w-100">Marca</p>
                    <p class="w-100">Precio</p>
                    <p class="w-100 me-1">Existencias</p>
                    <p class="w-100">Opciones</p>
                </div>
           
            </div>
            <asp:Panel ID="panelProductos" runat="server" CssClass="container-fluid p-2">
            
            </asp:Panel>
            <div id="panelIngresar">
                <div class="bg-light p-5 rounded w-50">   
                    
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <fieldset>
                                <div class="mb-3">
                                    <asp:Label ID="Label1" runat="server" CssClass="form-label mb-1" Text="Codigo"></asp:Label>
                                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label2" runat="server" CssClass="form-label mb-1" Text="Nombre"></asp:Label>
                                    <asp:TextBox ID="txtNombreProducto" runat="server" CssClass="form-control" ></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label3" runat="server" CssClass="form-label mb-1" Text="Marca"></asp:Label>
                                    <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label4" runat="server" CssClass="form-label mb-1" Text="Precio"></asp:Label>
                                    <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label5" runat="server" CssClass="form-label mb-1" Text="Existencias"></asp:Label>
                                    <asp:TextBox ID="txtExistencias" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label6" runat="server" CssClass="form-label mb-1" Text="Descuento"></asp:Label>
                                    <asp:TextBox ID="txtDescuento" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                                </div>

                                <asp:Label ID="lblMensaje" runat="server" Text="" CssClass="mb-3"></asp:Label>
                                <div class="my-3 me-auto">
                                    <asp:Button runat="server" ID="btCancelar" CssClass="btn btn-danger" Text="Cerrar" OnClick="btCancelar_Click"></asp:Button>
                                    <asp:Button ID="btAgregar" runat="server" Text="Agregar Producto" CssClass="btn btn-success" OnClick="btAgregar_Click" />
                                </div> 
                            </fieldset>
                        </ContentTemplate>
                    </asp:UpdatePanel>


                </div>
            </div>
            <div id="panelBorrar">
                <div class="bg-light p-5 rounded w-50">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <fieldset>
                                <div class="mb-3">
                                    <asp:Label ID="Label7" runat="server" CssClass="form-label mb-2" Text="Para confirmar ingresa de nuevo el codigo del producto:"></asp:Label>
                                    <asp:TextBox ID="codBorrable" runat="server" CssClass="form-control mb-2" type="number" Enabled="false"></asp:TextBox>
                                    <asp:TextBox ID="txtConfirmarCodigo" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                                </div>
                                <asp:Label ID="lblCodigos" Text="" runat="server"></asp:Label>
                                <div class="my-3">
                                    <asp:Button runat="server" ID="Button1" CssClass="btn btn-danger" Text="Cancelar" OnClick="btCancelar_Click"></asp:Button>
                                    <asp:Button ID="btConfirmar" runat="server" Text="Confirmar" CssClass="btn btn-success"  OnClick="btConfirmar_Click"/>
                                </div> 
                            </fieldset>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
             <div id="panelModificar">
                <div class="bg-light p-5 rounded w-50">
                    <asp:UpdatePanel runat="server">
                        <ContentTemplate>
                            <fieldset>
                               <div class="mb-3">
                                    <asp:Label ID="Label8" runat="server" CssClass="form-label mb-1" Text="Codigo" ></asp:Label>
                                    <asp:TextBox ID="txtModCod" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label9" runat="server" CssClass="form-label mb-1" Text="Nombre"></asp:Label>
                                    <asp:TextBox ID="txtModNom" runat="server" CssClass="form-control" ></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label10" runat="server" CssClass="form-label mb-1" Text="Marca"></asp:Label>
                                    <asp:TextBox ID="txtModMarca" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label11" runat="server" CssClass="form-label mb-1" Text="Precio"></asp:Label>
                                    <asp:TextBox ID="txtModPrecio" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label12" runat="server" CssClass="form-label mb-1" Text="Existencias"></asp:Label>
                                    <asp:TextBox ID="txtModExist" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                                </div>
                                <div class="mb-3">
                                    <asp:Label ID="Label13" runat="server" CssClass="form-label mb-1" Text="Descuento"></asp:Label>
                                    <asp:TextBox ID="txtModDesc" runat="server" CssClass="form-control" type="number"></asp:TextBox>
                                </div>

                                <asp:Label ID="Label14" runat="server" Text="" CssClass="mb-3"></asp:Label>
                                <div class="my-3 me-auto">
                                    <asp:Button runat="server" ID="Button2" CssClass="btn btn-danger" Text="Cerrar" OnClick="btCancelar_Click"></asp:Button>
                                    <asp:Button ID="btModificar" runat="server" Text="Modificar" CssClass="btn btn-success" OnClick="btModificar_Click" />
                                </div> 
                            </fieldset>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            
        </form>
        
    </main>
    



    <script src="Scripts/bootstrap.min.js" ></script>
    <script src="Scripts/controller.js" ></script>
</body>
</html>
