<%@ Page Title="" Language="C#" MasterPageFile="~/student.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="WebApplication1.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 28px;
        }
        .auto-style3 {
            width: 437px;
        }
        .auto-style4 {
            height: 28px;
            width: 437px;
        }
        .auto-style5 {
            height: 22px;
            width: 437px;
        }
        .auto-style6 {
            height: 22px;
        }
        .auto-style7 {
            width: 437px;
            height: 27px;
        }
        .auto-style8 {
            height: 27px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style7">Subject code:<asp:DropDownList ID="ddlsubject1" runat="server" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlsubject1_SelectedIndexChanged">
                <asp:ListItem>--SELECT--</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style3">Staff:<asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;
                </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">1.Approximate percentage of classes not engaged by the teacher.</td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>Less than 10 percent</asp:ListItem>
                    <asp:ListItem>Between 10-20 percent</asp:ListItem>
                    <asp:ListItem>More than 25 percent</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">2.whether the teacher dictates notes only without explanation</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                     <asp:ListItem>No</asp:ListItem>
                     <asp:ListItem>Yes</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">3.Knowledge of the teacher</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                   <asp:ListItem>Excellent</asp:ListItem> 
                    <asp:ListItem>Good</asp:ListItem>
                    <asp:ListItem>Fair</asp:ListItem>
                    <asp:ListItem>Poor</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">4.Clarity and understanding of teachers explanation</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList4" runat="server">
                    <asp:ListItem>Excellent</asp:ListItem> 
                    <asp:ListItem>Good</asp:ListItem>
                    <asp:ListItem>Fair</asp:ListItem>
                    <asp:ListItem>Poor</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">5.Teachers willingness to help</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList5" runat="server">
                    <asp:ListItem>Excellent</asp:ListItem> 
                    <asp:ListItem>Good</asp:ListItem>
                    <asp:ListItem>Fair</asp:ListItem>
                    <asp:ListItem>Poor</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">6.Teachers ability to organize lectures.</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList6" runat="server">
                    <asp:ListItem>Excellent</asp:ListItem> 
                    <asp:ListItem>Good</asp:ListItem>
                    <asp:ListItem>Fair</asp:ListItem>
                    <asp:ListItem>Poor</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">7.Speed of presentation</td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList7" runat="server">
                     <asp:ListItem>Just Right</asp:ListItem> 
                     <asp:ListItem>Too fast</asp:ListItem> 
                     <asp:ListItem>Too slow</asp:ListItem> 
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">8.Does the teacher encourage questioning</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList8" runat="server">
                     <asp:ListItem>No</asp:ListItem>
                     <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>Sometimes</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">9.Behaviour of the teacher</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList9" runat="server">
                    <asp:ListItem>Pleasant</asp:ListItem>
                    <asp:ListItem>Unpleasant</asp:ListItem>
                    <asp:ListItem>Indifferent</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">10.Sincerity of the teacher</td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList10" runat="server">
                     <asp:ListItem>Sincere</asp:ListItem>
                     <asp:ListItem>Not sincere</asp:ListItem>
                     <asp:ListItem>Unable to judge</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">11.Overall teaching effectiveness</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:RadioButtonList ID="RadioButtonList11" runat="server">
                     <asp:ListItem>Excellent</asp:ListItem> 
                    <asp:ListItem>Good</asp:ListItem>
                    <asp:ListItem>Fair</asp:ListItem>
                    <asp:ListItem>Poor</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" Text="NEXT" OnClick="Button1_Click"   />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
