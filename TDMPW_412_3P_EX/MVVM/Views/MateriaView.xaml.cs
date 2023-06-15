using System.Diagnostics;
using TDMPW_412_3P_EX.MVVM.ViewModels;

namespace TDMPW_412_3P_EX.MVVM.Views;

public partial class MateriaView : ContentPage
{
    MateriaViewModel mv = new MateriaViewModel();
    public MateriaView()
	{
		InitializeComponent();
        
        BindingContext = mv;
    }

    private void btnAdd_Clicked(System.Object sender, System.EventArgs e)
    {
      Debug.WriteLine(mv.materia.CalificacionFinal);
    }
}