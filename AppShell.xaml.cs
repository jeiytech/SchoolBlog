using SchoolBlog.Views;

namespace SchoolBlog;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Routings that end with "Pop" are not passed as a content page,
        //hence they are not called with their route: "Names"
        //Routing.RegisterRoute(route: "feedPage", typeof(FeedPage));
    }
}
