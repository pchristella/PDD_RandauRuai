<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RR_luckydraw_result_staff.aspx.cs" Inherits="PDD_RandauRuai.Module.LuckyDraw.RR_luckydraw_result_staff" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>    
        
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <div style="text-align:center">
            <asp:Label align="center" runat="server" Text="******THE WINNERS ARE******" Font-Size="30px"></asp:Label>
        </div>
        <br />
        <br />   
        <br />
        <asp:Table runat="server" HorizontalAlign="Center" CellSpacing="30" >
            <asp:TableRow CssClass="lbl_1">
                <asp:TableCell HorizontalAlign="Center">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>  
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow CssClass="lbl_1" HorizontalAlign="Center">
                <asp:TableCell HorizontalAlign="Center">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        <br />
        <br />

        <div style="text-align:center">
            <asp:Label runat="server" Text="******CONGRATULATION******" Font-Size="30px"></asp:Label><br /> 
        </div>

         <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/back.png" OnClick="ImageButton1_Click" ImageAlign="Left" />
    </div>
</asp:Content>
