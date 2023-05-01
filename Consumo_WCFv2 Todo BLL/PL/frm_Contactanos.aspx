<%@ Page Title="" Language="C#" MasterPageFile="~/Prueba.Master" AutoEventWireup="true" CodeBehind="frm_Contactanos.aspx.cs" Inherits="PL.frm_Contactanos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="Recursos/Estilos/Estilos_Contacto.css" rel="stylesheet" />
        <style type="text/css">
            #TextArea1 {
                height: 127px;
                width: 405px;
            }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <a href="Index.aspx">
        <center>
            <img id="logo" src="Recursos/Imagenes/Logo.png" alt="Logo" /></center>
    </a>
    <header>
        <nav>
            <ul>
                <li><a id="Enlace" href="#">Usuarios</a></li>
                <li><a id="Enlace" href="#">Inventario</a></li>
                <li><a id="Enlace" href="frm_Contactanos.aspx">Contactenos</a></li>
                <li><a id="Enlace" href="Contact.aspx">Nosotros</a></li>
            </ul>
        </nav>
    </header>
    <body>
        <br />
        <br />
        <br />
        <br />
        <h1 align="center" >Por favor ingresa tu información</h1>
        <label>Nombre completo</label><br />
        <asp:TextBox ID="txtNombre" runat="server" Width="239px"></asp:TextBox><br />

        <label align="center">Corre electronico</label><br />
        <asp:TextBox ID="txtEmail" runat="server" Width="239px"></asp:TextBox><br />

        <label align="center">Níumero de telefonico</label><br />
        <asp:TextBox ID="txtTelefono" runat="server" align="center" Width="239px"></asp:TextBox><br />

        <label align="center">Número de cedula</label><br />
        <asp:TextBox ID="txtCedula" runat="server" align="center"></asp:TextBox><br />

        <label>Mensaje:</label><br />

        <textarea id="TextArea1"></textarea>
</asp:Content>
