using Microsoft.Maui.Controls;
using SchoolBlog.DataModel;

namespace SchoolBlog.Views;
public partial class FeedPage : ContentPage
{

    private double previousScrollY;
    private bool isHeaderVisible = true;
    private Color transparentColor = Color.FromRgba(0, 0, 0, 0);

    public FeedPage()
	{
		InitializeComponent();

        List<Feed> feeds = new List<Feed>
        {
            new Feed{ProfileName="lol🦋", ProfileImage="https://i0.wp.com/therighthairstyles.com/wp-content/uploads/2021/04/1-black-bob-with-finger-coils.jpg?",
                Image="https://hairmotive.com/wp-content/uploads/2022/09/4c-Curly-Hairstyles-with-Braids.jpg", Username="nothing", Time=". 10m"},
            new Feed{ProfileName="Niffy💘", ProfileImage="https://w0.peakpx.com/wallpaper/173/377/HD-wallpaper-smile-dp-for-whatsapp-cute-smile-quotes-thumbnail.jpg",
                Image="https://pbs.twimg.com/media/FufMvIqXgAQMoCd?format=jpg", Username="Jesu_nifemi_", Time = ". 30m"},
            new Feed{ProfileName="Levi🥷⚔️☠️", ProfileImage="https://static.wikia.nocookie.net/shingekinokyojin/images/b/b1/Levi_Ackermann_%28Anime%29_character_image.png",
                Image="https://staticg.sportskeeda.com/editor/2023/01/2e16a-16727421584244-1920.jpg", Username="ackermann001", Time = ". 2h"},
            new Feed{ProfileName="Happy😀", ProfileImage="https://www.unigreet.com/wp-content/uploads/2020/04/Smiley-816x1024.jpg",
                Image="https://i.pinimg.com/564x/bf/2e/28/bf2e2856b8da4bb05f8e44a1719b6cab.jpg", Username="be_happy", Time = ". 3h"}
        };

        MyFeedView.ItemsSource = feeds;

    }

    private async void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
    {
        await Task.Delay(100);
        double reducedHeight = 2 * headerGrid.Height;
        var increasedHeight = Mainview.Height + headerGrid.Height;
        if (e.ScrollY < previousScrollY && !isHeaderVisible)
        {
            await Task.Delay(1000);
            await headerGrid.TranslateTo(0, 0, 500, Easing.Linear);
            Mainview.Margin = new Thickness(0, 0, 0, 0);
            await Mainview.TranslateTo(0, 0, 700, Easing.Linear);
            isHeaderVisible = true;
        }
        else if (e.ScrollY > previousScrollY && isHeaderVisible)
        {
            await Task.Delay(1000);
            await headerGrid.TranslateTo(0, -headerGrid.Height, 700, Easing.Linear);
            Mainview.Margin = new Thickness(0, -headerGrid.Height, 0, 0);
            await Mainview.TranslateTo(0, 0, 500, Easing.Linear);
            isHeaderVisible = false;
        }

        previousScrollY = e.ScrollY;
    }

    void ContentPage_Unloaded(object? sender, EventArgs e)
    {
        // Stop and cleanup MediaElement when we navigate away
        mediaElement.Handler?.DisconnectHandler();
    }
}