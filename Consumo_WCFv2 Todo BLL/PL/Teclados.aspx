<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teclados.aspx.cs" Inherits="PL.Teclados" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <!--<link href="styles/style.css" rel="stylesheet" /> -->
    <link href="Recursos/Estilos/Estilos_Inicio.css" rel="stylesheet" />
    <link href="Recursos/Estilos/Estilos_Botones.css" rel="stylesheet" />
    <link href="Recursos/Estilos/Estilos_TXT.css" rel="stylesheet" />
    <title></title>
</head>
<a href="Index.aspx">
    <center>
        <img id="logo" src="Recursos/Imagenes/Logo.png" alt="Logo" /></center>
</a>

<body>

    <div class="sidebar">
        <a id="Enlace" href="Productos.aspx">Torres</a>
        <a id="Enlace" href="frm_Teclados.aspx">Teclados</a>
        <a id="Enlace" href="Monitores.aspx">Monitores</a>
        <a id="Enlace" href="Ratones.aspx">Ratones</a>
        <a id="Enlace" href="Discos.aspx">Discos</a>
        <a id="Enlace" href="Memorias.aspx">Memorias</a>
        <a id="Enlace" href="Equipos.aspx">Equipos</a>
        <a id="Enlace" href="Otros.aspx">Otros</a>
    </div>

    <div class="content">
        <br />
        <form id="form1" runat="server">
            <div>
                <br />
                <br />
                <div>
                    <asp:Label ID="lblProducto" runat="server" Text="Id Teclado: "></asp:Label>
                    &nbsp;
            <asp:TextBox CssClass="CajasTextos" ID="txtaFiltProd" runat="server" Width="153px" Height="27px"></asp:TextBox>
                    &nbsp;
             &nbsp;
             &nbsp;
             &nbsp;
            <asp:ImageButton ID="btnFiltrar" src="Recursos/Imagenes/lupa.png" runat="server" Height="30px" Width="30px" OnClick="btnFiltrar_Click" />
                    &nbsp;
             &nbsp;
           <input class="Botones" id="btn_editar" type="button" value="Editar" onclick="toggle()" />
                    <br />
                    <br />
                    <br />
                </div>
                <div id="div_Editar" style="display: none">
                    <p>Edición de Datos de Teclados.</p>


                    <div class="TextoPrimero">
                        <div>
                            &nbsp; &nbsp; &nbsp; &nbsp;
                            <asp:Label ID="lbl_IdTeclado" runat="server" Text="Id: "></asp:Label>

                            <asp:TextBox CssClass="CajasTextos" ID="txt_IdTeclado" runat="server" Height="31px" Width="375px"></asp:TextBox>
                        </div>
                        <div>
                            &nbsp; &nbsp;
                            <asp:Label ID="lbl_TipoTeclado" runat="server" Text="Tipo: "></asp:Label>

                            <asp:TextBox CssClass="CajasTextos" ID="txt_TipoTeclado" runat="server" Height="31px" Width="375px"></asp:TextBox>
                        </div>
                    </div>


                    <br />
                    <br />
                    <div class="TextoPrimero">
                        <div>
                            &nbsp;
                            <asp:Label ID="lbl_MarcaTeclado" runat="server" Text="Marca:  "></asp:Label>

                            <asp:TextBox CssClass="CajasTextos" ID="txt_MarcaTeclado" runat="server" Height="31px" Width="375px"></asp:TextBox>

                        </div>
                        <div>

                            <asp:Label ID="lbl_ModeloTeclado" runat="server" Text="Modelo: "></asp:Label>

                            <asp:TextBox CssClass="CajasTextos" ID="txt_ModeloTeclado" runat="server" Height="31px" Width="375px"></asp:TextBox>
                        </div>
                    </div>

                    <br />
                    <br />
                    <div style="text-align: right; margin-right: 220px;">
                        <asp:ImageButton ID="btn_Guardar" src="Recursos/Imagenes/modificar.png" Height="30px" Width="30px" runat="server" Text="Actualizar" OnClick="btn_Guardar_Click" />
                        &nbsp;
                        &nbsp;
                        <asp:ImageButton ID="txt_Eliminar" src="Recursos/Imagenes/eliminar.png" Height="30px" Width="30px" runat="server" Text="Eliminar" OnClick="txt_Eliminar_Click" />
                        &nbsp;
                        &nbsp;
                        <asp:ImageButton ID="btnInsertar" src="Recursos/Imagenes/guardar.png" Height="30px" Width="30px" runat="server" Text="Insertar" OnClick="btn_Insertar_Click" />
                    </div>

                </div>
                <br />

            </div>
            <div>
                <asp:GridView ID="dgv_Teclados" runat="server" Width="900px"></asp:GridView>
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
