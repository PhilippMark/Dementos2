<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OrganizeMonkey.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    ​<meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="icon" type="image/x-icon" href="~/MonkeyBasecap.png") />
    <title>Organize-Monkey</title>
    <style type="text/css">
        body {
            background-color: #f5f5f5;
        }

        .form-signin {
            max-width: 330px;
            padding: 15px;
            margin: 0 auto;
        }

        .form-signin .form-control {
            position: relative;
            font-size: 16px;
            height: auto;
            padding: 10px;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
        }

        .form-signin .form-control:focus {
            z-index: 2;
        }

        .form-signin input[type="text"] {
            margin-bottom: -1px;
            border-bottom-left-radius: 0;
            border-bottom-right-radius: 0;
        }

        .form-signin input[type="password"] {
            margin-bottom: 10px;
            border-top-left-radius: 0;
            border-top-right-radius: 0;
        }

        .account-wall {
            margin-top: 80px;
            padding: 40px 0px 20px 0px;
            background-color: #ffffff;
            box-shadow: 0 2px 10px 0 rgba(0, 0, 0, 0.16);
        }

        .login-title {
            color: #555;
            font-size: 22px;
            font-weight: 400;
            display: block;
        }

        .profile-img {
            width: 96px;
            height: 96px;
            margin: 0 auto 10px;
            display: block;
            -moz-border-radius: 50%;
            -webkit-border-radius: 50%;
            border-radius: 50%;
        }

        .select-img {
            border-radius: 50%;
            display: block;
            height: 75px;
            margin: 0 30px 10px;
            width: 75px;
            -moz-border-radius: 50%;
            -webkit-border-radius: 50%;
            border-radius: 50%;
        }

        .select-name {
            display: block;
            margin: 30px 10px 10px;
        }

        .logo-img {
            width: 96px;
            height: 96px;
            margin: 0 auto 10px;
            display: block;
            -moz-border-radius: 50%;
            -webkit-border-radius: 50%;
            border-radius: 50%;
        }

        #loader {
            position: absolute;
            left: 50%;
            top: 50%;
            z-index: 11;
            width: 150px;
            height: 150px;
            margin: -75px 0 0 -75px;
            border: 16px solid #f3f3f3;
            border-radius: 50%;
            border-top: 16px solid #3498db;
            width: 120px;
            height: 120px;
            -webkit-animation: spin 2s linear infinite;
            animation: spin 2s linear infinite;
        }

        @keyframes spin {
            0% {
                transform: rotate(0deg);
            }

            100% {
                transform: rotate(360deg);
            }
        }

        #fadeMe {
            opacity: 0.5;
            background: #000;
            width: 100%;
            height: 100%;
            z-index: 10;
            top: 0;
            left: 0;
            position: fixed;
        }
    </style>
</head>
<body>
    <div id="loader" style="display:none;"></div>
    <div id="fadeMe" style="display:none;"></div>
    <div class="container control">
        <div class="row">
            <div class="col-sm-6 col-md-4 col-md-offset-4">
                <div class="account-wall">
                    <div id="my-tab-content" class="tab-content">
                        <img class="profile-img" src="styles/MonkeyNeu.png" height="100px" />
                        <asp:PlaceHolder runat="server" Visible="false" ID="placeholderRegError">
                        <div class="alert alert-danger">
                            <strong>Fehler!</strong> Registrierung fehlgeschlagen!
                        </div>
                            </asp:PlaceHolder>
                        <asp:PlaceHolder runat="server" Visible="false" ID="placeHolderLoginError">
                        <div class="alert alert-danger">
                            <strong>Fehler!</strong> Login fehlgeschlagen!
                        </div>
                        </asp:PlaceHolder>
                        <asp:PlaceHolder runat="server" Visible="false" ID="placeholderLogoutError">
                        <div class="alert alert-danger">
                            <strong>Ausgelogt!</strong> Durch einen internen Fehler oder den Ablauf Ihrer Session, wurden Sie zu Ihrer Sicherheit ausgeloggt!
                        </div>
                        </asp:PlaceHolder>
                        <asp:PlaceHolder runat="server" Visible="false" ID="placeholderRegSuccess">
                        <div class="alert alert-success">
                            <strong>Success!</strong> Registrierung erfolgreich! Bitte melden Sie sich nun an.
                        </div>
                        </asp:PlaceHolder>
                        <asp:PlaceHolder runat="server" Visible="false" ID="placeHolderLogout">
                        <div class="alert alert-info">
                            Logout erfolgreich!
                        </div>
                        </asp:PlaceHolder>
                        <asp:PlaceHolder runat="server" Visible="false" ID="placeholderRegNameError">
                        <div class="alert alert-danger">
                            <strong>Login vorhanden!</strong> Es gibt bereits einen Account mit diesem Login-Namen
                        </div>
                        </asp:PlaceHolder>
                        <form class="form-signin" runat="server" id="login">
                            <div class="tab-pane active">
                                <div>
                                    <asp:TextBox type="text" name="txtLogin" ID="txtLogin" class="form-control" placeholder="Username" runat="server" />
                                    <asp:TextBox type="password" ID="txtPassword" name="txtPassword" class="form-control" placeholder="Password" runat="server" />
                                    <asp:Button ID="btnLogin" OnClick="Login_Click" type="submit" class="btn btn-lg btn-default btn-block" Text="Login" runat="server" OnClientClick="document.getElementById('loader').style.display = 'block'; document.getElementById('fadeMe').style.display = 'block';" />
                                </div>
                                <br />
                                <div id="tabs" data-tabs="tabs" class="text-center">
                                    <a class="text-center" href="RegisterCorporation.aspx">WG gründen?</a>
                                </div>
                            </div>                            
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
