<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="services.aspx.cs" Inherits="WebApplication1.Pages.services" %>

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
    <!--==============================
Service Area  
==============================-->
    <section class="position-relative bg-top-center overflow-hidden space " id="service-sec" data-bg-src="/assets/img/bg/category_3_bg.jpg">
        <div class="container">
            <div class="row justify-content-between">
                <div class="col-lg-8">
                    <div class="title-area service-3-titlebox text-center text-md-end">
                        <span class="sub-title ">خدماتنا </span>
                        <h2 class="sec-title ">خدماتنا ستمنحك النجاح</h2>
                    </div>
                </div>
                <div class="col-lg-4">
                </div>
            </div>
            <div class="service-area">
                <div class="row gy-30 justify-content-center">
               <asp:Literal ID="Services" runat="server">

               </asp:Literal>



                </div>
            </div>
        </div>

       
    </section>

</asp:Content>