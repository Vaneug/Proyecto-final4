<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="PL.Contacto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!--<link href="Content/bootstrap.css" rel="stylesheet" /> -->
    <!--<link href="styles/style.css" rel="stylesheet" /> -->
    <link href="Recursos/Estilos/Estilos_Contacto.css" rel="stylesheet" />
    <title></title>
</head>
<a href="Index.aspx">
    <center>
        <img id="logo" src="Recursos/Imagenes/Logo.png" alt="Logo" /></center>
</a>
<header>
    <nav>
        <ul>
            <li><a id="Enlace" href="#">Usuarios</a></li>
            <li><a id="Enlace" href="#">Inventario</a></li>
            <li><a id="Enlace" href="Contacto.aspx">Contactenos</a></li>
            <li><a id="Enlace" href="Contact.aspx">Nosotros</a></li>
        </ul>
    </nav>
</header>
<body>
    <br />
    <br />
    <br />
    <br />
    <h1>Por favor ingresa tu información</h1>
    <label>Nombre completo</label><br />
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

    <label>Corre electronico</label><br />
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    
    <label>Níumero de telefonico</label><br />
    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>

    <label>Número de cedula</label><br />
    <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>

    <label>Mensaje:</label><br />
    <asp:TextBox ID="txtMensaje" runat="server"></asp:TextBox>
    <textarea id="TextArea1" cols="20" rows="2"></textarea>

    <div id="after_submit"></div>
    <form id="contact_form" action="#" method="POST" enctype="multipart/form-data">
        <div class="row">
            <label class="required" for="name">Your name:</label><br />
            <input id="name" class="input" name="name" type="text" value="" size="30" /><br />
            <span id="name_validation" class="error_message"></span>
        </div>
        <div class="row">
            <label class="required" for="email">Your email:</label><br />
            <input id="email" class="input" name="email" type="text" value="" size="30" /><br />
            <span id="email_validation" class="error_message"></span>
        </div>
        <div class="row">
            <label class="required" for="message">Your message:</label><br />
            <textarea id="message" class="input" name="message" rows="7" cols="30"></textarea><br />
            <span id="message_validation" class="error_message"></span>
        </div>

        <input id="submit_button" type="submit" value="Send email" />
    </form>

</body>
</html>
