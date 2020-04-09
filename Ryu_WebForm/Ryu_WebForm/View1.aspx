<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View1.aspx.cs" Inherits="Ryu_WebForm.View1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        var cookie = getCookie('testCookie');
        if (cookie != "") {
            //alert("쿠키값은 : " + cookie);
        }

        function getCookie(name) {
            var nameOfCookie = name + "=";
            var x = 0;
            while (x <= document.cookie.length) {
                var y = (x + nameOfCookie.length);
                if (document.cookie.substring(x, y) == nameOfCookie) {
                    if ((endOfCookie = document.cookie.indexOf(";", y)) == -1)
                        endOfCookie = document.cookie.length;
                    return unescape(document.cookie.substring(y, endOfCookie));
                }
                x = document.cookie.indexOf(" ", x) + 1;
                if (x == 0)
                    break;
            }
            return "";
        }
    </script>

    <h1>데이터 불러오기</h1>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>

    <asp:Button runat="server" ID="btnClick" text="testCookie값 확인" OnClick="btnClick_Click"/>
    <asp:TextBox runat="server" ID="txtCookie"></asp:TextBox>
</asp:Content>
