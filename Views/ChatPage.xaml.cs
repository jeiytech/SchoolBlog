using SchoolBlog.DataModel;

namespace SchoolBlog.Views;

public partial class ChatPage : ContentPage
{
	public ChatPage()
	{
		InitializeComponent();

        List<Message> feeds = new List<Message>
        {
            new Message{ProfileName="lol🦋", Text="https://i0.wp.com/therighthairstyles.com/wp-content/uploads/2021/04/1-black-bob-with-finger-coils?",
                Image="https://hairmotive.com/wp-content/uploads/2022/09/4c-Curly-Hairstyles-with-Braids.jpg", Username="@nothing", Time=". 10m"},
            new Message{ProfileName="Niffy💘", Text="https://w0.peakpx.com/wallpaper/173/377/HD-wallpaper-smile-dp-for-whatsapp-cute-smile-quotes-thumbnail",
                Image="https://pbs.twimg.com/media/FufMvIqXgAQMoCd?format=jpg", Username="@Jesu_nifemi_", Time = ". 30m"},
            new Message{ProfileName="Levi🥷⚔️☠️", Text="https://static.wikia.nocookie.net/shingekinokyojin/images/b/b1/Levi_Ackermann_%28Anime%29_character_image",
                Image="https://staticg.sportskeeda.com/editor/2023/01/2e16a-16727421584244-1920.jpg", Username="@ackermann001", Time = ". 2h"},
            new Message{ProfileName="Happy😀", Text="https://www.unigreet.com/wp-content/uploads/2020/04/Smiley-816x1024",
                Image="https://i.pinimg.com/564x/bf/2e/28/bf2e2856b8da4bb05f8e44a1719b6cab.jpg", Username="@be_happy", Time = ". 3h"},
            new Message{ProfileName="lol🦋", Text="https://i0.wp.com/therighthairstyles.com/wp-content/uploads/2021/04/1-black-bob-with-finger-coils?",
                Image="https://hairmotive.com/wp-content/uploads/2022/09/4c-Curly-Hairstyles-with-Braids.jpg", Username="@nothing", Time=". 10m"},
            new Message{ProfileName="Niffy💘", Text="https://w0.peakpx.com/wallpaper/173/377/HD-wallpaper-smile-dp-for-whatsapp-cute-smile-quotes-thumbnail",
                Image="https://pbs.twimg.com/media/FufMvIqXgAQMoCd?format=jpg", Username="@Jesu_nifemi_", Time = ". 30m"},
            new Message{ProfileName="Levi🥷⚔️☠️", Text="https://static.wikia.nocookie.net/shingekinokyojin/images/b/b1/Levi_Ackermann_%28Anime%29_character_image",
                Image="https://staticg.sportskeeda.com/editor/2023/01/2e16a-16727421584244-1920.jpg", Username="@ackermann001", Time = ". 2h"},
            new Message{ProfileName="Happy😀", Text="https://www.unigreet.com/wp-content/uploads/2020/04/Smiley-816x1024",
                Image="https://i.pinimg.com/564x/bf/2e/28/bf2e2856b8da4bb05f8e44a1719b6cab.jpg", Username="@be_happy", Time = ". 3h"},
            new Message{ProfileName="lol🦋", Text="https://i0.wp.com/therighthairstyles.com/wp-content/uploads/2021/04/1-black-bob-with-finger-coils?",
                Image="https://hairmotive.com/wp-content/uploads/2022/09/4c-Curly-Hairstyles-with-Braids.jpg", Username="@nothing", Time=". 10m"},
            new Message{ProfileName="Niffy💘", Text="https://w0.peakpx.com/wallpaper/173/377/HD-wallpaper-smile-dp-for-whatsapp-cute-smile-quotes-thumbnail",
                Image="https://pbs.twimg.com/media/FufMvIqXgAQMoCd?format=jpg", Username="@Jesu_nifemi_", Time = ". 30m"},
            new Message{ProfileName="Levi🥷⚔️☠️", Text="https://static.wikia.nocookie.net/shingekinokyojin/images/b/b1/Levi_Ackermann_%28Anime%29_character_image",
                Image="https://staticg.sportskeeda.com/editor/2023/01/2e16a-16727421584244-1920.jpg", Username="@ackermann001", Time = ". 2h"},
            new Message{ProfileName="Happy😀", Text="https://www.unigreet.com/wp-content/uploads/2020/04/Smiley-816x1024",
                Image="https://i.pinimg.com/564x/bf/2e/28/bf2e2856b8da4bb05f8e44a1719b6cab.jpg", Username="@be_happy", Time = ". 3h"},
            new Message{ProfileName="lol🦋", Text="https://i0.wp.com/therighthairstyles.com/wp-content/uploads/2021/04/1-black-bob-with-finger-coils?",
                Image="https://hairmotive.com/wp-content/uploads/2022/09/4c-Curly-Hairstyles-with-Braids.jpg", Username="@nothing", Time=". 10m"},
            new Message{ProfileName="Niffy💘", Text="https://w0.peakpx.com/wallpaper/173/377/HD-wallpaper-smile-dp-for-whatsapp-cute-smile-quotes-thumbnail",
                Image="https://pbs.twimg.com/media/FufMvIqXgAQMoCd?format=jpg", Username="@Jesu_nifemi_", Time = ". 30m"},
            new Message{ProfileName="Levi🥷⚔️☠️", Text="https://static.wikia.nocookie.net/shingekinokyojin/images/b/b1/Levi_Ackermann_%28Anime%29_character_image",
                Image="https://staticg.sportskeeda.com/editor/2023/01/2e16a-16727421584244-1920.jpg", Username="@ackermann001", Time = ". 2h"},
            new Message{ProfileName="Happy😀", Text="https://www.unigreet.com/wp-content/uploads/2020/04/Smiley-816x1024",
                Image="https://i.pinimg.com/564x/bf/2e/28/bf2e2856b8da4bb05f8e44a1719b6cab.jpg", Username="@be_happy", Time = ". 3h"},
            new Message{ProfileName="lol🦋", Text="https://i0.wp.com/therighthairstyles.com/wp-content/uploads/2021/04/1-black-bob-with-finger-coils?",
                Image="https://hairmotive.com/wp-content/uploads/2022/09/4c-Curly-Hairstyles-with-Braids.jpg", Username="@nothing", Time=". 10m"},
            new Message{ProfileName="Niffy💘", Text="https://w0.peakpx.com/wallpaper/173/377/HD-wallpaper-smile-dp-for-whatsapp-cute-smile-quotes-thumbnail",
                Image="https://pbs.twimg.com/media/FufMvIqXgAQMoCd?format=jpg", Username="@Jesu_nifemi_", Time = ". 30m"},
            new Message{ProfileName="Levi🥷⚔️☠️", Text="https://static.wikia.nocookie.net/shingekinokyojin/images/b/b1/Levi_Ackermann_%28Anime%29_character_image",
                Image="https://staticg.sportskeeda.com/editor/2023/01/2e16a-16727421584244-1920.jpg", Username="@ackermann001", Time = ". 2h"},
            new Message{ProfileName="Happy😀", Text="https://www.unigreet.com/wp-content/uploads/2020/04/Smiley-816x1024",
                Image="https://i.pinimg.com/564x/bf/2e/28/bf2e2856b8da4bb05f8e44a1719b6cab.jpg", Username="@be_happy", Time = ". 3h"},

        };

        MessagesListView.ItemsSource = feeds;
    }
}