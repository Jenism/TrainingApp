using Prism.Commands;
using Prism.Mvvm;

namespace TrainingApp.ViewModels.Main
{
  public class ExcerciseVM : BindableBase
  {

    private DelegateCommand<string> addExcerciseCmd;
    public DelegateCommand<string> MainTabClickedCmd => mainTabClickedCmd ?? new DelegateCommand<string>(OnMainTabClickedCmd);

    private string name = null;
    public string Name
    {
      get { return name; }
      set
      {
        if (name != value)
        {
          name = value;
          RaisePropertyChanged();
        }
      }
    }
    
    private string description = null;
    public string Description
    {
      get { return description; }
      set
      {
        if (description != value)
        {
          description = value;
          RaisePropertyChanged();
        }
      }
    }
  }
}