<%@ Page Language="C#" EnableSessionState="true" AutoEventWireup="true" MasterPageFile="~/OrganizeMonkey.Master" CodeBehind="default.aspx.cs" Inherits="OrganizeMonkey._default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="default magenta">
   <div class="kachel div_height todo"><h1>zu erledigen</h1>
       <ul>
           <li>
               <label><input type="checkbox" name="checkbox" value="value">Tabletten 1</label>
                </li>
               <li><label><input type="checkbox" name="checkbox" value="value">Tabletten 2</label></li>
               <li><label><input type="checkbox" name="checkbox" value="value">Termin Arzt 1</label></li>
               <li><label><input type="checkbox" name="checkbox" value="value">Termin Arzt 2</label></li>
               <li><label><input type="checkbox" name="checkbox" value="value">Besuch</label></li>
               <li><label><input type="checkbox" name="checkbox" value="value">Visite</label></li>
          
       </ul>
   </div>
        <div class="kachel div_quater weather">
            <div id="wcom-ab92de27fc33bb6e270758ca7904e346" style="margin-left: 25%; height: 280px !important; max-height:280px!important;"class="wcom-default w300x250"><link rel="stylesheet" href="//cs3.wettercomassets.com/woys/5/css/w.css" media="all"><a style="    color: #ffffff;
    font-weight: bold;
    font-size: 60px;" href="https://www.wetter.com/deutschland/berlin/DE0001020.html" target="_blank" rel="nofollow" title="Wetter Berlin">Wetter</a><div id="wcom-ab92de27fc33bb6e270758ca7904e346-weather"></div><script type="text/javascript" src="//cs3.wettercomassets.com/woys/5/js/w.js"></script><script type="text/javascript">_wcomWidget({ id: 'wcom-ab92de27fc33bb6e270758ca7904e346', location: 'DE0001020', format: '300x250', type: 'spaces' });</script></div>
        </div>
        <div class="kachel div_quater"><h1>Nachrichten</h1>
            <!-- start feedwind code --> <script type="text/javascript" src="https://feed.mikle.com/js/fw-loader.js" data-fw-param="94272/"></script> <!-- end feedwind code -->
        </div>
        <%--<script>
            var iframe = document.getElementsByClassName("fw-iframe")[0];
            var elmnt = iframe.contentWindow.document.getElementsByClassName("fw-container")[0];
                elmnt.style.display = "none";
        </script>--%>
        </div>
</asp:Content>
