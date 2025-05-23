<%@ Page Title="" Language="C#" ValidateRequest="false" MasterPageFile="~/AdminManage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="OrdersAddEdit.aspx.cs" Inherits="Ecomm19032025.AdminManage.OrdersAddEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="tinymce/tinymce.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h2 class="page-title">עריכת הזמנה</h2>
    <p class="text-muted">נא להזין את פרטי ההזמנה</p>

    <div class="card-deck">
        <div class="card shadow mb-4">
            <div class="card-header">
                <strong class="card-title">פרטי הזמנה</strong>
            </div>
            <div class="card-body">
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="TxtUid">קוד משתמש</label>
                        <asp:TextBox ID="TxtUid" runat="server" class="form-control" placeholder="הכנס קוד משתמש" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TxtTotalPrice">מחיר כולל</label>
                        <asp:TextBox ID="TxtTotalPrice" runat="server" class="form-control" placeholder="הכנס מחיר כולל" />
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="TxtTotalAmount">כמות כוללת</label>
                        <asp:TextBox ID="TxtTotalAmount" runat="server" class="form-control" TextMode="Number" placeholder="הכנס כמות" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="DDLStatus">סטטוס</label>
                        <asp:DropDownList ID="DDLStatus" runat="server" class="form-control">
                            <asp:ListItem Text="בתהליך" Value="בתהליך"></asp:ListItem>
                            <asp:ListItem Text="בוצעה" Value="בוצעה"></asp:ListItem>
                            <asp:ListItem Text="בוטלה" Value="בוטלה"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="form-group mb-3">
                    <label for="TxtOrderDesc">תיאור הזמנה</label>
                    <asp:TextBox ID="TxtOrderDesc" runat="server" CssClass="form-control form-control-sm" TextMode="MultiLine" Rows="4" placeholder="תיאור ההזמנה" />
                </div>

                <asp:HiddenField ID="HidOrderId" runat="server" Value="-1" />
                <asp:Button ID="BtnSave" runat="server" Text="שמור" CssClass="btn btn-primary" OnClick="BtnSave_Click" />
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CntFooter" runat="server">
    <script>
        tinymce.init({
            selector: '#MainCnt_TxtOrderDesc',
            height: 220,
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
