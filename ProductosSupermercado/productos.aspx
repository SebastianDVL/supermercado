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
<body class=" position-relative">
    <header>
         <nav class="navbar navbar-dark bg-dark">
            <div class="container">
                <img src="imgs/productos.png" width="80" height="80" />  
                <asp:Label ID="lblNameAdmin" runat="server" CssClass="fs-1 fw-bolder text-white"></asp:Label>
                <ul class="navbar-nav">
                    <li class="nav-item">
                        
                    </li>
                </ul>
            </div>
        </nav>
    </header>
    <main>
        <form id="form2" runat="server" class="container mt-3">

            <div class="d-flex justify-content-between align-align-items-center">
                <h2 class="mb-3">Productos:</h2>
                <button class="btn btn-success h-50"><i class="fa-solid fa-plus"></i></button>
            </div>
            <div class="mb-1 container-fluid px-2 ">
                <div class="d-flex justify-content-between px-4 border border-2 border-white">
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
            <asp:Panel ID="panelAdd" runat="server" CssClass="position-absolute top-50 start-50 w-75 translate-middle bg-light border shadow p-4 rounded">
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

                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                <div class="mb-3">
                    <button class="btn btn-danger" id="btnCerrar">Cerrar</button>
                    <asp:Button ID="btAgregar" runat="server" Text="Agregar Producto" CssClass="btn btn-success" OnClick="btAgregar_Click" />
                </div> 
            </asp:Panel>
        </form>

        
    </main>
    



    <script src="Scripts/bootstrap.min.js" ></script>
    <script src="scripts.js" ></script>
</body>
</html>
