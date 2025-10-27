<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Site.Master" AutoEventWireup="true" CodeBehind="contact-us.aspx.cs" Inherits="WebApplication1.Pages.contact_us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--==============================
    Breadcumb
============================== -->
    <div class="breadcumb-area style2 bg-smoke4">
        <div class="breadcumb-wrapper" data-bg-src="assets/img/bg/breadcumb-bg.jpg">
            <div class="container">
                <div class="breadcumb-content">
                </div>
            </div>
        </div>
    </div>
    <!--==============================
Contact Area  
==============================-->
    <div class="contact-area space space-extra-bottom overflow-hidden">
        <div class="container">
            <div class="contact-wrapp2 mb-60 smoke-bg">
                <div class="contact-infobox-top">
                    <div class="row align-items-center justify-content-between text-center">
                        <div class="col-xl-3 col-lg-3">
                            <div class="contact-shape-left text-sm-start">
                                <img src="/assets/img/shape/contact-shape_2_1.png" alt="" />
                            </div>
                        </div>
                        <div class="col-xl-6 col-lg-6">
                            <div class="title-area contact-titlebox2 text-center">

                                <h3 class="sec-title">معلومات التواصل</h3>
                                <p class="sec-text">
                                    نشكرك على اهتمامك بشركة المعيار الأمثل<br />
                                    يسعدنا التواصل معك ومناقشتك...
                                </p>
                            </div>
                        </div>
                        <div class="col-xl-3 col-lg-3">
                            <div class="contact-shape-right text-sm-end">
                                <img src="/assets/img/shape/contact-shape_2_2.png" alt="" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="contact-infobox-bottom d-xl-flex align-items-center justify-content-between">
                    <div class="about-contact-grid inner-style">
                        <span class="about-contact-icon">
                            <i class="fa-solid fa-headphones-simple"></i>
                        </span>
                        <div class="about-contact-details">
                            <span class="sec-text">الاتصال</span>
                            <p class="about-contact-details-text">
                                <a style="direction: rtl !important;" href="https://api.whatsapp.com/send/?phone=966530989332&text=Hello+there%21&type=phone_number&app_absent=0">530989332 (966+)</a>
                            </p>
                        </div>
                    </div>
                    <div class="about-contact-grid inner-style">
                        <span class="about-contact-icon">
                            <i class="fa-light fa-envelope-open-text"></i>
                        </span>
                        <div class="about-contact-details">
                            <span class="sec-text">البريد الإلكتروني</span>
                            <p class="about-contact-details-text">
                                <a href="mailto:info@optimalstandard.com">info@optimalstandard.com</a>
                            </p>
                        </div>
                    </div>

                </div>
            </div>
         
            <div class="contact-form-wrapp2">
                <div class="row">
                    <div class="col-xl-7 order-1 order-xl-0">
                        <div class="contact-formbox  border-0">
                            <form id="form" runat="server" class="border-0">
                                <div class="row">
                                    <div class="col-sm-6 form-group">
                                        <asp:TextBox CssClass="form-control" ID="TXTName" runat="server" placeholder="اسم مقدم الطلب"></asp:TextBox>
                                        
                                    </div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldName"  Display="Dynamic" style="margin-right:10px" CssClass="alert alert-danger" Width="45%" runat="server" ControlToValidate="TXTName" ErrorMessage="الحقل اجباري"></asp:RequiredFieldValidator>
                                    <div class="col-sm-6 form-group">
                                        <asp:TextBox CssClass="form-control" ID="TXTEmail" runat="server" placeholder="البريد الإلكتروني"></asp:TextBox>


                                    </div>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  Display="Dynamic" style="margin-right:10px" CssClass="alert alert-danger" Width="45%" runat="server" ControlToValidate="TXTEmail" ErrorMessage="الحقل اجباري"></asp:RequiredFieldValidator>
                                    <div class="col-sm-6 form-group">
                                        <asp:TextBox CssClass="form-control" ID="TXTNumber" runat="server" placeholder="رقم الجوال"></asp:TextBox>

                                    </div>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" style="margin-right:10px" CssClass="alert alert-danger" Width="45%" runat="server" ControlToValidate="TXTNumber" ErrorMessage="الحقل اجباري"></asp:RequiredFieldValidator>


                                    <div class="col-sm-6 form-group">
                                        <asp:TextBox CssClass="form-control" ID="TXTSubject" runat="server" placeholder="عنوان الرسالة"></asp:TextBox>

                                    </div>
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Display="Dynamic" style="margin-right:10px" CssClass="alert alert-danger" Width="45%" runat="server" ControlToValidate="TXTSubject" ErrorMessage="الحقل اجباري"></asp:RequiredFieldValidator>
                                           
                                    <div class="form-group col-12">

                                        <asp:TextBox CssClass="form-control" ID="TXTmessage" TextMode="MultiLine" runat="server" Rows="5" placeholder="نص الرسالة"></asp:TextBox>                           
                                    </div>

                                         <asp:RequiredFieldValidator Display="Dynamic" style="margin-right:10px" CssClass="alert alert-danger" Width="100%" ForeColor="Red" ID="RequiredFieldValidator4" runat="server" ControlToValidate="TXTmessage" ErrorMessage="الحقل اجباري"></asp:RequiredFieldValidator>

                                  <div class="form-btn col-12 d-flex justify-content-end mt-3">                                        <div class="col-3">

    <asp:Button ID="Send" runat="server" 
        CssClass="th-btn sendbutton " 
        Text="ارسال الطلب" 
        OnClick="Send_Click" />
             </div>
                         
</div>
                                </div>
                               <div id="text" runat="server" visible="false" class="alert alert-success">
                                     تم ارسال الطلب
                               </div>
                                  
                              

                            </form>

                        </div>
                    </div>
                    <div class="col-xl-5 order-0 order-xl-1">
                        <div class="contact-thumb">
                            <img src="/assets/img/normal/contact.jpg" alt="" />
                        </div>
                    </div>
                </div>
            </div>

           
        </div>
    </div>

</asp:Content>

