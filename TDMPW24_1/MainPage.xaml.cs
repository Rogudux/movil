namespace TDMPW24_1;

public partial class MainPage : ContentPage
{
	int count = 0;
	int n1 = 0;
	int n2 = 0;
	int resultado = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	 private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void calcularSuma(object sender, EventArgs e){
		this.n1 =int.Parse(txN1.Text);
		this.n2 =int.Parse(txN2.Text);

		this.resultado = this.n1 + this.n2;
		txresultadoSuma.Text = "El resultado de la suma es: " + this.resultado.ToString();		
	}
	private void calcularResta(object sender, EventArgs e){
		this.n1 =int.Parse(txN1.Text);
		this.n2 =int.Parse(txN2.Text);

		this.resultado = this.n1 - this.n2;
		txresultadoSuma.Text = "El resultado de la resta es: " + this.resultado.ToString();
	}

	private void calcularMulti(object sender, EventArgs e){
		this.n1 =int.Parse(txN1.Text);
		this.n2 =int.Parse(txN2.Text);

		this.resultado = this.n1 * this.n2;
		txresultadoSuma.Text = "El resultado de la multiplicacion es: " + this.resultado.ToString();
	}

	private void calcularDivi(object sender, EventArgs e){
		this.n1 =int.Parse(txN1.Text);
		this.n2 =int.Parse(txN2.Text);

		this.resultado = this.n1 / this.n2;
		txresultadoSuma.Text = "El resultado de la division es: " + this.resultado.ToString();
	}

	private async void irNuevo(object sender, EventArgs e){
		await Navigation.PushAsync(new Nuevo());
        
    }
}

