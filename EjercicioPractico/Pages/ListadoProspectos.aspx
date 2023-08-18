<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ListadoProspectos.aspx.cs" Inherits="EjercicioPractico.Pages.ListadoProspectos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Pantalla listado de prospectos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="mt-5">
      <div class="container">
          <div class="row">
              <h1 class="text-center">Listado de prospectos</h1>
          </div>

          <div class="row">
             <asp:Button  runat="server" Text="Agregar Prospectos" CssClass="btn btn-dark form-control" ID="BtnRegresar" OnClick="BtnRegresar_Click"/>
          </div>
          <br />


        <div class="row">
             <div class="table table-dark table-striped text-center" style="width:100%; height:500px; overflow: scroll">
                 <asp:GridView runat="server" ID="GridUsuarios" class="table  table-borderless table-hover text-center ">
                     <Columns>
                         <asp:TemplateField HeaderText="Opciones">
                             <ItemTemplate>
                                 <asp:Button  runat="server" Text="Revisar" CssClass="btn form-control-sm btn-info" ID="BtnRevisar" OnClick="BtnRevisar_Click"/>
                             </ItemTemplate>
                         </asp:TemplateField>
                     </Columns>
                 </asp:GridView>
             </div>
        </div>
    </div>

    </form>
</asp:Content>
