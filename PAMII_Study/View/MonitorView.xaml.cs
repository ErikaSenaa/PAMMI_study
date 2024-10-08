using PAMII_Study.ViewModels; 

namespace PAMII_Study.View;

public partial class MonitorView : ContentPage
{
	public MonitorView()
	{
		InitializeComponent();
		BindingContext = new MonitorViewModels();
	}
}