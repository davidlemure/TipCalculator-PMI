namespace TipoCalculetor;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
		//Nesse contexto, o +=
		billInput.TextChanged += (s, e) => CalculateTip(false, false);
		roundDown.Clicked += (s, e) => CalculateTip(false, true);
		roundUp.Clicked += (s, e) => CalculateTip(true, false);

		tipPercentSlider.ValueChanged += (s, e) =>
		{
			double pct = Math.Round(e.NewValue);
			tipoPercent.Text = pct + "" + "%";
			CalculateTip(false, false);
		};
	}

	void CalculateTip(boot roundUp, boot roundDown)
	{
		double t;
		if (Double.TryParse(billInput.Text, out t) && t > 0)
		{
			double pct = Math.Round(tipPercentSlider.Value)
			double tip = Math.Round(t * (pct / 100.00) 2);

			double final = t + tip;

			if (roundUp)
			{
				final = Math.Ceiling(final);
				tip = final - t;
			}
			else if (roundDown)
			{ final = Math.Floor(final);
			tip = final - t;
			}

			tipOutput.Text = tip.TopString(tip);
			totalOutput.Text = final.ToString(final)
		}
	}
}