<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RR_luckydraw_main.aspx.cs" Inherits="PDD_RandauRuai.Module.LuckyDraw.RR_luckydraw_main" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />  
    <br />
    <br />  
    <br />
    <br />  
    <br />
    <br />  
    <br />
        <asp:Table runat="server" HorizontalAlign="Center">
            <asp:TableRow>
                <asp:TableCell>
                    <br />
        <br />

                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="lbl_2">
                    <div align="center">Lucky Draw</div>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <br />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Width="50%" HorizontalAlign="Center">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/draw.png" OnClick="ImageButton1_Click" ImageAlign="Middle" />
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell><asp:ImageButton ID="ImageButton2" ImageUrl="~/img/back.png" PostBackUrl="~/Default.aspx" runat="server" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        
   
</asp:Content>
