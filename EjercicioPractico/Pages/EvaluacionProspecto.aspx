<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="EvaluacionProspecto.aspx.cs" Inherits="EjercicioPractico.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Pantalla Evaluacion de prospecto
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="background-color:white">
        <div class="row">
            <h1 class="text-center mt-3 mb-3">Evaluacion de prospectos</h1>
        </div>

        <div class="row">
           
                <form runat="server">
                     <div class="col-lg-12">
                    <div class="table table-dark table-striped text-center" style="width:100%; height:500px; overflow: scroll">
                        <asp:GridView runat="server" ID="GridUsuarios" class="table  table-borderless table-hover text-center" >
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button  runat="server" Text="Revisar" CssClass="btn form-control-sm btn-success" ID="BtnRevisar" OnClick="BtnRevisar_Click"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                  </div>
                    <div class="container d-flex justify-content-center">
                        
                        <div class="col-lg-5  ">
                
                    <div class="mb-3">
                    <label class="form-label">Nombre:</label>
                    <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>

                     <div class="mb-3">
                    <label class="form-label">Primer Apellido:</label>
                    <asp:TextBox ID="TxtApellido1" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Segundo Apellido:</label>
                    <asp:TextBox ID="TxtApellido2" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Calle:</label>
                    <asp:TextBox ID="TxtCalle" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Numero</label>
                    <asp:TextBox ID="TxtNumero" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Colonia:</label>
                    <asp:TextBox ID="TxtColonia" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">CodigoPostal:</label>
                    <asp:TextBox ID="TxtCp" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Telefono:</label>
                    <asp:TextBox ID="TxtTel" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">RFC:</label>
                    <asp:TextBox ID="TxtRfc" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>

                 <div class="mb-3">
                    <label class="form-label">Documentos:</label>
                    
                     <asp:DropDownList ID="DropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                 
              </div>
                        <div class="col-lg-2">

                        </div>

                        <div class="col-lg-5  text-center">

                             <div class="mb-3 mt-4">
                                <asp:Label ID="Label1" runat="server" Text="Estado Seleccionado:"></asp:Label>
                                
                            </div>

                            <div class="mb-3 mt-4">
                                <asp:Button ID="BtnRechazo" runat="server" Text="Rechazar" CssClass="form-control btn btn-danger" OnClick="BtnRechazo_Click"/>
                            </div>
                            <div class="mb-3 mt-4">
                                <asp:Button ID="BtnAprobar" runat="server" Text="Aprobar" CssClass="form-control btn btn-success" OnClick="BtnAprobar_Click" />
                            </div>

                            <div class="mb-3 mt-4">
                                <asp:Label ID="LbNotas" runat="server" Text="Notas:" ></asp:Label>
                                <asp:TextBox ID="TxtNotas" runat="server" CssClass="form-control" multiline="true" required="true"></asp:TextBox>
                            
                            </div>

                             <div class="mb-3 mt-4">                  
                                  <asp:Button ID="Btn_actualizar" runat="server" Text="Actualizar" CssClass="form-control btn btn-warning" OnClick="Btn_actualizar_Click"   />
                            </div>

                            

                        </div>
                    </div>
               
                   
                </form>
                
        </div>
    </div>
</asp:Content>
