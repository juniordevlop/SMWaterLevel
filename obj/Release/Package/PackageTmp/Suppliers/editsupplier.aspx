﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="editsupplier.aspx.cs" Inherits="SMAccount.Suppliers.editsupplier" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Edit Supplier | SMAccount
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUserProfile" runat="server">
        </asp:ScriptManager>
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Edit Supplier
        <small>Modify</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#">Suppliers</a></li>
                <li><a href="#">Supplier List</a></li>
                <li class="active">Edit Supplier</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Modify Supplier</h3>
                        </div>
                        <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>Supplier Name</label>
                                        <asp:TextBox ID="txtSupplierName" runat="server" CssClass="form-control" placeholder="Enter Supplier Name"></asp:TextBox>
                                    </div>
                                     <div class="form-group">
                                        <label>Phone</label>
                                        <asp:TextBox ID="txtContactNo" runat="server" CssClass="form-control" placeholder="Enter Phone"></asp:TextBox>
                                    </div>                                

                                    <div class="form-group">
                                        <label>Address</label>
                                        <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" placeholder="Enter Address" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                   
                                </div>
                                </div>
                        </div>
                        <div class="box-footer">
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-default" OnClick="btnCancel_Click"><i class="fa fa-rotate-left (alias)"></i> Cancel</asp:LinkButton>
                            <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-primary pull-right" OnClick="btnEdit_Click"><i class="fa fa-pencil"></i> Edit</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <div class="clearfix"></div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="script" runat="server">
    <script src="../AdminLTE/plugins/jQuery/jquery-2.2.3.min.js"></script>
</asp:Content>
