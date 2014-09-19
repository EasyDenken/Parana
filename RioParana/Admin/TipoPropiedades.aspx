<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="TipoPropiedades.aspx.cs" Inherits="RioParana.Admin.TipoPropiedades" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content runat="server" ContentPlaceHolderID="head" ID="idHead">
    <script language="javascript" type="text/javascript">
        function Resaltar_On(GridView) {
            if (GridView != null) {
                GridView.originalBgColor = GridView.style.backgroundColor;
                GridView.style.backgroundColor = "#0000FF";
                GridView.style.color = "#FFFFFF"
                GridView.style.cursor = "hand";
            }
        }

        function Resaltar_Off(GridView) {
            if (GridView != null) {
                GridView.style.backgroundColor = GridView.originalBgColor;
                GridView.style.color = "#000000";
            }
        }
</script>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="idHolder" runat="server">
    <div style="margin-top:25px;">
    <asp:UpdatePanel ID="upGrilla" UpdateMode="Conditional" runat="server">
        <ContentTemplate>
        
        <asp:GridView ID="dgTiposInmueble" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
            DataSourceID="odsTipoInmuebles" EnableModelValidation="True" 
            ForeColor="#333333" GridLines="None" Width="690px" Font-Names="Arial" 
            Font-Size="10pt" onrowdatabound="dgTiposInmueble_RowDataBound" 
            onselectedindexchanged="dgTiposInmueble_SelectedIndexChanged" 
            DataKeyNames="IdTipoDeInmueble">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="IdTipoDeInmueble" Visible="False" />
                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                <asp:BoundField DataField="TipoPadre" HeaderText="Padre" />
                <asp:BoundField DataField="NombreMenu" HeaderText="Menu" />
                <asp:BoundField DataField="Mostrar" HeaderText="Mostrar" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <asp:ObjectDataSource ID="odsTipoInmuebles" runat="server" 
            SelectMethod="TraerTipoDeInmuebles" TypeName="RioParanaBLL.TiposBLL">
        </asp:ObjectDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>
    </div>
    <div>
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
                        <asp:Button ID="btnNuevo" runat="server" OnClick="btnFicha_Click" 
                            Text="Nuevo" />
                        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                        <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" TargetControlID="btnEliminar"
                            ConfirmText="¿Desea Eliminar la Propiedad?">
                        </cc1:ConfirmButtonExtender>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:UpdateProgress ID="upPGuardar" runat="server" AssociatedUpdatePanelID="UpdatePanel3">
                <ProgressTemplate>
                    Cargando...
                </ProgressTemplate>
            </asp:UpdateProgress>
    </div>
</asp:Content>
