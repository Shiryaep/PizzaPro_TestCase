namespace PizzaPro;

public partial class CartPage : ContentPage
{
	DataClass dataClass = new DataClass();
	public CartPage(DataClass dataClassPass)
	{
		InitializeComponent();
		dataClass = dataClassPass;
		PriceLabel.Text = dataClass.GetSumOfPurchase().ToString();
        UpdateCounts();
    }

    private async void PizzaOperationBtnClicked(object sender, EventArgs e)
    {
        if (sender == Pizza1PlusBtn) dataClass.ChangeCount(1, 1);
        else if (sender == Pizza2PlusBtn) dataClass.ChangeCount(2, 1);
        else if (sender == Pizza3PlusBtn) dataClass.ChangeCount(3, 1);
        else if (sender == Pizza4PlusBtn) dataClass.ChangeCount(4, 1);
        else if (sender == Pizza1MinusBtn) dataClass.ChangeCount(1, -1);
        else if (sender == Pizza2MinusBtn) dataClass.ChangeCount(2, -1);
        else if (sender == Pizza3MinusBtn) dataClass.ChangeCount(3, -1);
        else if (sender == Pizza4MinusBtn) dataClass.ChangeCount(4, -1);
        else await DisplayAlert("Привет", "Что-то пошло не так =(  Перезапустите приложение, пожалуйста", "Хорошо");
        UpdateCounts();
        UpdateSumm();
    }

    private void UpdateCounts()
    {
        Pizza1CountLabel.Text = dataClass.GetCount(1).ToString();
        Pizza2CountLabel.Text = dataClass.GetCount(2).ToString();
        Pizza3CountLabel.Text = dataClass.GetCount(3).ToString();
        Pizza4CountLabel.Text = dataClass.GetCount(4).ToString();
    }

    private void UpdateSumm()
    {
        PriceLabel.Text = dataClass.GetSumOfPurchase().ToString();
    }
}