<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="PL.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <!--<link href="styles/style.css" rel="stylesheet" /> -->
    <link href="Recursos/Estilos/Estilos_Inicio.css" rel="stylesheet" />
    <link href="Recursos/Estilos/Estilos_Botones.css" rel="stylesheet" />
    <title></title>
</head>
<a href="Index.aspx">
        <center>
            <img id="logo" src="Recursos/Imagenes/Logo.png" alt="Logo" /></center>
    </a>
<body>
    <div class="sidebar">
        <a id="Enlace" href="frm_Torres.aspx">Torres</a>
        <a id="Enlace" href="frm_Teclados.aspx">Teclados</a>
        <a id="Enlace" href="Monitores.aspx">Monitores</a>
        <a id="Enlace" href="Ratones.aspx">Ratones</a>
        <a id="Enlace" href="Discos.aspx">Discos</a>
        <a id="Enlace" href="Memorias.aspx">Memorias</a>
        <a id="Enlace" href="Equipos.aspx">Equipos</a>
        <a id="Enlace" href="Otros.aspx">Otros</a>
    </div>

    <div class="content">
        <form id="form1" runat="server">
            <br />
            <br />
            <div>

                 
         <asp:Label ID="lblProducto" runat="server" Text="Id Torres: "></asp:Label>
                &nbsp;
         <asp:TextBox ID="txtaFiltProd" runat="server"></asp:TextBox>
                &nbsp;
             &nbsp;
             &nbsp;
             &nbsp;
        <asp:ImageButton ID="btnFiltrar" src="Recursos/Imagenes/lupa.png" runat="server" Height="30px" Width="30px" OnClick="btnFiltrar_Click" />
              &nbsp;
             &nbsp;
           <input id="btn_editar" type="button"  value="Editar"  onclick="toggle()" />
                <br />
                <br />
                <br />
            </div>
            <div id="div_Editar" style="display:none">
                <p class="lead">Edición de Datos de Torres.</p>
                <div>
                    <asp:Label ID="lbl_IdTorre" runat="server" Text="Id: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_IdTorre" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    &nbsp;
                    &nbsp;
                    <asp:Label ID="lbl_MarcaTorre" runat="server" Text="Marca: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_MarcaTorre" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lbl_ModeloTorre" runat="server" Text="Modelo: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_ModeloTorre" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    &nbsp;
                    &nbsp;
                    <asp:Label ID="lbl_IdDisco" runat="server" Text="Id Disco: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_IdDisco" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                     <asp:Label ID="lbl_IdMemoria" runat="server" Text="Id Memoria: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_IdMemoria" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    <div style="text-align:center">
                        <asp:ImageButton ID="btn_Guardar" src="Recursos/Imagenes/modificar.png" Height="30px" Width="30px" runat="server" Text="Actualizar" OnClick="btn_Guardar_Click"  />
                        &nbsp;
                        &nbsp;
                        <asp:ImageButton ID="btn_Eliminar" src="Recursos/Imagenes/eliminar.png" Height="30px" Width="30px" runat="server" Text="Eliminar" OnClick="btn_Eliminar_Click"/>
                        &nbsp;
                        &nbsp;
                        <asp:ImageButton ID="btnInsertar" src="Recursos/Imagenes/guardar.png" Height="30px" Width="30px" runat="server" Text="Insertar" OnClick="btn_Insertar_Click"  />
                    </div>
                   
                </div>
                <br />
        
            </div>
            <div>
                <asp:GridView ID="dgv_Productos" runat="server" Width="900px"></asp:GridView>
            </div>
        </form>
    </div>
</body>
</html>
<script>

        function toggle() {

            var ele = document.getElementById("div_Editar");

            if (ele.style.display == "block") {

                ele.style.display = "none";
            }
            else {

                ele.style.display = "block";
            }
        }

</script>
