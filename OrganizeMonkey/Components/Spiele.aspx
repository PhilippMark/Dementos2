<%@ Page Title="" Language="C#" MasterPageFile="~/OrganizeMonkey.Master" AutoEventWireup="true" CodeBehind="Spiele.aspx.cs" Inherits="OrganizeMonkey.Components.Spiele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="default green">
        <div class="kachel div_full">
            <h1>Quiz</h1>
            <div class="quiz">
                <div class="question">
                    <span>Welcher Sender ist hier zu sehen?</span>
                    <div class="img">
                        <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Neues_Sat._1_Logo_transparent.png/600px-Neues_Sat._1_Logo_transparent.png" />
                    </div>
                </div>
                <div>
                    <%--<asp:Button Text="Antwort1" runat="server" ID="a1"/>
                    <asp:Button Text="Antwort2" runat="server" ID="a2"/>
                    <asp:Button Text="Antwort3" runat="server" ID="a3"/>
                    <asp:Button Text="Antwort4" runat="server" ID="a4"/>--%>
                    <input class="quizbutton" type="button" value="Kabel 1" />
                    <input class="quizbutton" type="button" value="ARD" />
                    <input class="quizbutton" type="button" value="ZDF" />
                    <input class="quizbutton" type="button" value="Sat 1" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
