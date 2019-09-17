<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="CRM_WQG_UI.admin1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员登录</title>
    <link href="css/style1.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div class='body_main'> 
  <!-- start main content -->
  <div class='index_box' style='margin-top:20px;'>
    <div class='box_title'>
      <div class='text_content'>
        <h1>管理员登录</h1>
      </div>
    </div>
    <div class='box_main'>
      <div id="register" class="register">
        <form runat="server" id="form" action="#" method="post">
          <div id="form_submit" class="form_submit">
            <div class="fieldset">
             <div class="field-group">
                <label class="required title">管理员帐号</label>
                <span class="control-group" id="mobile_input">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtId" runat="server" MaxLength="8" style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"></asp:TextBox>
                  <%--<input class="register_input" type="text" id="mobile" name="mobile" MaxLength="8" value="" onblur="__changeUserName('mobile');">--%>
                </div>
                </span>
              </div>
              <div class="field-group">
                <label class="required title">管理员密码</label>
                <span class="control-group" id="password1_input">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" MaxLength="10"  style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"></asp:TextBox>
                  <%--<input class="register_input" type="password" id="password1" name="password1" maxLength="10" value="" onblur="checkPwd1(this.value);" />--%>
                </div>
                </span>
              </div>
            </div>
          </div>
          <div id="div_submit" class="div_submit">
            <div class='div_submit_button'>
              <input id="submit" type="submit" value="登录" class='button_button disabled'/>
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
        </div>
  </div>
</div>
</body>
</html>
