<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="WebApplication1.Pages.blog" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="breadcumb-area style2 bg-smoke4">
    <div class="breadcumb-wrapper background-image" style="background-image: url(/assets/img/bg/breadcumb-bg.jpg;);">
        <div class="container">
            <div class="breadcumb-content">
              
            </div>
        </div>
    </div>
</div>
     <section class="th-blog-wrapper space-top space-extra-bottom">
        <div class="container">
            <div class="row">
                <div class="col-xxl-8 col-lg-7">
                  
 
                    <asp:Literal ID="Articls" runat="server">

                    </asp:Literal>
                </div>
                <div class="col-xxl-4 col-lg-5">
                    <aside class="sidebar-area">
                    
                     
                    </aside>
                </div>
            </div>
        </div>
    </section>



</asp:Content>