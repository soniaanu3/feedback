﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WebApplication1.Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
          <div class="col-lg-12">
            <section class="panel">
              <header class="panel-heading">
                Basic Forms
              </header>
              <div class="panel-body">
                <form role="form">
                    <div class="col-lg-6">
                  <div class="form-group">
                    <label for="exampleInputEmail1">Email address</label>
                    <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Enter email">
                  </div>
                        </div>
                      <div class="col-lg-6">
                  <div class="form-group">
                    <label for="exampleInputPassword1">Password</label>
                    <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
                  </div>
                          </div>
                  <div class="form-group">
                    <label for="exampleInputFile">File input</label>
                    <input type="file" id="exampleInputFile">
                    <p class="help-block">Example block-level help text here.</p>
                  </div>
                  <div class="checkbox">
                    <label>
                                          <input type="checkbox"> Check me out
                                      </label>
                  </div>
                  <button type="submit" class="btn btn-primary">Submit</button>
                </form>

              </div>
            </section>
          </div>
         
</asp:Content>