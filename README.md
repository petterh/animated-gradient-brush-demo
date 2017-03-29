# animated-gradient-brush-demo

Minimal &ndash; but complete &ndash; demonstration of UWP app with animated gradient-brush background,
initiated by [this question on Stack Overflow](http://stackoverflow.com/questions/40492454/animating-a-gradientbrush-in-uwp).

The gist of it goes like this:

## XAML

    <Grid x:Name="LogoGrid">
        <Grid.Resources>
            <Storyboard x:Name="LoadingStoryBoard">
                <ColorAnimationUsingKeyFrames
                    Storyboard.TargetName="LogoGrid"
                    Storyboard.TargetProperty="(UIElement.Background).(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)"
                    RepeatBehavior="Forever"
                    EnableDependentAnimation="True">
                    <LinearColorKeyFrame Value="#FFFF0000" KeyTime="0:0:1" />
                    <LinearColorKeyFrame Value="#FFFFFF00" KeyTime="0:0:2" />
                </ColorAnimationUsingKeyFrames>
            </Storyboard>
        </Grid.Resources>
        <Grid.Background>
            <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
                <GradientStop Color="Transparent" Offset="0" />
                <GradientStop Color="#FFFFFF00" Offset="0.5" /><!-- Animation target -->
                <GradientStop Color="Transparent" Offset="1" />
            </LinearGradientBrush>
        </Grid.Background>
    </Grid>

## C#

    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += (sender, args) => LoadingStoryBoard.Begin();
        }
    }

This has been tested on desktop and mobile (Lumia 950).
