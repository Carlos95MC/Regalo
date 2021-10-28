<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <script>
     function Agregar_Click() {

     }
</script>
        <div class="row"></div>
    <div class="row">
         <div class="col-md-3">
             Cantidad:
         </div>
        <div class="col-md-4">
            
            <asp:TextBox id="idCantidad" runat="server" />
        </div>
    </div>    
    <div class="row"></div>
    <div class="row">   
         <div class="col-md-3">
              Nombre Producto:
         </div>
        <div class="col-md-4">           
           <asp:TextBox id="idNombreProducto" runat="server" />
        </div>        
    </div>
    <div class="row"></div>
    <div class="row"> 
        <div class="col-md-3">
                Precio Unitario:
         </div>
        <div class="col-md-4">          
           <asp:TextBox id="idPrecio" runat="server" />
        </div>
    </div>
    <div class="row"></div>
    <div class="row"><ul runat="server" id="tabs"></ul></div>
    <div class="row">
        <div class="col-md-2">
            <asp:DropDownList runat="server" ID="ddlLista" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-2">
            <asp:Button runat="server" type="submit" id="BtnAgregar" Text="Agregar" OnClick="Agregar_Click" ClientIDMode="Static" />
        </div>
    </div>
    <div class="row">
        Favoritos: <asp:Label ID="lbFavoritos" runat="server"/>
    </div>
    <div class="row">
        Carrito: <asp:Label ID="lbCarrito" runat="server"/>
    </div>
    <div class="row">
        Suma: <asp:Label ID="sumaSubtotal" runat="server"/>
    </div>
</asp:Content>

