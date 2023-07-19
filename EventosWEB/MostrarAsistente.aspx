<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarAsistente.aspx.cs" Inherits="EventosWEB.MostrarAsistente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <asp:DropDownList ID="estadoDDL" runat="server" AutoPostBack="true" OnSelectedIndexChanged="estadoDDL_SelectedIndexChanged">
                 <asp:ListItem Text="Pagada" Selected="True" Value="Pagada"></asp:ListItem>
                 <asp:ListItem Text="Con Deuda" Value="Con Deuda"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row mt-5">
        <asp:GridView ID="grillaAsistente" 
            AutoGenerateColumns="false" 
            ShowHeaderWhenEmpty="true"
            CssClass="table table-hover table-bordered"
            EmptyDataText="No hay Registros" 
            runat="server">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Empresa" DataField="Empresa" />
                <asp:BoundField HeaderText="Region" DataField="Region" />
                <asp:BoundField HeaderText="Estado" DataField="Estado" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
