<%@ Page Title="" Language="C#" ValidateRequest="false" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CategoryAddEdit.aspx.cs" Inherits="Ecomm19032025.AdminManage.CategoryAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="tinymce/tinymce.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h2 class="page-title">עריכת קטגוריות</h2>
    <p class="text-muted">נא להזין את פרטי הקטגוריה ולבצע שמירה</p>

    <div class="card-deck">
        <div class="card shadow mb-4">
            <div class="card-header">
                <strong class="card-title">פרטי הקטגוריה</strong>
            </div>
            <div class="card-body">
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="TxtPname">שם הקטגוריה</label>
                        <asp:TextBox ID="TxtPname" runat="server" class="form-control" placeholder="הזן שם קטגוריה" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TxtParentCid">קוד אב</label>
                        <asp:TextBox ID="TxtParentCid" runat="server" CssClass="form-control" TextMode="Number" />
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="DDLStatus">סטטוס</label>
                        <asp:DropDownList ID="DDLStatus" runat="server" class="form-control">
                            <asp:ListItem Text="פעיל" Value="1"></asp:ListItem>
                            <asp:ListItem Text="לא פעיל" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

               
                <div class="form-group mb-3">
                    <label for="TxtCatDesc">תיאור הקטגוריה</label>
                    <asp:TextBox ID="TxtCatDesc" runat="server" CssClass="form-control form-control-sm" TextMode="MultiLine" Rows="4" placeholder="תיאור הקטגוריה" />
                </div>

                <asp:HiddenField ID="HidCid" runat="server" />

                <asp:Button ID="BtnSave" runat="server" Text="שמור" CssClass="btn btn-primary" OnClick="BtnSave_Click" />
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
    <script>
        tinymce.init({
            selector: '#MainCnt_TxtCatDesc',
            height: 180,
            language: 'he_IL',
            plugins: [
                'advlist', 'autolink', 'lists', 'link', 'image', 'charmap', 'preview',
                'anchor', 'searchreplace', 'visualblocks', 'code', 'fullscreen',
                'insertdatetime', 'media', 'table', 'help', 'wordcount', 'emoticons'
            ],
            toolbar: 'undo redo | blocks | ' +
                'bold italic backcolor | alignleft aligncenter ' +
                'alignright alignjustify | bullist numlist outdent indent | ' +
                'removeformat | help',
            content_style: 'body { font-family:Helvetica,Arial,sans-serif; font-size:16px }'
        });
    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CntUnderFooter" runat="server">
</asp:Content>
