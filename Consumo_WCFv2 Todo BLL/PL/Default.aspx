<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PL._Default" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">

            <br />
            <br />
            <div>
            <asp:Label ID="lblProducto" runat="server" Text="Id Teclado: "></asp:Label>
            &nbsp;
            <asp:TextBox ID="txt_filtro" runat="server"></asp:TextBox>
             &nbsp;
             &nbsp;
             &nbsp;
             &nbsp;
            <asp:ImageButton ID="btnFiltrar" src="Recursos/Imagenes/lupa.png" runat="server" Height="30px" Width="30px" OnClick="btnFiltrar_Click" />
             &nbsp;
             &nbsp;
            <input id="btn_editar" type="button" value="Habilitar Edición" onclick="toggle()" />
                <br />
                <br />
                <br />
            </div>
            <div id="div_Editar" class="jumbotron" style="display:block">
                <p class="lead">Edición de Datos de Teclados.</p>
                <div>
                    <asp:Label ID="lbl_IdTeclado" runat="server" Text="Id: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_IdTeclado" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lbl_TipoTeclado" runat="server" Text="Tipo: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_TipoTeclado" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lbl_MarcaTeclado" runat="server" Text="Marca: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_MarcaTeclado" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lbl_ModeloTeclado" runat="server" Text="Modelo: "></asp:Label> 
                    &nbsp;
                    &nbsp;
                    <asp:TextBox ID="txt_ModeloTeclado" runat="server" Height="31px" Width="375px"></asp:TextBox>
                    <br />
                    <br />
                    <div style="text-align:center">
                        <asp:Button ID="btn_Guardar" runat="server" Text="Actualizar" OnClick="btn_Guardar_Click"  />
                        &nbsp;
                        &nbsp;
                        <asp:Button ID="txt_Eliminar" runat="server" Text="Eliminar" OnClick="txt_Eliminar_Click"/>
                        &nbsp;
                        &nbsp;
                        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btn_Insertar_Click"  />
                    </div>
                   
                </div>
                <asp:DropDownList ID="ddl_opciones" runat="server">
                </asp:DropDownList>
                <br />
        
            </div>
            <div>
                <asp:GridView ID="GV_Tabla" runat="server" Width="900px"></asp:GridView>
            </div>
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

</asp:Content>
