using TDMPW_412_3P_EX.MVVM.ViewModels;
namespace TDMPW_412_3P_EX.MVVM.Views;

public partial class SemestreView : ContentPage
{
    public SemestreViewModel TodosLosSemestres { get; set; }
    public SemestreView()
	{
        InitializeComponent();
        TodosLosSemestres = new SemestreViewModel(Navigation);
        BindingContext = TodosLosSemestres;
    }
}