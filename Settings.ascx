<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="Settings.ascx.vb" Inherits="FortyFingers.DNN.Modules.PortalList.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>

<div class="ffplSettings">
    <table>
	<tr>
		<td class="SubHead" valign="top">
            <dnn:label id="lblRootTemplate" controlname="lblRootTemplate" runat="server" Text="RootTemplate" suffix=":" /></td>
		<td>
        <asp:TextBox ID="txtRootTemplate" runat="server" CssClass="NormalTextBox RootTemplate" TextMode="MultiLine"></asp:TextBox>
		</td>
	</tr>
    	<tr>
		<td class="SubHead" valign="top">
            <dnn:label id="lblItemTemplate" controlname="lblItemTemplate" runat="server" Text="ItemTemplate" suffix=":" /></td>
		<td>
        <asp:TextBox ID="txtItemTemplate" runat="server" CssClass="NormalTextBox ItemTemplate" TextMode="MultiLine"></asp:TextBox>
		</td>
	</tr>

    <tr>
        <td class="SubHead" valign="top">
            <dnn:label id="lblMaxPortals" controlname="lblMaxPortals" runat="server" Text="MaxPortals" suffix=":" /></td>
         <td>
        <asp:TextBox ID="txtMaxPortals" runat="server" CssClass="NormalTextBox MaxPortals"></asp:TextBox>
		</td>
	</tr>

            <tr>
        <td class="SubHead" valign="top">
            
            <dnn:label id="lblNote" controlname="lblNote" runat="server" />
        </td>
        <td>
            <span><%= Localization.GetString("AllUsersFilter.Text", Me.LocalResourceFile)%></span>
            </td>
        </td>
        </tr>

<tr>
        <td class="SubHead" valign="top">
            <dnn:label id="lblFilter" controlname="lblFilter" runat="server" Text="Filter" suffix=":" /></td>
         <td>
            <asp:CheckBox ID="chkFilter" runat="server" />

		</td>
       </tr>


        <tr>
        <td class="SubHead" valign="top">
            <dnn:label id="lblFilterMode" controlname="lblFilterMode" runat="server" Text="Filter Mode Show" suffix=":" />
        </td>
         <td>
              <asp:CheckBox ID="chkFilterModeInclude" runat="server" />
		</td>
       </tr>
            <tr>
            <td class="SubHead" valign="top" colapan="2">
               <dnn:label id="lblPortal" controlname="lblPortal" runat="server" Text="Portal Filters" suffix=":" /></td>
             <td>
       </tr>
    <tr>
        <td class="SubHead" valign="top">
            <dnn:label id="lblPortalAliasFilter" controlname="lblPortalAliasFilter" runat="server" Text="Portal Alias Filter" suffix=":" /></td>
         <td>
       <asp:TextBox ID="txtPortalAliasFilter" runat="server" CssClass="NormalTextBox PortalAliasFilter"></asp:TextBox>
		</td>
       </tr>
    <tr>
        <td class="SubHead" valign="top">
            <dnn:label id="lblPortalDescriptionFilter" controlname="lblPortalDescriptionFilter" runat="server" Text="Portal Decription Filter" suffix=":" />

        </td>
         <td>
       <asp:TextBox ID="txtPortalDescriptionFilter" runat="server" CssClass="NormalTextBox PortalDescriptionFilter"></asp:TextBox>

		</td>
       </tr>

            <tr>
        <td class="SubHead" valign="top">

            <dnn:label id="lblPortalKeywordFilter" controlname="lblPortalKeywordFilter" runat="server" Text="Portal Keyword Filter" suffix=":" />

        </td>
         <td>
       <asp:TextBox ID="txtPortalKeywordFilter" runat="server" CssClass="NormalTextBox PortalKeywordFilter"></asp:TextBox>
		</td>
       </tr>
            <tr>
            <td class="SubHead" valign="top" colapan="2">
               <dnn:label id="lblCategories"  controlname="lblCategories" runat="server" Text="Categories" suffix=":" /></td>
             <td>
       </tr>
            <tr>
        <td class="SubHead" valign="top">
            <dnn:label id="lblCategoryNameTemplate" controlname="lblCategoryNameTemplate" runat="server" Text="Name Template" suffix=":" /></td>
         <td>
       <asp:TextBox ID="txtCategoryNameTemplate" runat="server" CssClass="NormalTextBox CategoryNameTemplate" TextMode="MultiLine"></asp:TextBox>
		</td>
       </tr>
    <tr>
        <td class="SubHead" valign="top">
            <dnn:label id="lblCategoryFilter" controlname="lblCategoryFilter" runat="server" Text="Category Filter" suffix=":" /></td>
         <td>
       <asp:TextBox ID="txtCategoryFilter" runat="server" CssClass="NormalTextBox CategoryFilter" TextMode="MultiLine"></asp:TextBox>
		</td>
       </tr>
    

</table>


</div>

