<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="PL.Empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
    <style>
    nav {
    float: left;
    background-color: aquamarine;
}

    nav ul {
        list-style: none;
        overflow: hidden;
    }

        nav ul li {
            float: left;
            width: 250px;
        }

            nav ul li a {
                display: block;
                padding: 10px;
                text-decoration: none;
                width: 240px;
            }

            nav ul li:hover {
                background: none;
                border-radius: 15px;
            }
        </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
          <header>
    <nav>
        <ul>
            <li><a id="Enlace" href="Empleados.aspx">Usuarios</a></li>
            <li><a id="Enlace" href="Productos.aspx">Inventario</a></li>
            <li><a id="Enlace" href="frm_Contactanos.aspx">Contactenos</a></li>
            <li><a id="Enlace" href="Contact.aspx">Nosotros</a></li>
        </ul>
    </nav>
</header>

            <br/> <br/><br/>
             &nbsp;
             &nbsp;
             &nbsp;
             &nbsp;
            <asp:Label ID="lblfiltrar" runat="server" Text="Filtrar"></asp:Label >
             &nbsp;
             &nbsp;
            <asp:ImageButton src="Recursos/Imagenes/lupa.png" runat="server" Height="25px" Width="25px" />
             &nbsp;
             &nbsp;
            <asp:TextBox ID="Txtfiltrar" runat="server"></asp:TextBox>
             &nbsp;
             &nbsp;
             &nbsp;
             &nbsp;
            &nbsp;
            &nbsp;
            <asp:Label ID="lblguardar" runat="server" Text="Guadar"></asp:Label >
             &nbsp;
             &nbsp;
            <asp:ImageButton src="Recursos/Imagenes/guardar.png" runat="server" Height="25px" Width="25px" />
             &nbsp;
             &nbsp;
             &nbsp;
             &nbsp;
            &nbsp;
            &nbsp;
            <asp:Label ID="lblmodificar" runat="server" Text="Modificar"></asp:Label >
             &nbsp;
             &nbsp;
            <asp:ImageButton src="Recursos/Imagenes/modificar.png" runat="server" Height="25px" Width="25px" />
             &nbsp;
             &nbsp;
             &nbsp;
             &nbsp;
            &nbsp;
            &nbsp;
            <asp:Label ID="lbleliminar" runat="server" Text="Eliminar"></asp:Label >
             &nbsp;
             &nbsp;
            <asp:ImageButton src="Recursos/Imagenes/Eliminar.png" runat="server" Height="25px" Width="25px" />

            <br /> <br/><br/>

            <asp:Label ID="lblusuario" runat="server" Text="ID-Usuario"></asp:Label>
             &nbsp;
             &nbsp;
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br /> <br/>
             <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
             &nbsp;
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br /> <br/>
             <asp:Label ID="lblRol" runat="server" Text="ID-Rol"></asp:Label>
             &nbsp;
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRol" runat="server"></asp:TextBox>
            <br /> <br/>
             <asp:Label ID="lblTelefono" runat="server" Text="Teléfono"></asp:Label>
             &nbsp;
             &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txttelefono" runat="server"></asp:TextBox>
            <br /> <br/>
             <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
             &nbsp;
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /> <br/>
            <br /> <br/>
            </div>
    </form>
</body>
</html>
