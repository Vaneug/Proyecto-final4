<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Memorias.aspx.cs" Inherits="PL.Memorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="Recursos/Estilos/Estilos_TXT.css" rel="stylesheet" />
    <link href="Recursos/Estilos/Estilos_Botones.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        &nbsp;&nbsp;<img src="Recursos/Imagenes/Memorias.png" style=" width: 200px;"/>&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_Memoria" runat="server" Text="Id Memoria: "></asp:Label>
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
        <p class="lead">Edición de Datos de Memoria.</p>
        <div>
            <div class="TextoPrimero" align="center">
                <div>
                    <asp:Label ID="lbl_IdMemoria" runat="server" Text="Id: "></asp:Label>
                    <asp:TextBox CssClass="CajasTextos" ID="txt_IdMemoria" runat="server" Height="31px" Width="375px"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="lbl_TipoMemoria" runat="server" Text="Tipo: "></asp:Label>
                    <asp:TextBox CssClass="CajasTextos" ID="txt_TipoMemoria" runat="server" Height="31px" Width="375px"></asp:TextBox>
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
                <asp:GridView ID="dgv_Memoria" runat="server" Width="900px"></asp:GridView>
            </div>
</asp:Content>
