namespace PizzaPro;

public partial class CartPage : ContentPage
{
	DataClass dataClass = new DataClass();
	public CartPage(DataClass dataClassPass)
	{
		InitializeComponent();
		dataClass = dataClassPass;
		PriceLabel.Text = dataClass.GetSumOfPurchase().ToString();
    }

}