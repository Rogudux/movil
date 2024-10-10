namespace TDMPW_01;

public partial class Kel : ContentPage
{

	int n1 = 0;
	int con = 0;
	public Kel()
	{
		InitializeComponent();
	}

	private void kell(object sender, EventArgs e){
		this.n1 =int.Parse(far.Text);

		this.con = (int)(n1 +  273.15);
		txt.Text = "Grados Kelvin: " + this.con.ToString();
	}
}