using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrainingApp.Constants;

namespace TrainingApp.ViewModels.Main
{
  public class MainVM : BindableBase
  {
    private readonly IAppRegionManager appRegionManager;

    private ObservableCollection<TabVM> tabs;
    public ObservableCollection<TabVM> Tabs
    {
      get { return tabs; }
      set
      {
        if (tabs != value)
        {
          tabs = value;
          RaisePropertyChanged();
        }
      }
    }

    private ExcercisesVM excercises = new ExcercisesVM();
    public ExcercisesVM Excercises
    {
      get { return excercises; }
      set
      {
        if (excercises != value)
        {
          excercises = value;
          RaisePropertyChanged();
        }
      }
    }

    public MainVM(IAppRegionManager appRegionManager)
    {
      this.appRegionManager = appRegionManager;
      tabs = new ObservableCollection<TabVM>
      {
        new TabVM(appRegionManager, "Plans", RegionNames.Plans),
        new TabVM(appRegionManager, "Excercises", RegionNames.Excercises),
        new TabVM(appRegionManager, "Results", RegionNames.Results),
        new TabVM(appRegionManager, "Settings", RegionNames.Settings)
      };
    }
  }
}
