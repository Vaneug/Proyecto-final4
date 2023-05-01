<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PL.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!--<link href="Content/bootstrap.css" rel="stylesheet" /> -->
    <!--<link href="styles/style.css" rel="stylesheet" /> -->
    <link href="Recursos/Estilos/Estilos_Nosotros.css" rel="stylesheet" />

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
    <h3>Contactenos.</h3>
    <address>
        <strong>Dirección: </strong>
        San José, Provincia, Escazú Frente a Hotel
        <br />
        Real Intercontinental San José.<br />
        <strong>Telefono: </strong>
        (+506) 8888-8888
        <br />
        <strong>Ventas:</strong> <a href="ventas@ejemplo.com">Ventas@ejemplo.com</a>
    </address>

    <strong>Sucursales: </strong>
    <br />
    <address>
        <strong>Multiplaza Escazu: </strong>Nos encontramos en San José, Provincia, Escazú Frente a Hotel
        <br />
        Real Intercontinental San José.
        <br />
        <br />
        <strong>Multiplaza del este: </strong>Nos encontramos en San José, Provincia, Curridabat,
        <br />
        frente al Registro Nacional<br />
        <br />
        <strong>Plaza Lincoln: </strong>Moravia, Los Colegios, San José
    </address>
    <br />

    <div class="Mapas">
        <h3>Ubicanos en: </h3>
        <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d4540.398232988043!2d-84.15167629051084!3d9.943880902221627!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8fa0fb698e1ba15b%3A0x781267d196d66afc!2sMultiplaza%20Escaz%C3%BA!5e0!3m2!1ses!2scr!4v1682438047310!5m2!1ses!2scr"
            width="400" height="300" style="border: 0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
        <div class="LogosWazeGoogle">
            <br />
            <img id="LogoWaze" src="Recursos/Imagenes/waze.png" alt="Waze Logo" />
            &nbsp;&nbsp;
            <img id="LogoGoogle" src="Recursos/Imagenes/Google.png" alt="Google Maps Logo" />
        </div>
    </div>
</body>
</html>
