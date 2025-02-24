Imports FortyFingers.DNN.Modules.PortalList.Components
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Services.Localization

Public Class Settings

    Inherits ModuleSettingsBase

    Dim objConfig As Config



    Public Overrides Sub LoadSettings()

        objConfig = New Config(Settings, ModuleId, TabModuleId)

        GetSettings(objConfig)

    End Sub

    Public Sub ResetSettings()

        Dim objConfigReset As Config = New Config(Settings, 0, 0)

        GetSettings(objConfigReset)

    End Sub




    Public Sub GetSettings(objConfig As Config)

        txtRootTemplate.Text = objConfig.RootTemplate
        txtItemTemplate.Text = objConfig.ItemTemplate
        txtMaxPortals.Text = objConfig.MaxPortals.ToString()

        chkFilter.Checked = objConfig.Filter
        chkFilterModeInclude.Checked = objConfig.FilterInclude
        txtPortalAliasFilter.Text = objConfig.PortalAliasFilter
        txtPortalDescriptionFilter.Text = objConfig.PortalDescriptionFilter
        txtPortalKeywordFilter.Text = objConfig.PortalKeywordFilter

        txtCategoryNameTemplate.Text = objConfig.CategoryNameTemplate
        txtCategoryFilter.Text = objConfig.CategoryFilter

    End Sub


    Public Overrides Sub UpdateSettings()

        objConfig = New Config(Settings, ModuleId, TabModuleId)

        objConfig.RootTemplate = txtRootTemplate.Text
        objConfig.ItemTemplate = txtItemTemplate.Text
        objConfig.MaxPortals = Val(txtMaxPortals.Text)

        objConfig.Filter = chkFilter.Checked
        objConfig.FilterInclude = chkFilterModeInclude.Checked

        objConfig.PortalAliasFilter = txtPortalAliasFilter.Text
        objConfig.PortalDescriptionFilter = txtPortalDescriptionFilter.Text
        objConfig.PortalKeywordFilter = txtPortalKeywordFilter.Text

        objConfig.CategoryNameTemplate = txtCategoryNameTemplate.Text
        objConfig.CategoryFilter = txtCategoryFilter.Text




    End Sub


End Class