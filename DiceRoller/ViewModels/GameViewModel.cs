using CommunityToolkit.Mvvm.ComponentModel;

namespace DiceRoller.ViewModels
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string diceImage;

        [ObservableProperty]
        private string nomeUsuario;

        public GameViewModel()
        {
            DiceImage = "dice1.img";
            NomeUsuario = "Eu";
        }
    }
}