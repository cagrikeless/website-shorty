<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot-password.aspx.cs" Inherits="Shorty.forgot_password" %>

<!--A Design by W3layouts 
Author: W3layout
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html lang="en">
<head>
<title>Shopping Sign in Form Flat Responsive Widget Template :: w3layouts</title>

<!-- Meta tag Keywords -->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="Shopping Sign in Form template Responsive, Login form web template,Flat Pricing tables,Flat Drop downs Sign up Web Templates, 
 Flat Web Templates, Login sign up Responsive web template, SmartPhone Compatible web template, free web designs for Nokia, Samsung, LG, SonyEricsson, Motorola web design">
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Meta tag Keywords -->

<!-- css files -->
<link href="web/css/style.css" rel="stylesheet" type="text/css" media="all" />
<!-- css files -->
<link rel="stylesheet" href="web/css/font-awesome.css"> <!-- Font-Awesome-Icons-CSS -->

<!-- Online-fonts -->
<link href="//fonts.googleapis.com/css?family=Varela+Round&amp;subset=hebrew,latin-ext,vietnamese" rel="stylesheet">
<!-- //Online-fonts -->

</head>
<body>
	<!-- main -->
	<div class="main">
		<div class="main-w3l">
			<h1 class="logo-w3">Shopping <span>Sign in</span> Form</h1>
			<div class="w3layouts-left">
				<h3>Connect With Your Social Account</h3>
				<p>Enter into your website to shop more with best offers upto 50% off this week</p>
				<div class="icon">
					<span class="fa fa-thumbs-o-up" aria-hidden="true"></span>
				</div>
				<ul>
					<li><a href="#" class="f"><i class="fa fa-facebook" aria-hidden="true"></i>Sign in with Facebook</a></li>
					<li><a href="#" class="t"><i class="fa fa-twitter" aria-hidden="true"></i>Sign in with Twitter</a></li>
					<li><a href="#" class="g"><i class="fa fa-google-plus" aria-hidden="true"></i>Sign in with Google+</a></li>
				</ul>
			</div>
			<div class="w3layouts-main">
				<h2><span>Forgot Password</span></h2>
					<form action="#" method="post" runat="server">
                        <asp:TextBox ID="txt_fullname" runat="server" placeholder="Full Name"></asp:TextBox>
                        <asp:TextBox ID="txt_emailAddress" runat="server" placeholder="Email Address"></asp:TextBox>
						<asp:Button  runat="server" ID="btn_ForgotPassword" Text="Send Email" OnClick="btn_ForgotPassword_Click"/>
					</form>
			</div>
			<div class="clear"></div>
			<!-- //main -->
			
			<!--footer-->
			<div class="footer-w3l">
				<p>&copy; 2018 Shorty Shopping. All rights reserved </p>
			</div>
			<!--//footer-->
		</div>
	</div>

</body>
</html>
