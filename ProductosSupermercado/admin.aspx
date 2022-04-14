<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="ProductosSupermercado.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="estilos.css" rel="stylesheet" />
    <title>Inicio</title>
</head>
<body>
    <header>
        
        <nav class="navbar navbar-dark bg-dark">
            <div class="container d-flex justify-content-center">
                <div class="d-flex align-align-items-center">
                    <img src="imgs/super.png" width="80" height="80"  />  
                    <h1 class="text-white mt-3 ms-3">Inventario Supermercado </h1>
                </div>
               
            </div>
        </nav>
    </header>
    <main>
        <section class="d-flex align-items-center">
             
                    <form id="form1" runat="server" class="d-flex flex-column w-50 m-auto">
                        <h2 class="mb-5">Ingresa con tu cuenta de administrador:</h2>
                        <div class="mb-3">
                            <asp:Label ID="Label1" runat="server" CssClass="form-label mb-2 fw-bold" Text="Identificacion:"></asp:Label>
                            <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
                     
                        </div>
                        <div class="mb-3">
                            <asp:Label ID="Label2" runat="server" CssClass="form-label mb-2 fw-bold" Text="Contraseña:"></asp:Label>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" type="password"></asp:TextBox>
                        </div>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
           
                        <asp:Button ID="btSubmit" runat="server" Text="Ingresar" CssClass="btn btn-primary mt-3" OnClick="btSubmit_Click" />
                    </form>
                  
        </section>
   
        
    
    </main>
    <footer>

    </footer>
   
       <script src="Scripts/bootstrap.min.js" ></script>
</body>
</html>
