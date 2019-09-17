<%@ Page Title="" Language="C#" MasterPageFile="~/student.Master" AutoEventWireup="true" CodeBehind="MyInfo.aspx.cs" Inherits="CRM_WQG_UI.MyInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="border-right: #99ccff 0.1em solid; <%--margin-top: 15px; --%> border-left: #99ccff 0.1em solid;
        width: 100%; <%--padding-top: 1px; --%> height: 95%">
        <tr>
            <td colspan="3" style="background-image: url(Images/main_top_bg.gif); width: 100%;
                height: 19px">
                <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="Images/main_top_1.gif"
                    Width="21px" />
                个人信息查看
            </td>
        </tr>
        <tr>
            <td colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                vertical-align: top; border-left: #99ccff 0.1em solid; width: 100%; border-bottom: #99ccff 0.1em solid;
                height: 430px; text-align: center">
                <table style="border: 1px solid #99ccff; margin-left: auto; width: 57%; margin-right: auto;
                    height: 347px; text-align: center;" align="center">
                    <tr>
                        <td style="border: 0.1em solid #99ccff; width: 276px; height: 17px">
                            我的学号：
                        </td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblMyID" runat="server" Width="158px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: 0.1em solid #99ccff; width: 276px; height: 17px">
                            我的姓名：
                        </td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblMyName" runat="server" Width="158px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: 0.1em solid #99ccff; width: 276px; height: 17px">
                            性 &nbsp; &nbsp; &nbsp; 别：
                        </td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblMySex" runat="server" Width="187px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: 0.1em solid #99ccff; width: 276px; height: 17px">
                            年&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 龄：
                        </td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 26px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblMyAge" runat="server" Width="158px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: 0.1em solid #99ccff; width: 276px; height: 17px">
                            电&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 话：
                        </td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 16px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblMyPhone" runat="server" Width="158px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="border: 0.1em solid #99ccff; width: 276px; height: 17px">
                            住&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 址：
                        </td>
                        <td style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid; border-left: #99ccff 0.1em solid;
                            width: 30px; border-bottom: #99ccff 0.1em solid; height: 17px">
                            <asp:Label ID="lblMyAddress" runat="server" Width="187px"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3" style="border-right: #99ccff 0.1em solid; border-top: #99ccff 0.1em solid;
                background-image: url(Images/bottom_bg.gif); border-left: #99ccff 0.1em solid;
                width: 929px; border-bottom: #99ccff 0.1em solid; height: 25px; text-align: center;">
                Copyright © 2018 WEB教学实习，All Rights Reserved.
            </td>
        </tr>
    </table>
</asp:Content>
