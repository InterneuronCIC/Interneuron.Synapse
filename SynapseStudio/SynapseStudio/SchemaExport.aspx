﻿<%--
Interneuron Synapse

Copyright (C) 2018  Interneuron CIC



This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  

See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
--%>

<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SchemaExport.aspx.cs" Inherits="SynapseStudio.SchemaExport" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1>
                    <asp:Label ID="lblSummaryType" runat="server" Text="List Manager"> Export Schema</asp:Label>
                </h1>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-4">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h3 class="panel-title"><i class="fa fa-list"></i>&nbsp;All Objects On This Server</h3>
                    </div>
                    <div class="panel-body">
                        <div class="col-md-12">
                            <div class="row">
                                <asp:Label ID="lblMsgSelectObjects" runat="server" CssClass="control-label" for="tv" Text="Please select the objects to export from the list below" Font-Bold="true"></asp:Label>
                                <div class="col-md-12"></div>
                                <div class="col-md-12"></div>
                                <asp:TreeView ID="tv" runat="server" AutoGenerateDataBindings="False" OnTreeNodeCheckChanged="tv_TreeNodeCheckChanged"></asp:TreeView>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <asp:Button ID="btnExport" runat="server" CssClass="btn btn-primary pull-right" Text="Export Selected Objects" Width="200" OnClick="btnExport_Click" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-lg-4">
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h3 class="panel-title"><i class="fa fa-list"></i>
                            &nbsp;Import Schema Into This Server</h3>
                    </div>
                    <div class="panel-body">
                        <div class="col-md-12">
                            <div class="row">

                                <div class="col-md-12"></div>
                                <div class="col-md-12"></div>
                                <asp:Button ID="btnNavigateToImport" CssClass="btn btn-lg alert-warning center-block" runat="server" Text="Take Me To Import Schema " OnClick="btnNavigateToImport_Click" />

                            </div>
                        </div>


                    </div>
                </div>
            </div>

        </div>

    </div>
</asp:Content>
