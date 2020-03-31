using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingApp
{
  public interface IAppRegionManager
  {
    public void SetViewInRegion(string viewName);
    public void SetViewInRegion(string viewName, string regionName);
  }
}
