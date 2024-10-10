namespace TDMPW_1P_PR02;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		
	}

	private void OnCalcularButtonClicked(object sender, EventArgs e)
        {
        
            
                // Obtener el monto ingresado por el usuario
                double monto = Convert.ToDouble(montoEntry.Text);

                // Obtener la tasa de IVA ingresada por el usuario
                double tasaIva = Convert.ToDouble(tasaEntry.Text);

                // Calcular el IVA
                double iva = monto * (tasaIva / 100);

                // Calcular el monto total con IVA
                double totalConIva = monto + iva;

                // Mostrar el resultado en un Label o en cualquier otro control
                resultadoLabel.Text = $"Monto con IVA: {totalConIva:C2}";
			
           
		}
}
