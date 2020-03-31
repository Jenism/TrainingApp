using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingApp
{
  class AppRegionManager : IAppRegionManager
  {
    private IRegionManager regionManager;

    public AppRegionManager(IRegionManager regionManager)
    {
      this.regionManager = regionManager;
    }

    public void SetViewInRegion(string viewName)
    {
      regionManager.RequestNavigate(Constants.RegionNames.Main, new Uri(viewName, UriKind.Relative));
    }

    public void SetViewInRegion(string viewName, string regionName)
    {
      regionManager.RequestNavigate(regionName, new Uri(viewName, UriKind.Relative));
    }
  }
}
