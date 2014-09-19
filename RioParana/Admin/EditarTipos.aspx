<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="EditarTipos.aspx.cs" Inherits="RioParana.Admin.EditarTipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
    <table style="font-family:Arial">
        <tr>
            <td>
                
                Tipo</td>
            <td>
                <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTipo" runat="server" ControlToValidate="txtTipo"
                    ErrorMessage="El Tipo es un dato obligatorio"></asp:RequiredFieldValidator>
                    </td>
        </tr>
        <tr>
            <td>
            
                Padre</td>
            <td>
                <asp:TextBox ID="txtPadre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPadre" runat="server" ControlToValidate="txtPadre"
                    ErrorMessage="El Padre es un dato obligatorio"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
            
                Menu</td>
            <td>
                <asp:TextBox ID="txtMenu" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMenu"
                    ErrorMessage="El Menu es un dato obligatorio"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
            
                Mostrar</td>
            <td>
                
                <asp:RadioButtonList ID="rbMostrar" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem Value="SI">SI</asp:ListItem>
                    <asp:ListItem Value="NO">NO</asp:ListItem>
                </asp:RadioButtonList>
                
            </td>
        </tr>
        <tr>
            <td colspan="2">
            
                <asp:Button ID="btnGuardar" Text="Guardar" runat="server" 
                    onclick="btnGuardar_Click" />
            
                <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" Width="64px" 
                    onclick="btnCancelar_Click"/>
            
            </td>
        </tr>
    </table>
</div>
</asp:Content>
