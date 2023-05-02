<%@ Page Title="" Language="C#" MasterPageFile="~/Site_Distribucion.Master" AutoEventWireup="true" CodeBehind="Distribución.aspx.cs" Inherits="PL.Distribución" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <br />
    <h2>Asignar equipo a empleado</h2>

        <div>
            <asp:Label ID="lbl_Distribucion" runat="server" Text="Id Distribucion: "></asp:Label>
            &nbsp;
            <asp:TextBox CssClass="CajasTextos" ID="txt_filtrar" runat="server" Height="31px" Width="360px"></asp:TextBox>
            &nbsp;
             &nbsp;
            <asp:ImageButton ID="btnFiltrar" src="Recursos/Imagenes/lupa.png" runat="server" Height="30px" Width="30px" OnClick="btnFiltrar_Click" />
            &nbsp;
             &nbsp;
            <input class="Botones" id="btn_editar" type="button" value="Editar" onclick="toggle()" />
         </div>   
        <div id="div_Editar"   style="display: block; margin-top: 20px; ">
        <div>
            <asp:Label ID="lbl_IdDistribucion" runat="server" Text="Id: "></asp:Label>
            &nbsp;
                    &nbsp;
    &nbsp;<asp:TextBox  CssClass="CajasTextos" ID="txt_IdDistribucion" runat="server" Height="31px" Width="340px"></asp:TextBox>
            &nbsp;
                    &nbsp;
                    <asp:Label ID="lbl_IdEmpleado" runat="server" Text="Id Empleado: "></asp:Label>
            &nbsp;
                    &nbsp;
                    <asp:DropDownList CssClass="CajasTextos" ID="ddl_IdEmpleado" runat="server" Height="31px" Width="340px"></asp:DropDownList>
            &nbsp;
                    &nbsp;
                    <asp:Label ID="lbl_IdEquipo" runat="server" Text="Id Equipo: "></asp:Label>
            &nbsp;
                    &nbsp;
                    <asp:DropDownList CssClass="CajasTextos" ID="ddl_IdEquipo" runat="server" Height="31px" Width="340px"></asp:DropDownList>
            &nbsp;
                    &nbsp;
                    <div style="text-align: center; margin-top: 10px;">
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
        <asp:GridView ID="dgv_Distribucion" runat="server" Width="100%"></asp:GridView>
    </div>
</asp:Content>

