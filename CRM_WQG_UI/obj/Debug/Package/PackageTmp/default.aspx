<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CRM_WQG_UI._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登录</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div class='body_main'> 
  <!-- start main content -->
  <div class='index_box' style='margin-top:20px;'>
    <div style="position:fixed;color:red;margin:70px 0 0 450px;font-size:16px;Z-index:100;display:block;" id="hint"></div>
    <div class='box_title'>
      <div class='text_content'>
        <h1>学生登录</h1>
      </div>
    </div>
    <div class='box_main'>
      <div id="register" class="register">
        <form runat="server" id="form" action="#" method="post">
          <div id="form_submit" class="form_submit">
            <div class="fieldset">
             <div class="field-group">
                <label class="required title">学号</label>
                <span class="control-group" id="mobile_input">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtId" runat="server" MaxLength="8" style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"
                        OnTextChanged="txtId_TextChanged"></asp:TextBox>
                  <%--<input class="register_input" type="text" id="mobile" name="mobile" MaxLength="8" value="" onblur="__changeUserName('mobile');">--%>
                </div>
                </span>
                <label class="tips">8位数字，不加60前缀，请注意不要多加空格</label>
              </div>
              <div class="field-group">
                <label class="required title">密码</label>
                <span class="control-group" id="password1_input">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" MaxLength="10"  style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"
                        OnTextChanged="txtPwd_TextChanged"></asp:TextBox>
                  <%--<input class="register_input" type="password" id="password1" name="password1" maxLength="10" value="" onblur="checkPwd1(this.value);" />--%>
                </div>
                </span>
                <label class="tips">请使用6~10个英文字母（区分大小写）、符号或数字</label>
              </div>
               <div class="field-group">
                <label class="required title">验证码</label>
                <span class="control-group" id="code_input">
                <div class="input_add_long_background">
                <asp:TextBox ID="txtIdentify" runat="server" style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"></asp:TextBox>
                   <%--<input class="register_input" id="Text1" name="yzm" value="" />--%>
                </div>
                </span>
                <label class="tips">(区分大小写)</label>
                <asp:ImageButton ID="ibtn_yzm" runat="server" />
                  <a href="javascript:changeCode()" style="text-decoration: underline; font-size: 10px;">
                                换一张</a>
                   <script type="text/javascript">
                       function changeCode() {
                           document.getElementById('ibtn_yzm').src = document.getElementById('ibtn_yzm').src + '?';
                       }
                   </script>
               </div>
            </div>
          </div>
        
          <div id="div_submit" class="div_submit">
          <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/reg.aspx">没有账号？点此注册</asp:HyperLink>
            <div class='div_submit_button'>
              <input id="submit" type="submit" value="登录" class='button_button disabled'>
            </div>
          </div>
        </form>
      </div>
    </div>
    <div class='box_bottom'>
    </div>
    <div id="foot" 
          style="text-align: center;margin: auto; font-family: 华文中宋; font-size: large;">
            <br />Copyright © 2018 Web教学实习作业, All Rights Reserved.
            <br /><a href="admin.aspx">管理员登录</a>
        </div>
  </div>
</div>
</body>
</html>
