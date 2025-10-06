namespace czcionka
{
    public partial class MainPage : ContentPage
    {
        private int obecnie = 0;
        private readonly List<string> greetings = new List<string>
            {
                "Dzień dobry",
                "Good morning",
                "Buenos dias",
                "Alloha"
            };
        
        public MainPage()
        {
            InitializeComponent();
            label1.Text = greetings[obecnie]; 
        }

      
        private void OnCounterClicked(object sender, EventArgs e)
        {
           
            obecnie = (obecnie + 1) % greetings.Count;
            label1.Text = greetings[obecnie];
        }
    }

}
