namespace TDMPW_2P_PR03;

public partial class MainPage : ContentPage
{
    private int currentSlider = 1; // Variable para rastrear el slider actual

    public MainPage()
    {
        InitializeComponent();
    }

    // Manejar el clic en cualquiera de los botones para incrementar el valor
    private void OnButtonClicked(object sender, EventArgs e)
    {
        // Cambiar la habilitación de los botones
        if (sender == boton1)
        {
            boton1.IsEnabled = false;
            boton2.IsEnabled = true;
        }
        else if (sender == boton2)
        {
            boton1.IsEnabled = true;
            boton2.IsEnabled = false;
        }

        // Incrementar el valor del slider correspondiente
        switch (currentSlider)
        {
            case 1:
                if (slider1.Value < slider1.Maximum)
                {
                    slider1.Value++;
                }

                // Cambiar al Slider 2 si el Slider 1 alcanza 10
                if (slider1.Value >= 10)
                {
                    currentSlider = 2;
                    slider2.IsVisible = true; // Hacer visible el Slider 2
                }
                break;

            case 2:
                if (slider2.Value < slider2.Maximum)
                {
                    slider2.Value++;
                }

                // Cambiar al Slider 3 si el Slider 2 alcanza 30
                if (slider2.Value >= 30)
                {
                    currentSlider = 3;
                    slider3.IsVisible = true; // Hacer visible el Slider 3
                }
                break;

            case 3:
                if (slider3.Value < slider3.Maximum)
                {
                    slider3.Value++;
                }

                // Actualizar el Label cuando el Slider 3 alcanza 50
                if (slider3.Value >= 50)
                {
                    boton1.IsEnabled = false; // Desactivar el botón
                    boton2.IsEnabled = false; // Desactivar el botón
                    felicidades.Text = "¡Has alcanzado el valor máximo!"; // Actualizar el mensaje
                }
                break;
        }

        UpdateSliderValueLabels(); // Actualiza las etiquetas del valor de los sliders
    }

    // Manejar el cambio de valor de los sliders
    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        UpdateSliderValueLabels(); // Actualiza las etiquetas del valor de los sliders
    }

    // Método para actualizar las etiquetas de los valores
    private void UpdateSliderValueLabels()
    {
        valorslider1.Text = slider1.Value.ToString("F0");
        valorslider2.Text = slider2.Value.ToString("F0");
        valorslider3.Text = slider3.Value.ToString("F0");
    }
	
}
