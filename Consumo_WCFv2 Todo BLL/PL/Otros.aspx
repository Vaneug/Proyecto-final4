<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Otros.aspx.cs" Inherits="PL.Otros" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="Recursos/Estilos/Estilos_TXT.css" rel="stylesheet" />
    <link href="Recursos/Estilos/Estilos_Botones.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <asp:Label ID="lbl_Otro" runat="server" Text="Id Otro: "></asp:Label>
        &nbsp;
            <asp:TextBox CssClass="CajasTextos" ID="txt_filtrar" runat="server"></asp:TextBox>
        &nbsp;
             &nbsp;
             &nbsp;
             &nbsp;
            <asp:ImageButton ID="btnFiltrar" src="Recursos/Imagenes/lupa.png" runat="server" Height="30px" Width="30px" OnClick="btnFiltrar_Click" />
        &nbsp;
             &nbsp;
            <input id="btn_editar" type="button" value="Editar" onclick="toggle()" />
        <br />
        <br />
        <br />
    </div>
    <div id="div_Editar" style="display: none">
        <p>Edición de Datos de Otros.</p>
        <div>
            <div class="TextoPrimero">
                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_IdOtro" runat="server" Text="Id: "></asp:Label>
                    <asp:TextBox CssClass="CajasTextos" ID="txt_IdOtro" runat="server" Height="31px" Width="375px"></asp:TextBox>
                </div>
                <div>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_TipoOtro" runat="server" Text="Tipo: "></asp:Label>
                    <asp:TextBox CssClass="CajasTextos" ID="txt_TipoOtro" runat="server" Height="31px" Width="375px"></asp:TextBox>
                </div>
        </div>

        <br />
        <div class="TextoPrimero">
            <div>
                <asp:Label ID="lbl_MarcaOtro" runat="server" Text="Marca: "></asp:Label>
                <asp:TextBox CssClass="CajasTextos" ID="txt_MarcaOtro" runat="server" Height="31px" Width="375px"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lbl_ModeloOtro" runat="server" Text="Modelo: "></asp:Label>
                <asp:TextBox CssClass="CajasTextos" ID="txt_ModeloOtro" runat="server" Height="31px" Width="375px"></asp:TextBox>
            </div>
        </div>
        <br />
        <div style="text-align: right; margin-right: 220px;">
            <asp:ImageButton ID="btn_Guardar" src="Recursos/Imagenes/modificar.png" Height="30px" Width="30px" runat="server" Text="Actualizar" OnClick="btn_Guardar_Click" />
            &nbsp;
                        &nbsp;
                        <asp:ImageButton ID="btn_Eliminar" src="Recursos/Imagenes/eliminar.png" Height="30px" Width="30px" runat="server" Text="Eliminar" OnClick="btn_Eliminar_Click" />
            &nbsp;
                        &nbsp;
                        <asp:ImageButton ID="btnInsertar" src="Recursos/Imagenes/guardar.png" Height="30px" Width="30px" runat="server" Text="Insertar" OnClick="btn_Insertar_Click" />
        </div>

    </div>
    <br />

    </div>
            <div>
                <asp:GridView ID="dgv_Otro" runat="server" Width="900px"></asp:GridView>
            </div>
</asp:Content>
