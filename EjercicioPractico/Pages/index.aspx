<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="EjercicioPractico.Pages.PantallaCaptura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Pantalla de captura de prospecto
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="mx-auto mt-5 mb-5" style="width:500px">
        <asp:Label ID="lblTitulo" runat="server"  CssClass="h2"></asp:Label>
        <h1 class="text-center">Captura de prospectos</h1>
    </div>

    <div class="container">
        <form runat="server" class="h-100 d-flex align-items-center justify-content-center border-solid">
            <div>
                <div class="mb-3">
                    <label class="form-label">Nombre:</label>
                    <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Primer Apellido:</label>
                    <asp:TextBox ID="TxtApellido1" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Segundo Apellido:</label>
                    <asp:TextBox ID="TxtApellido2" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Calle:</label>
                    <asp:TextBox ID="TxtCalle" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Numero</label>
                    <asp:TextBox ID="TxtNumero" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Colonia:</label>
                    <asp:TextBox ID="TxtColonia" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">CodigoPostal:</label>
                    <asp:TextBox ID="TxtCp" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Telefono:</label>
                    <asp:TextBox ID="TxtTel" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">RFC:</label>
                    <asp:TextBox ID="TxtRfc" runat="server" CssClass="form-control" required ="true"></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Documentos</label>
                     <asp:FileUpload ID="FileUpload" runat="server" multiple="multiple"  CssClass="form-control"/>
                </div>

                 <div class="mb-3">
                     <asp:Button ID="BtnEnviar" runat="server" Text="Enviar" CssClass="form-control btn btn-primary" OnClick="BtnEnviar_Click" />
                </div>

                 <div class="mb-3">
                       <div class="d-inline-block" tabindex="0" data-bs-toggle="popover" data-bs-trigger="hover focus" data-bs-content="Si Presionas salir perderas los datos no registrados">
                        
                           <asp:Button ID="BtnSalir" runat="server" Text="Salir" Cssclass="btn btn-danger form-control" OnClick="BtnSalir_Click" />
                        </div>
                    </div>
            </div>
        </form>
    </div>
</asp:Content>
