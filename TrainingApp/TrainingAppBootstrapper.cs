using Prism.Ioc;
using System;
using TrainingApp.ViewModels.Main;
using TrainingApp.Views.UserControls.Excercise;
using TrainingApp.Views.UserControls.Main;

namespace TrainingApp
{
  internal class TrainingAppBootstrapper
  {
    internal static void RegisterTypes(IContainerRegistry container)
    {
      RegisterViews(container);
      RegisterViewModels(container);

      container.RegisterSingleton<IViewModelMediator, ViewModelMediator>();
      container.RegisterSingleton<IAppRegionManager, AppRegionManager>();
    }

    private static void RegisterViewModels(IContainerRegistry container)
    {
      container.RegisterSingleton<ExcercisesVM>();
      container.RegisterSingleton<MainVM>();
    }

    private static void RegisterViews(IContainerRegistry container)
    {
      container.Register<object, PlansView>(Constants.RegionNames.Plans);
      container.Register<object, UcExcercises>(Constants.RegionNames.Excercises);
    }
  }
}