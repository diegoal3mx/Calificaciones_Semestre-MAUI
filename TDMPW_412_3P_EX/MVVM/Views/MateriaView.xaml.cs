using System.Diagnostics;
using TDMPW_412_3P_EX.MVVM.ViewModels;

namespace TDMPW_412_3P_EX.MVVM.Views;

public partial class MateriaView : ContentPage
{
    public MateriaViewModel TodasLasMaterias { get; set; }
    public MateriaView()
	{
		InitializeComponent();
        TodasLasMaterias = new MateriaViewModel(Navigation);
        BindingContext = TodasLasMaterias;
        lblTituloRubro1.BindingContext = TodasLasMaterias;
        lblTituloRubro2.BindingContext = TodasLasMaterias;
        lblTituloRubro3.BindingContext = TodasLasMaterias;
        lblEditTituloRubro1.BindingContext = TodasLasMaterias;
        lblEditTituloRubro2.BindingContext = TodasLasMaterias;
        lblEditTituloRubro3.BindingContext = TodasLasMaterias;
    }

}