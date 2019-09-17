<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addstudent.aspx.cs" Inherits="CRM_WQG_UI.Addstudent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
<div class='body_main'> 
  <!-- start main content -->
  <div class='index_box' style='margin-top:20px;'>
    <div style="position:fixed;color:red;margin:70px 0 0 450px;font-size:16px;Z-index:100;display:block;" id="hint"></div>
    <div class='box_title'>
      <div class='text_content'>
        <h1>添加学生</h1>
      </div>
    </div>
    <div class='box_main'>
      <div id="register" class="register">
        <form runat="server" id="form" action="#" method="post">
          <div id="form_submit" class="form_submit">
            <div class="fieldset">
             <div class="field-group">
                <label class="required title">学生学号</label>
                <span class="control-group" id="mobile_input">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtStuId" runat="server" MaxLength="8" 
                        style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"></asp:TextBox>
                  <%--<input class="register_input" type="text" id="mobile" name="mobile" MaxLength="8" value="" onblur="__changeUserName('mobile');">--%>
                </div>
                </span>
                <label class="tips">8位数字，不加60前缀，请注意不要多加空格</label>
              </div>
              <div class="field-group">
                <label class="required title">登录密码</label>
                <span class="control-group" id="Span1">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtPwd" runat="server" MaxLength="10" 
                        
                        
                        style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;" 
                        TextMode="Password"></asp:TextBox>
                  <%--<input class="register_input" type="text" id="mobile" name="mobile" MaxLength="8" value="" onblur="__changeUserName('mobile');">--%>
                </div>
                </span>
                <label class="tips">请使用6~10位数字或字母，请注意不要多加空格</label>
              </div>
               <div class="field-group">
               <label class="required title">学生姓名</label>
                <span class="control-group" id="Span2">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtName" runat="server" style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"></asp:TextBox>
                  <%--<input class="register_input" type="password" id="password1" name="password1" maxLength="10" value="" onblur="checkPwd1(this.value);" />--%>
                </div>
                </span>
                <label class="tips">请使用2~10位中文字符</label>
              </div>
               <div class="field-group">
               <label class="required title">学生年龄</label>
                <span class="control-group" id="Span3">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtAge" runat="server" style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"></asp:TextBox>
                  <%--<input class="register_input" type="password" id="password1" name="password1" maxLength="10" value="" onblur="checkPwd1(this.value);" />--%>
                </div>
                </span>
                <label class="tips">请使用2~3位数字</label>
              </div>
               <div class="field-group">
               <label class="required title">学生性别</label>
                <span class="control-group" id="Span4">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtSex" runat="server" style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"></asp:TextBox>
                  <%--<input class="register_input" type="password" id="password1" name="password1" maxLength="10" value="" onblur="checkPwd1(this.value);" />--%>
                </div>
                </span>
                <label class="tips">请填入"男"或"女"</label>
              </div>
               <div class="field-group">
               <label class="required title">联系方式</label>
                <span class="control-group" id="Span5">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtPhone" runat="server" style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"></asp:TextBox>
                  <%--<input class="register_input" type="password" id="password1" name="password1" maxLength="10" value="" onblur="checkPwd1(this.value);" />--%>
                </div>
                </span>
                <label class="tips">请使用11位数字</label>
              </div>
               <div class="field-group">
               <label class="required title">家庭住址</label>
                <span class="control-group" id="Span6">
                <div class="input_add_long_background">
                  <asp:TextBox ID="txtAddress" runat="server" style="background-color:#f9f9f9;border:0 none;color:#4F4F4F;font-size:12px;height:18px;outline:medium none;width: 270px;padding:1px;margin:5px;"></asp:TextBox>
                  <%--<input class="register_input" type="password" id="password1" name="password1" maxLength="10" value="" onblur="checkPwd1(this.value);" />--%>
                </div>
                </span>
                <label class="tips">请使用不超过50个中文字符</label>
              </div>

            </div>
          </div>
          <div id="div_submit" class="div_submit">
            <div class='div_submit_button'>
              <input id="submit" type="submit" value="添加" class='button_button disabled' 
                    onclick="return submit_onclick()">
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
