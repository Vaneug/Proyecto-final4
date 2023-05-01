<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frm_Teclados.aspx.cs" Inherits="PL.frm_Teclados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Recursos/Estilos/Estilos_TXT.css" rel="stylesheet" />
    <link href="Recursos/Estilos/Estilos_Botones.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        &nbsp;&nbsp;<img src="Recursos/Imagenes/Teclado.png" style=" width: 200px;"/>&nbsp;&nbsp;&nbsp;
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
        
    </div>
    <div id="div_Editar" style="display: none">
        <p class="lead">Edición de Datos de Teclados.</p>


        <div class="TextoPrimero" align="center">
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
        <div class="TextoPrimero" align="center">
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
    <div>
        <asp:GridView ID="dgv_Teclados" runat="server" Width="900px"></asp:GridView>
    </div>

</asp:Content>
