<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" EnableEventValidation="false"
    CodeBehind="Destacadas.aspx.cs" Inherits="RioParana.Admin.Destacadas" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="600" align="center" style="width: 600px;">
        <tr>
            <td width="175" style="text-align: right">
                <div align="right">
                    Inmueble 1:</div>
            </td>
            <td width="0" style="width: 0px;">
                &nbsp;
            </td>
            <td width="393" style="text-align: left">
                <asp:DropDownList ID="ddlInmuebles" runat="server" Width="220px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td width="175">
                <div align="right">
                    Inmueble 2:</div>
            </td>
            <td width="0" style="width: 0px;">
            </td>
            <td width="393" style="text-align: left">
                <asp:DropDownList ID="ddlInmuebles1" runat="server" Width="220px">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <table width="600" align="center" style="width: 600px;">
        <tr>
            <td width="175" style="height: 5px">
                <div align="right">
                    Inmueble 3:
                </div>
            </td>
            <td width="0" style="width: 0px; height: 5px">
            </td>
            <td width="393" style="height: 5px; text-align: left;">
                <asp:DropDownList ID="ddlInmuebles2" runat="server" Width="220px">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <table width="600" align="center" style="width: 600px;">
        <tr>
            <td width="175" style="height: 5px">
                <div align="right">
                    Inmueble 4:
                </div>
            </td>
            <td width="0" style="width: 0px; height: 5px">
            </td>
            <td width="393" style="height: 5px; text-align: left;">
                <asp:DropDownList ID="ddlInmuebles3" runat="server" Width="220px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td width="175" style="height: 5px">
                &nbsp;
            </td>
            <td width="0" style="width: 0px; height: 5px">
                &nbsp;
            </td>
            <td width="393" style="height: 5px; text-align: left;">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
            </td>
        </tr>
    </table>
    <cc1:CascadingDropDown ID="CascadingDropDown1" runat="server" TargetControlID="ddlInmuebles"
        Category="Inmuebles" ServicePath="Destacadas.asmx" ServiceMethod="getInmuebles" />
    <cc1:CascadingDropDown ID="CascadingDropDown2" runat="server" TargetControlID="ddlInmuebles1"
        ParentControlID="ddlInmuebles" ServiceMethod="getInmuebles1" ServicePath="Destacadas.asmx"
        Category="Inmuebles1" />
    <cc1:CascadingDropDown ID="CascadingDropDown3" runat="server" TargetControlID="ddlInmuebles2"
        ParentControlID="ddlInmuebles1" ServiceMethod="getInmuebles2" ServicePath="Destacadas.asmx"
        Category="Inmuebles2" />
    <cc1:CascadingDropDown ID="CascadingDropDown4" runat="server" TargetControlID="ddlInmuebles3"
        ParentControlID="ddlInmuebles2" ServiceMethod="getInmuebles3" ServicePath="Destacadas.asmx"
        Category="Inmuebles3" />
</asp:Content>
