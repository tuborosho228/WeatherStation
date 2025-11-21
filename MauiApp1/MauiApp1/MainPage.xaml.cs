namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;
            lejbelek.Text = "imie i nazwisko";
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnCounterClickedtwo(object? sender, EventArgs e)
        { 
            przycisk2.Text = "nacisneto";
            if (count % 2 == 0)
            {
                zdjecie.IsVisible = true;
            }
            else
            { 
                zdjecie.IsVisible = false; 
            }
               CounterBtn.Text = $"Clicked {count} times";

  

        }
    }
}
