﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Home.Master" AutoEventWireup="true" CodeBehind="editmember.aspx.cs" Inherits="SMWaterLevel.Members.editmember" %>
<%@ Register Src="~/UserControls/Sidebar.ascx" TagPrefix="SOFTWAREMYANMAR" TagName="Sidebar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Edit Member | SMWaterLevel
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <SOFTWAREMYANMAR:Sidebar runat="server" ID="Sidebar" />
    <asp:ScriptManager ID="scriptManagerUserProfile" runat="server">
        </asp:ScriptManager>
    <div class="content-wrapper">
        <section class="content-header">
            <h1>Edit Member
        <small>Modify</small>
            </h1>
            <ol class="breadcrumb">
                <li><a href="default"><i class="fa fa-dashboard"></i>Dashboard</a></li>
                <li><a href="#">Members</a></li>
                <li><a href="#">Member List</a></li>
                <li class="active">Edit Member</li>
            </ol>
        </section>
        <section class="content">
            <div class="row">
                <div class="col-md-12">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Edit Member</h3>
                        </div>
                        <div class="box-body">
                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <label>Member Name</label>
                                        <asp:TextBox ID="txtMemberName" runat="server" CssClass="form-control" placeholder="Enter Member Name"></asp:TextBox>
                                    </div>
                                     <div class="form-group">
                                        <label>Phone</label>
                                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" placeholder="Enter Phone"></asp:TextBox>
                                    </div>
                                       <div class="form-group">
                                        <label>Address</label>
                                        <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control" placeholder="Enter Address" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>Remark</label>
                                        <asp:TextBox ID="txtRemark" runat="server" CssClass="form-control" placeholder="Enter Remark" TextMode="MultiLine"></asp:TextBox>
                                    </div>
                                </div>
                                  
                            </div>
                        </div>
                        <div class="box-footer">
                            <asp:LinkButton ID="btnCancel" runat="server" CssClass="btn btn-default btn-flat" OnClick="btnCancel_Click"><i class="fa fa-rotate-left (alias)"></i> Cancel</asp:LinkButton>
                            <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-primary btn-flat pull-right" OnClick="btnEdit_Click" ><i class="fa fa-pencil"></i> Edit</asp:LinkButton>
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
