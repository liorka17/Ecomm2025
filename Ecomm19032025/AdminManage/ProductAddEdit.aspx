<%@ Page Title="" Language="C#" ValidateRequest="false" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductAddEdit.aspx.cs" Inherits="Ecomm19032025.AdminManage.ProductAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="tinymce/tinymce.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h2 class="page-title mb-2">עריכת מוצר</h2>
    <p class="text-muted mb-4">נא להזין את פרטי המוצר ולבצע שמירה</p>

    <div class="card shadow mb-4" style="max-width: 650px;">
        <div class="card-header bg-light">
            <strong class="card-title">פרטי המוצר</strong>
        </div>
        <div class="card-body">
            <div class="form-group mb-3">
                <label for="TxtPname">שם המוצר</label>
                <asp:TextBox ID="TxtPname" runat="server" CssClass="form-control form-control-sm" MaxLength="100" placeholder="הזן שם מוצר" />
            </div>

            <div class="form-group mb-3">
                <label for="TxtPrice">מחיר</label>
                <asp:TextBox ID="TxtPrice" runat="server" CssClass="form-control form-control-sm" TextMode="Number" placeholder="הזן מחיר" />
            </div>

            <div class="form-group mb-3">
                <label for="TxtPdesc">תיאור</label>
                <asp:TextBox ID="TxtPdesc" runat="server" CssClass="form-control form-control-sm" TextMode="MultiLine" Rows="3" placeholder="תיאור המוצר" />
            </div>

            <div class="form-group mb-3">
                <label for="DDLCategory">קטגוריה</label>
                <asp:DropDownList ID="DDLCategory" runat="server" CssClass="form-control form-control-sm" />
            </div>

            <div class="form-group mb-3">
                <label for="UplPic">תמונה</label><br />
                <asp:FileUpload ID="UplPic" runat="server" CssClass="form-control-file" />
                <asp:TextBox ID="TxtPicname" runat="server" CssClass="form-control form-control-sm mt-2" placeholder="שם קובץ תמונה" />
            </div>

            <div class="form-group mb-3">
                <label for="DDLStatus">סטטוס</label>
                <asp:DropDownList ID="DDLStatus" runat="server" CssClass="form-control form-control-sm">
                    <asp:ListItem Text="פעיל" Value="1"></asp:ListItem>
                    <asp:ListItem Text="לא פעיל" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <asp:HiddenField ID="HidPid" runat="server" Value="-1" />
            <asp:Button ID="BtnSave" runat="server" Text="שמור" CssClass="btn btn-primary btn-sm mt-2" OnClick="BtnSave_Click" />
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
    <script>
        tinymce.init({
            selector: 'MainCnt_TxtPdesc',
            height: 300,
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
