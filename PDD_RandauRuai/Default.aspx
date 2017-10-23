<%@ Page Title="RANDAU RUAI PDD" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PDD_RandauRuai._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <br />
        <br />
        <br />
        <br />
        <div>
            <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Width="50%">
                <asp:TableRow>
                    <asp:TableCell ><asp:TextBox ID="txt_id" runat="server" Height="73px" Width="360px" placeholder="INSERT ID/IC NO" Font-Bold="True" Font-Size="45px"></asp:TextBox></asp:TableCell>
                    <asp:TableCell><asp:ImageButton ID="ImageButton1" OnClick="ImageButton1_Click" ImageUrl="~/img/check.png" runat="server" /></asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell columnspan="2"><asp:Label align="center" runat="server" ID="lbl_error" Text="Label" Visible="False"></asp:Label></asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <br /> 
            <br />  

    <asp:Table ID="Table2" HorizontalAlign="Center" runat="server">  
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_1">Name:&nbsp;&nbsp;</asp:TableCell>
            <asp:TableCell CssClass="lbl_1"><asp:TextBox ID="txt_name" runat="server" Enabled="False" Height="50px" Width="300px" Font-Size="25px"></asp:TextBox></asp:TableCell>    
        </asp:TableRow>
        
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell CssClass="lbl_1">Department:&nbsp;&nbsp;</asp:TableCell>
            <asp:TableCell CssClass="lbl_1"><asp:TextBox ID="txt_dept" runat="server" Enabled="False" Height="50px" Width="300px" Font-Size="25px"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell CssClass="lbl_1">Phone No:&nbsp;&nbsp;</asp:TableCell>
            <asp:TableCell CssClass="lbl_1"><asp:TextBox ID="txt_telno" runat="server" Enabled="False" Height="50px" Width="300px" Font-Size="25px"></asp:TextBox></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell><asp:ImageButton ID="ImageButton3" OnClick="ImageButton3_Click" ImageAlign="left" ImageUrl="~/img/luckydraw.png" runat="server" /></asp:TableCell>
            <asp:TableCell HorizontalAlign="Right"><asp:ImageButton ID="ImageButton2" OnClick="ImageButton2_Click" ImageUrl="~/img/checkin.png" runat="server" /></asp:TableCell>
        </asp:TableRow>
            </asp:Table>
        </div>
    </div>
</asp:Content>