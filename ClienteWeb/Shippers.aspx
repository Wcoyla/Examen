<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shippers.aspx.cs" Inherits="ClienteWeb.Shippers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <html>
    <head><title></title></head>
    <body>
        <h3>Shippers</h3>

    <p>
        ShipperID: <asp:TextBox runat="server" Id="txtShipperID"/>
    </p>
    <p>
        CompanyName: <asp:TextBox runat="server" Id="txtCompanyName"/>
    </p>
    <p>
        Phone: <asp:TextBox runat="server" Id="txtPhone"/>
    </p>
    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" CssClass="button" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" CssClass="button" OnClick="btnActualizar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" CssClass="button" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" CssClass="button" OnClick="btnBuscar_Click"/>
    </p>
    <p>
        <asp:GridView runat="server" ID="gvShippers" CssClass="mGrid"></asp:GridView>
    </p>
    </body>
    </html>
    
     <style>
        *{
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            
        }
        body{
            background-color:#ccccff;
        }
        p { 
            
            font-size:larger;
            font-weight:bold;
            display:inline-block;
            
        }    
        .button{
            background-color:#6600cc;
            height:50px;
            color:#fff;
            width:100px;
            border-radius:10%;
        }
        .button:hover{
            background-color:#4d0099;
            color:#fff;
            height:60px;
            width:120px;

        }
        .texto{
            display:flex;
            
        }
        .texto:active{
            background:#999;
        }
    .mGrid {
    width: 100%;
    background-image:url("https://thumbs.dreamstime.com/b/fondo-de-piedras-grises-37205349.jpg");
    font-size:larger;
    margin: 5px 0 10px 0;
    border: solid 1px #525252;
    border-collapse: collapse;
}

    .mGrid td {
        padding: 2px;
        border: solid 1px #c1c1c1;
        color: #000;
        font-weight:bold;
    }

    .mGrid th {
        padding: 4px 2px;
        color: #fff;
        background: #424242 url(grd_head.png) repeat-x top;
        border-left: solid 1px #525252;
        font-size: 0.9em;
    }

    .mGrid .alt {
        background: #fcfcfc url(grd_alt.png) repeat-x top;
    }

    .mGrid .pgr {
        background: #424242 url(grd_pgr.png) repeat-x top;
    }

        .mGrid .pgr table {
            margin: 5px 0;
        }

        .mGrid .pgr td {
            border-width: 0;
            padding: 0 6px;
            border-left: solid 1px #666;
            font-weight: bold;
            color: #fff;
            line-height: 12px;
        }

        .mGrid .pgr a {
            color: #666;
            text-decoration: none;
        }

            .mGrid .pgr a:hover {
                color: #000;
                text-decoration: none;
            }

        </style>
</asp:Content>
