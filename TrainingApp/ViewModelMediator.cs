using System;
using System.Collections.Generic;
using System.Text;
using TrainingApp.ViewModels.Main;

namespace TrainingApp
{
  public interface IViewModelMediator
  {
    void AddNewExcercise(ExcerciseVM excercise);
  }

  class ViewModelMediator : IViewModelMediator
  {
    private readonly ExcercisesVM excercisesVM;

    public ViewModelMediator(ExcercisesVM excercisesVM)
    {
      this.excercisesVM = excercisesVM;
    }

    public void AddNewExcercise(ExcerciseVM excercise)
    {
      excercisesVM.Excercises.Add(excercise);
    }
  }
}
