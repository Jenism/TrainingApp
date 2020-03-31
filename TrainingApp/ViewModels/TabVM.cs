using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingApp.ViewModels
{
  public class TabVM : BindableBase
  {
    private readonly IAppRegionManager appRegionManager;

    public string Name { get; set; }
    public string RegionName { get; set; }

    private DelegateCommand<string> mainTabClickedCmd;
    public DelegateCommand<string> MainTabClickedCmd => mainTabClickedCmd ?? new DelegateCommand<string>(OnMainTabClickedCmd);

    public TabVM(IAppRegionManager appRegionManager, string name, string regionName)
    {
      this.appRegionManager = appRegionManager;

      Name = name;
      RegionName = regionName;
    }
    private void OnMainTabClickedCmd(string viewName)
    {
      appRegionManager.SetViewInRegion(viewName);
    }
  }
}
