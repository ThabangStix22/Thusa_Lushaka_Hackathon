<%@ Page Title="Register" Language="C#" MasterPageFile="~/Sign.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApp.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FormContentHolder" runat="server">
    
        <div class="register-box">
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
      <a href=".#" class="h1"><b>Thusa Lushaka</b>| Sign Up</a>
    </div>
    <div class="card-body">
      <p class="login-box-msg">We are here to offer our help to those in need</p>

      
        <div class="input-group mb-3">
          <input type="text" class="form-control" placeholder="Full name">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>
          
          <div class="input-group mb-3">
          <input type="text" class="form-control" placeholder="Surname" ">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

         <div class="input-group mb-3">
          <input type="number" class="form-control" placeholder="13-digit ID Number" maxlength="13" minlength="13" >
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

         <div class="input-group mb-3">
          <input type="email" class="form-control" placeholder="Email Address">
          <div class="input-group-append">
            <div class="input-group-text">
             <span class="fas fa-envelope"></span>
            </div>
          </div>
        </div> 
          
          <div class="input-group mb-3">
          <input type="tel" class="form-control" placeholder="Contact number (e.g. 07123456789)"
              maxlength="10">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>

          <div class="input-group mb-3">
          <input type="password" class="form-control" placeholder="Password">
          <div class="input-group-append">
            <div class="input-group-text">
               <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>

      
        <div class="row">
       <%--   <div class="col-8">
            <div class="icheck-primary">
              <input type="checkbox" id="agreeTerms" name="terms" value="agree">
              <label for="agreeTerms">
               I agree to the <a href="#">terms</a>
              </label>
            </div>
          </div>--%>
          <!-- /.col -->
          <div class="col-4">
            
          </div>
          <!-- /.col -->
        </div>
     

          <asp:button id="btnRegister" class="btn btn-primary btn-block" runat="server" onclick="BtnRegister" text="Register"></asp:button>

      
      </div>

      <a href="Login.aspx" class="text-center">I already have an account</a>
    </div>
    <!-- /.form-box -->
  </div><!-- /.card -->
</div>
<!-- /.register-box -->


</asp:Content>
