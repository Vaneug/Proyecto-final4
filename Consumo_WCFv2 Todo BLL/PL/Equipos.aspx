<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="PL.Equipos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Recursos/Estilos/Estilos_TXT.css" rel="stylesheet" />
    <link href="Recursos/Estilos/Estilos_Botones.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        &nbsp;&nbsp;<img src="Recursos/Imagenes/Equipos.png" style=" width: 200px;"/>&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_Equipo" runat="server" Text="Id Equipo: "></asp:Label>
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
        <p class="lead">Edición de Datos de Equipo.</p>
        <div>
            <div class="TextoPrimero" align="center">
                <div>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_IdEquipo" runat="server" Text="Id: "></asp:Label>
                    <asp:TextBox CssClass="CajasTextos" ID="txt_IdEquipo" runat="server" Height="31px" Width="360px"></asp:TextBox>
                </div>
                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_Estado" runat="server" Text="Estado: "></asp:Label>
                    <asp:DropDownList CssClass="CajasTextos" ID="ddlEstado" runat="server"  Height="31px" Width="360px"></asp:DropDownList>
                </div>
            </div>
            <br />

           <div class="TextoPrimero" align="center">
                <div>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_TipoTorre" runat="server" Text="Tipo Torre: "></asp:Label>
                    <asp:DropDownList CssClass="CajasTextos" ID="ddltipotorre" runat="server"  Height="31px" Width="360px"></asp:DropDownList>
                </div>
                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_TipoTeclado" runat="server" Text="Tipo Teclado: "></asp:Label>
                    <asp:DropDownList CssClass="CajasTextos" ID="ddltipoteclado" runat="server"  Height="31px" Width="360px"></asp:DropDownList>
                </div>
            </div>

            <br />

            <div class="TextoPrimero" align="center">
                <div>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_TipoRaton" runat="server" Text="Tipo Raton: "></asp:Label>
                    <asp:DropDownList CssClass="CajasTextos" ID="ddlTipoRaton" runat="server"  Height="31px" Width="360px"></asp:DropDownList>
                </div>
                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_TipoOtro" runat="server" Text="Tipo Otro: "></asp:Label>
                    <asp:DropDownList CssClass="CajasTextos" ID="ddlTipoOtro" runat="server"  Height="31px" Width="360px"></asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="TextoPrimero" align="center">
                <div>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_TipoDisco" runat="server" Text="Tipo Disco:  " ></asp:Label>
                    <asp:DropDownList CssClass="CajasTextos" ID="ddltipodisco" runat="server" Height="31px" Width="360px"></asp:DropDownList>
                </div>
                <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_MarcaMemoria" runat="server" Text="Marca Memoria: "></asp:Label>
                    <asp:DropDownList CssClass="CajasTextos" ID="ddlmarcamemoria" runat="server"  Height="31px" Width="360px"></asp:DropDownList>
                </div>
            </div>

            <br />

            <div class="TextoPrimero" align="center">
                <div>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_MarcaMonitor" runat="server" Text="Marca Monitor: "></asp:Label>
                    <asp:DropDownList CssClass="CajasTextos" ID="ddlmarcamonitor" runat="server"  Height="31px" Width="360px"></asp:DropDownList>
                </div>
            </div>
            <br />
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
        <asp:GridView ID="dgv_Equipo" runat="server" Width="1000px"></asp:GridView>
    </div>
</asp:Content>
