<%@ Page Title="Login" Language="C#" MasterPageFile="~/Sign.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FormContentHolder" runat="server">
    <div class="login-box">
  <!-- /.login-logo -->
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
      <a href="#" class="h1"><b>Thusa Lushaka</b> Portal</a>
    </div>
    <div class="card-body">
      <p class="login-box-msg">Sign in to start your session</p>

     
        <div class="input-group mb-3">
          <input id="inputEmail" runat="server" type="email" class="form-control" placeholder="Email">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
          <input id="inputPassword" runat="server" type="password" class="form-control" placeholder="Password">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
   <%--     <div class="row">
          <div class="col-8">
            <div class="icheck-primary">
              <input type="checkbox" id="remember">
              <label for="remember">
                Remember Me
              </label>
            </div>
          </div>
          <!-- /.col -->
          <div class="col-4">
            <button type="submit" class="btn btn-primary btn-block">Sign In</button>
          </div>
          <!-- /.col -->
        </div>--%>
   

      <div class="social-auth-links text-center mt-2 mb-3">
        <a href="#" class="btn btn-block btn-primary">
          <asp:button id="btnSignIn" type="submit" class="btn btn-primary btn-block" OnClick="btnSignIn_Click">Sign In</asp:button>
        </a>
        <%--<a href="#" class="btn btn-block btn-danger">
          <i class="fab fa-google-plus mr-2"></i> Sign in using Google+
        </a>--%>
      </div>
      <!-- /.social-auth-links -->

        <div id="alertMsg" runat="server" class="alert alert-danger" role="alert" visible="false">
         Error! Email/Password is incorrect!
        </div>

      <p class="mb-1">
        <a href="Register.aspx">Seeking meal assistance? Sign up here</a>
      </p>

    <%--  <p class="mb-0">
        <a href="#" class="text-center">Admin Click Here!
        </a>
      </p>--%>

    </div>
    <!-- /.card-body -->
  </div>
  <!-- /.card -->
</div>
<!-- /.login-box -->
</asp:Content>
