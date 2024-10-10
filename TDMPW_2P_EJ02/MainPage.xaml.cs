namespace TDMPW_2P_EJ02;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnSldChange(object sender, EventArgs e)
	{
		txtSld.Text = sldPrincipal.Value.ToString("N0");
	}

	private void OnSldRotate(object sender, EventArgs e)
	{
		txtRotate.Rotation = sldRotatate.Value;
	}

	private void OnSldChangeF(object sender, EventArgs e)
	{
		txtSldF.Text = sldF.Value.ToString("N0");
		txtSldF2.FontSize = sldF.Value;
	}

	private void OnStp(object sender, EventArgs e)
	{
		Stp.Text = stepper.Value.ToString("N0");
	}
}

