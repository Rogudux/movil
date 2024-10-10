namespace TDMPW_2P_PR02;

public partial class MainPage : TabbedPage
{
	public MainPage()
	{
		InitializeComponent();
	}

private void OnSldChange(object sender, EventArgs e)
	{
		txtSld.Text = sldPrincipal.Value.ToString("N0");
	}

private void a(object sender, EventArgs e)
	{
		f.Text = g.Value.ToString("N0");
	}

private void op(object sender, EventArgs e)
	{
		fee.Text = hg.Value.ToString("N0");
	}
}
