<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ClienteWeb.About" %>

<asp:Content ID="BodyContent" cssclass="fondo" ContentPlaceHolderID="MainContent" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <head><title></title></head>
    <body>
        <h3>Tabla Clientes</h3>
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
        font-weight:bolder;
    }

    .mGrid th {
        padding: 4px 2px;
        color: #fff;
        background: #424242 url(grd_head.png) repeat-x top;
        border-left: solid 1px #000;
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
            border-left: solid 1px #000;
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
    <p>
        CustomerID: <asp:TextBox runat="server" CssClass="texto" Id="txtCustomerID"/>  
    </p>
    <p>
        CompanyName: <asp:TextBox runat="server" CssClass="texto" Id="txtCompanyName"/>
    </p>
    <p>
        ContactName: <asp:TextBox runat="server" CssClass="texto" Id="txtContactName"/>
    </p>
    <p>
        ContactTitle: <asp:TextBox runat="server" CssClass="texto" Id="txtContactTitle"/>
    </p>
    <p>
        Address: <asp:TextBox runat="server" CssClass="texto" Id="txtAddress"/>
    </p>
    <p>
        City: <asp:TextBox runat="server" CssClass="texto" Id="txtCity"/>
    </p>
    <p>
        Region: <asp:TextBox runat="server" CssClass="texto" Id="txtRegion"/>
    </p>
    <p>
        PostalCode: <asp:TextBox runat="server" CssClass="texto" Id="txtPostalCode"/>
    </p>
    <p>
        Country: <asp:TextBox runat="server" CssClass="texto" Id="txtCountry"/>
    </p>
    <p>
        Phone: <asp:TextBox runat="server" CssClass="texto" Id="txtPhone"/>   
    </p>
    <p>
        Fax: <asp:TextBox runat="server" CssClass="texto" Id="txtFax"/> 
    </p>
    <p>
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" CssClass="button" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" CssClass="button" OnClick="btnActualizar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" CssClass="button" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" CssClass="button" OnClick="btnBuscar_Click"/>
    </p>
    <p>
        <asp:GridView runat="server" CssClass="mGrid" ID="gvCustomers"></asp:GridView>
    </p>
    
    </body>
    </html>
    
</asp:Content>
