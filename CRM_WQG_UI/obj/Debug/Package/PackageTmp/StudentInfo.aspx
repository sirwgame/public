<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="StudentInfo.aspx.cs" Inherits="CRM_WQG_UI.StudentInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="width: 100%; margin-left: 3px;">
        <table style="width: 100%; height: 100%; padding-top: 1px; border-right: #99ccff 0.1em solid;
            border-left: #99ccff 0.1em solid;">
            <tr>
                <td colspan="3" style="background-image: url('Images/main_top_bg.gif'); height: 19px;">
                    <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="Images/main_top_1.gif"
                        Width="21px" />学生信息</td>
            </tr>
            <tr>
                <td colspan="3" style="height: 430px; vertical-align: top; text-align: left;">
                    <asp:GridView ID="gvUser" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
                        Width="100%" AutoGenerateColumns="False" Font-Size="13px" Font-Names="tahoma,arial"
                        Style="text-align: center" AllowPaging="True" 
                        onpageindexchanging="gvUser_PageIndexChanging" 
                        onrowcommand="gvUser_RowCommand">
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <EmptyDataRowStyle Height="20px" />
                        <RowStyle BackColor="#EFF3FB" Font-Size="12px" />
                        <EditRowStyle BackColor="#2461BF" Height="20px" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="SkyBlue" Font-Bold="True" ForeColor="White" Font-Size="12px"
                            Height="12px" />
                        <AlternatingRowStyle BackColor="White" />
                        <PagerTemplate>
                            当前第
                            <%--((GridView)Container.NamingContainer)就是为了得到当前的控件--%>
                            <asp:Label ID="LabelCurrentPage" runat="server" Text="<%# ((GridView)Container.NamingContainer).PageIndex + 1 %>"></asp:Label>页/共
                            <%--//得到分页页面的总数--%>
                            <asp:Label ID="LabelPageCount" runat="server" Text="<%# ((GridView)Container.NamingContainer).PageCount %>"></asp:Label>页
                            <%--如果该分页是首分页，那么该连接就不会显示了.同时对应了自带识别的命令参数CommandArgument--%>
                            <asp:LinkButton ID="LinkButtonFirstPage" runat="server" CommandArgument="First" CommandName="Page"
                                Visible='<%#((GridView)Container.NamingContainer).PageIndex != 0 %>' ForeColor="White"
                                Font-Underline="True">首页</asp:LinkButton>
                            <asp:LinkButton ID="LinkButtonPreviousPage" runat="server" CommandArgument="Prev"
                                CommandName="Page" Visible='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>'
                                Font-Underline="True" ForeColor="White">上一页</asp:LinkButton>
                            <%--如果该分页是尾页，那么该连接就不会显示了--%>
                            <asp:LinkButton ID="LinkButtonNextPage" runat="server" CommandArgument="Next" CommandName="Page"
                                Visible='<%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>'
                                ForeColor="White" Font-Underline="True">下一页</asp:LinkButton>
                            <asp:LinkButton ID="LinkButtonLastPage" runat="server" CommandArgument="Last" CommandName="Page"
                                Visible='<%# ((GridView)Container.NamingContainer).PageIndex != ((GridView)Container.NamingContainer).PageCount - 1 %>'
                                ForeColor="White" Font-Underline="True">尾页</asp:LinkButton>
                        </PagerTemplate>
                        <Columns>
                            <asp:BoundField DataField="userId" HeaderText="学生编号" />
                            <asp:BoundField DataField="loginId" HeaderText="学生学号" />
                            <asp:BoundField DataField="loginPwd" HeaderText="登录密码" />
                            <asp:BoundField DataField="name" HeaderText="学生姓名" />
                            <asp:BoundField DataField="age" HeaderText="学生年龄" />
                            <asp:BoundField DataField="sex" HeaderText="学生性别" />
                            <asp:BoundField DataField="phone" HeaderText="联系方式" />
                            <asp:BoundField DataField="address" HeaderText="家庭住址" />
                            <asp:TemplateField HeaderText="操作">
                                <ItemTemplate>
                                   <asp:LinkButton ID="EditUser" runat="server" CommandName="editStudent" CommandArgument='<%#Eval("userId")%>'>编辑</asp:LinkButton>
                                   <asp:LinkButton ID="DeleteUser" runat="server" CommandName="deleteStudent" CommandArgument='<%#Eval("userId")%>'>删除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    </td>
            </tr>
            <tr>
                <td colspan="3" style="background-image: url('../Images/bottom_bg.gif'); height: 25px;
                    width: 929px;" align="center" valign="middle">
                    Copyright © 2018 WEB教学实习.All Rights Reserved
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
