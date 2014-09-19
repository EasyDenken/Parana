<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucBuscador.ascx.cs" Inherits="RioParana.UserControls.ucBuscador" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<div>
    <table>
        <tr>
            <td><asp:ImageButton ID="Alquiler" runat="server" Height="30px" 
                    onclick="Alquiler_Click" Width="100px" AlternateText="Alquiler"/>
            </td>
            <td><asp:ImageButton ID="Compra" runat="server" Height="30px" 
                    onclick="Compra_Click" Width="100px" AlternateText="Compra" />
            </td>
        </tr>
    </table>
    <div>
    <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows">
        <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
       <Nodes>
        <asp:TreeNode Text="1">
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
           </asp:TreeNode>
        <asp:TreeNode Text="2">
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
           </asp:TreeNode>
        <asp:TreeNode Text="3">
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
           </asp:TreeNode>
        <asp:TreeNode Text="4">
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
            <asp:TreeNode Text="New Node" Value="New Node"></asp:TreeNode>
           </asp:TreeNode>
       </Nodes>
        <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
            HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
        <ParentNodeStyle Font-Bold="False" />
        <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" 
            HorizontalPadding="0px" VerticalPadding="0px" />
    </asp:TreeView>
</div>
</div>
