Imports System.Collections
Imports DotNetNuke.Common.Utilities
Imports DotNetNuke.Entities.Modules
Imports DotNetNuke.Entities.Portals
Imports DotNetNuke.Services.Localization
Imports System.IO


Public Enum PortalOrder

    PortalId
    PortalAlias
    PortalName
    PortalCategory

End Enum

Public Enum SortOrderType

    ASC
    DESC

End Enum


Namespace Components
    ''' <summary>
    ''' config class for settings etc.
    ''' </summary>
    Public Class Config

#Region "Standard code"


        Private _settings As Hashtable = Nothing
        Private _moduleId As Integer = Null.NullInteger
        Private _tabModuleId As Integer = Null.NullInteger

        ''' <summary>
        ''' 40fingers config class 
        ''' </summary>
        ''' <param name="settings"></param>
        ''' <param name="moduleId"></param>
        ''' <param name="tabModuleId"></param>
        Public Sub New(ByVal settings As Hashtable, ByVal moduleId As Integer, ByVal tabModuleId As Integer)
            _settings = settings
            _moduleId = moduleId
            _tabModuleId = tabModuleId
        End Sub

        Private Function GetDefault(ByVal setting As String) As String
            Dim strOut As String
            strOut = Localization.GetString(setting, ConfigDefaultsResourceFile)

            'If strOut = String.Empty Then
            '    Return String.Format("Default Value for '{0}' not found in {1}", setting, ConfigDefaultsResourceFile)
            'Else
            '    Return strOut
            'End If

            Return strOut

        End Function

        Private Function GetSettingInt(ByVal setting As String, Optional ByVal useDefault As Boolean = True) As Integer
            Dim i As Integer = Null.NullInteger
            Dim settingValue As String = ""
            If _settings.ContainsKey(setting) Then
                settingValue = _settings(setting).ToString()
            ElseIf useDefault Then
                settingValue = GetDefault(setting)
            End If
            Integer.TryParse(settingValue, i)

            Return i
        End Function

        Private Function GetSettingBool(ByVal setting As String, Optional ByVal useDefault As Boolean = True) As Boolean
            Dim b As Boolean = Null.NullBoolean
            Dim settingValue As String = ""
            If _settings.ContainsKey(setting) Then
                settingValue = _settings(setting).ToString()
            ElseIf useDefault Then
                settingValue = GetDefault(setting)
            End If
            Boolean.TryParse(settingValue, b)

            Return b
        End Function

        Private Function GetSettingDateTime(ByVal setting As String, Optional ByVal useDefault As Boolean = True) As DateTime
            Dim d As DateTime = Null.NullDate
            Dim settingValue As String = ""
            If _settings.ContainsKey(setting) Then
                settingValue = _settings(setting).ToString()
            ElseIf useDefault Then
                settingValue = GetDefault(setting)
            End If
            DateTime.TryParse(settingValue, d)

            Return d
        End Function

        Private Function GetSetting(ByVal setting As String, Optional ByVal useDefault As Boolean = True) As String
            Dim settingValue As String = ""
            If _settings.ContainsKey(setting) Then
                settingValue = _settings(setting).ToString()
            ElseIf useDefault Then
                settingValue = GetDefault(setting)
            End If

            Return settingValue
        End Function


        Private _moduleCtrl As ModuleController
        Private ReadOnly Property ModuleCtrl() As ModuleController
            Get
                If _moduleCtrl Is Nothing Then
                    _moduleCtrl = New ModuleController()
                End If

                Return _moduleCtrl
            End Get
        End Property
#End Region





        Private Const ConfigDefaultsResourceFile As String = "~/DesktopModules/40Fingers/PortalList/App_LocalResources/ConfigDefaults.resx"


        Public Property RootTemplate() As String
            Get
                Return GetSetting("RootTemplate", True)
            End Get
            Set(ByVal value As String)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "RootTemplate", value)
            End Set
        End Property


        Public Property ItemTemplate() As String
            Get
                Return GetSetting("ItemTemplate", True)
            End Get
            Set(ByVal value As String)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "ItemTemplate", value.ToString())
            End Set
        End Property



        Public Property MaxPortals() As Integer
            Get
                Return GetSettingInt("MaxPortals", True)
            End Get
            Set(ByVal value As Integer)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "MaxPortals", value.ToString())
            End Set
        End Property


        Public Property SortType() As PortalOrder
            Get
                Return GetSettingInt("SortType", True)
            End Get
            Set(ByVal value As PortalOrder)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "SortType", value.ToString())
            End Set
        End Property


        Private _SortDirection As String
        Public Property SortDirection() As SortOrderType
            Get
                Return GetSettingInt("SortDirection", True)
            End Get
            Set(ByVal value As SortOrderType)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "SortDirection", value.ToString())
            End Set
        End Property



        Public Property Filter() As Boolean
            Get
                Return GetSettingBool("Filter", True)
            End Get
            Set(ByVal value As Boolean)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "Filter", value.ToString())
            End Set
        End Property

        Public Property FilterInclude() As Boolean
            Get
                Return GetSettingBool("FilterInclude", True)
            End Get
            Set(ByVal value As Boolean)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "FilterInclude", value.ToString())
            End Set
        End Property


        Public Property PortalIdFilter() As String
            Get
                Return GetSetting("PortalIdFilter", True)
            End Get
            Set(ByVal value As String)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "PortalIdFilter", value.ToString())
            End Set
        End Property



        Public Property PortalAliasFilter() As String
            Get
                Return GetSetting("PortalAliasFilter", True)
            End Get
            Set(ByVal value As String)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "PortalAliasFilter", value.ToString())
            End Set
        End Property


        Public Property PortalDescriptionFilter() As String
            Get
                Return GetSetting("PortalDescriptionFilter", True)
            End Get
            Set(ByVal value As String)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "PortalDescriptionFilter", value.ToString())
            End Set
        End Property



        Public Property PortalKeywordFilter() As String
            Get
                Return GetSetting("PortalKeywordFilter", True)
            End Get
            Set(ByVal value As String)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "PortalKeywordFilter", value.ToString())
            End Set
        End Property





        Public Property ScaleImages() As Boolean
            Get
                Return GetSettingBool("ScaleImages", True)
            End Get
            Set(ByVal value As Boolean)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "ScaleImages", value.ToString())
            End Set
        End Property



        Public Property CropImage() As Boolean
            Get
                Return GetSettingBool("CropImage", True)
            End Get
            Set(ByVal value As Boolean)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "CropImage", value.ToString())
            End Set
        End Property


        Public Property ImgWidth() As Boolean
            Get
                Return GetSettingInt("ImgWidth", True)
            End Get
            Set(ByVal value As Boolean)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "ImgWidth", value.ToString())
            End Set
        End Property

        Public Property ImgHeight() As Boolean
            Get
                Return GetSettingInt("ImgHeight", True)
            End Get
            Set(ByVal value As Boolean)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "ImgHeight", value.ToString())
            End Set
        End Property

        Public Property IconPath() As String
            Get
                Return GetSetting("IconPath", True)
            End Get
            Set(ByVal value As String)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "IconPath", value.ToString())
            End Set
        End Property

        Public Property Crop() As Boolean
            Get
                Return GetSettingBool("Crop", True)
            End Get
            Set(ByVal value As Boolean)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "Crop", value.ToString())
            End Set
        End Property

        Public Property CropCenterHorizontally() As Boolean
            Get
                Return GetSettingBool("CropCenterHorizontally", True)
            End Get
            Set(ByVal value As Boolean)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "CropCenterHorizontally", value.ToString())
            End Set
        End Property

        Public Property CropCenterVertically() As Boolean
            Get
                Return GetSettingBool("CropCenterVertically", True)
            End Get
            Set(ByVal value As Boolean)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "CropCenterVertically", value.ToString())
            End Set
        End Property


        Public Property CategoryNameTemplate() As String
            Get
                Return GetSetting("CategoryNameTemplate", True)
            End Get
            Set(ByVal value As String)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "CategoryNameTemplate", value.ToString())
            End Set
        End Property


        Public Property CategoryFilter() As String
            Get
                Return GetSetting("CategoryFilter", True)
            End Get
            Set(ByVal value As String)
                ModuleCtrl.UpdateModuleSetting(_moduleId, "CategoryFilter", value.ToString())
            End Set
        End Property


    End Class

End Namespace
