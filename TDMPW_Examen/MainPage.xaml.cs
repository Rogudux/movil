namespace TDMPW_Examen;

public partial class MainPage : TabbedPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void conveWatts(object sender, EventArgs e){
            
                double ampe = Convert.ToDouble(ampeEntry.Text);
				double volt = Convert.ToDouble(voltEntry.Text);

                double wat = ampe*volt;

                // Mostrar el resultado en un Label
                resultadoWatts.Text = $"Watts resultantes: {wat} W";
	}

		private void conveWattsInd(object sender, EventArgs e){
            
                double ampeInd = Convert.ToDouble(ampeIndEntry.Text);
				double voltInd = Convert.ToDouble(voltIndEntry.Text);

                double watInd = ampeInd/voltInd;

                // Mostrar el resultado en un Label
                resultadoWattInd.Text = $"Watts industriales resultantes: {watInd} W";
	}

}

