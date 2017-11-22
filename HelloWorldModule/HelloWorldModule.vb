Imports Prism.Modularity
Imports Prism.Regions

Public Class HelloWorldModule : Implements IModule

    Private ReadOnly _regionManager As IRegionManager

    Public Sub New(regionManager As IRegionManager)
        _regionManager = regionManager
    End Sub


    Public Sub Initialize() Implements IModule.Initialize

        _regionManager.RegisterViewWithRegion("ContentRegion", GetType(HelloWorldView))

    End Sub



End Class
