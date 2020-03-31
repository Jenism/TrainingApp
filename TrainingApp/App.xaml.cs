using Prism.Ioc;
using Prism.Ninject;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TrainingApp.ViewModels;
using TrainingApp.ViewModels.Main;
using TrainingApp.Views;
using TrainingApp.Views.UserControls.Excercise;
using TrainingApp.Views.UserControls.Main;

namespace TrainingApp
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : PrismApplication
  {
    protected override Window CreateShell()
    {
      var w = Container.Resolve<MainWindow>();
      return w;
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.Register<object, PlansView>(Constants.RegionNames.Plans);
      containerRegistry.Register<object, UcExcercises>(Constants.RegionNames.Excercises);
      containerRegistry.RegisterSingleton<MainVM>();
      containerRegistry.RegisterSingleton<IAppRegionManager, AppRegionManager>();
    }
  }
}
