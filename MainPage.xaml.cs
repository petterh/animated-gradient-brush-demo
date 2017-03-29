namespace AnimatedGradientBrush
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += (sender, args) => LoadingStoryBoard.Begin();
        }
    }
}
