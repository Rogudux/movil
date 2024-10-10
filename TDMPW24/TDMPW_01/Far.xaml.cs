namespace TDMPW_01;

public partial class Far : ContentPage
{
	float n1 = 0;
	int con = 0;
	public Far()
	{
		InitializeComponent();
	}

	private void farr(object sender, EventArgs e){
		this.n1 =int.Parse(far.Text);

		this.con = (int)((n1 * 9/5) + 32);
		txt.Text = "Grados Fahrenheit: " + this.con.ToString();
	}

}