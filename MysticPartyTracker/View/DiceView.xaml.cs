using MysticPartyTracker.Models;
using MysticPartyTracker.ViewModels;
namespace MysticPartyTracker.View;

public partial class DiceView : ContentPage
{
    public DiceView()
    {
        InitializeComponent();
        SidesPicker.SelectedIndex = 0;
        QuantityPicker.SelectedIndex = 0;
        BindingContext = new DiceViewModel();
    }

    private void RollBtn_Clicked(object sender, EventArgs e)
    {
 
        int numberSides = (int)SidesPicker.SelectedItem;
        int quantity = (int)QuantityPicker.SelectedItem;

        Dice dice = new(numberSides);

        string finalResult = "";
        int total = 0;

        for (int i = 0; i < quantity; i++)
        {
            int roll = dice.Roll();
            Console.WriteLine(roll);
            total += roll;
            finalResult += $"Dado {i + 1} = {roll} \n";
            if (i < quantity - 1)
                finalResult += "\n";
        }

        resultString.Text = $"Foram jogados {quantity} dado(s) de {numberSides} lados.";
        AllDicesResultLabel.Text = $"Resultado:\n\n{finalResult}\n"; ;
        DicesSumLabel.Text = $"Soma: {total}";

    }

}
