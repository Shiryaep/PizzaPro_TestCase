namespace PizzaPro;

public partial class MainPage : ContentPage
{
    DataClass dataClass = new DataClass();

    public MainPage()
	{
		InitializeComponent();
	}

	private async void OnPizzaBtnClicked(object sender, EventArgs e)
	{
		if (sender == Pizza1Btn) dataClass.ChangeCount(1, 1);
		else if (sender == Pizza2Btn) dataClass.ChangeCount(2, 1);
		else if (sender == Pizza3Btn) dataClass.ChangeCount(3, 1);
		else if (sender == Pizza4Btn) dataClass.ChangeCount(4, 1);
		else await DisplayAlert("Привет", "Что-то пошло не так =(  Перезапустите приложение, пожалуйста", "Хорошо");
	}
	private async void OnGoToCartBtnClicked(object sender, EventArgs e)
	{
		if (dataClass.isCartEmpty())
			await Navigation.PushAsync(new EmptyCartPage());
		else
			await Navigation.PushAsync(new CartPage(dataClass));
	}
}

