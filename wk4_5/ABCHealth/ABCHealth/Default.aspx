<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ABCHealth._Default" %>

<asp:Content ContentPlaceHolderID="FeaturedContent" ID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Your friendly neighbourhood Drug store</h1>
            </hgroup>
        </div>
    </section>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><% Title %></h1>
    <h2>E Store web Application can help you find the perfect drugs.</h2>
    <p="lead">We're are all about drugs. You can order any dose of cocaine today.
        Each cocaine supply listing has detailed information to help you choose the
        right flavour.
    </p>
</asp:Content>
