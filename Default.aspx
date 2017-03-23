<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="learn.january.week01.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Toplama İşlemi</title>
</head>
<body>
    <!-- Define-->
    <h1>Ocak / 1.Hafta</h1>
    <p>Asp.Net Program Yazımı</p>
    <!--Criteria-->
    <ol>
        <li>Oluşturulan bir formda iki text alanından birinci alana girilen sayıdan ikinci alana girilen sayıya kadar olan sayıların toplamını alan program kodlarını yazınız</li>
        <li>İlk sayı ikinci sayıdan büyükse hata mesajı verecektir.</li>
    </ol>
    <!-- Form-->
    <form id="form1" runat="server">
        <div>
            <!-- First Text-->
            <asp:TextBox ID="txtFirst" runat="server" TextMode="SingleLine"></asp:TextBox>
            <br />
            <!-- Second Text-->
            <asp:TextBox ID="txtSecond" runat="server" TextMode="SingleLine"></asp:TextBox>
            <br />
            <!-- Proc Strat-->
            <asp:Button ID="btnSum" runat="server" Text="Topla" OnClick="btnSum_Click" />
            <br />
             <!-- Message-->
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>