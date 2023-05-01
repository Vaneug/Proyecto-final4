<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informacion.aspx.cs" Inherits="PL.Informacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
              <a class="navbar-brand" href="Index.aspx">Inicio</a>
              <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
              </button>
              <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                  <li class="nav-item active">
                    <a class="nav-link" href="Empleados.aspx">Empleados</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link" href="Productos.aspx">Productos</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link" href="Informacion.aspx">Acerca De</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link" href="Contacto.aspx">Contacto</a>
                  </li>
                </ul>
              </div>
            </nav>
        </div>
    </form>
</body>
</html>
