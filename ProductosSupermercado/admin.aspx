<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="ProductosSupermercado.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <link href="Content/bootstrap.min.css" rel="stylesheet" />
 
    <title>Inicio</title>
</head>
<body>
    <header>
        
        <nav class="navbar navbar-dark bg-dark">
            <div class="container">
                <img src="imgs/super.png" width="80" height="80" />  
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="#">Administrador | Ingresar</a>
                    </li>
                </ul>
            </div>
        </nav>
    </header>
    <main>
        <section>
        
                <asp:Panel ID="formPanel" runat="server" CssClass="container mt-4">
                    <form id="form1" runat="server" class="d-flex flex-column">
                        <div class="mb-3">
                            <asp:Label ID="Label1" runat="server" CssClass="form-label mb-1" Text="Identificacion"></asp:Label>
                            <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
                     
                        </div>
                        <div class="mb-3">
                            <asp:Label ID="Label2" runat="server" CssClass="form-label mb-1" Text="Contraseña"></asp:Label>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" type="password"></asp:TextBox>
                        </div>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
           
                        <asp:Button ID="btSubmit" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btSubmit_Click" />
                    </form>
                </asp:Panel>
               
          
             
        </section>
   
        
    
    </main>
    <footer>

    </footer>
   
       <script src="Scripts/bootstrap.min.js" ></script>
</body>
</html>
