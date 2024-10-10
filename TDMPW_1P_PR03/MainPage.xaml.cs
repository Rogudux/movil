namespace TDMPW_1P_PR03;

public partial class MainPage : TabbedPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void conveDolar(object sender, EventArgs e){
            
                // Obtener el monto ingresado por el usuario y convertirilo a double para maniobrar
                double monto = Convert.ToDouble(montoEntry.Text);
                // Calcular conversion
                double dolar = monto/20;

                // Mostrar el resultado en un Label
                resultadoDolar.Text = $"Conversion a dolares: {dolar:C2}";
	}

        private void conveEuro(object sender, EventArgs e){ 

                // Obtener el monto ingresado por el usuario y convertirilo a double para maniobrar
                double montoEu = Convert.ToDouble(montoeuEntry.Text);
                // Calcular conversion
                double euro = montoEu/22.23;

                // Mostrar el resultado en un Label
                resultadoEuro.Text = $"Conversion a euros: {euro:C2}";
	}

        private void conveLibra(object sender, EventArgs e){ 
                
                // Obtener el monto ingresado por el usuario y convertirilo a double para maniobrar
                double montoli = Convert.ToDouble(montoliEntry.Text);
                // Calcular conversion
                double libra = montoli/26.21;

                // Mostrar el resultado en un Label
                resultadoLibra.Text = $"Conversion a libras esterlinas: {libra:C2}";
	}


}

