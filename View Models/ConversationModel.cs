using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SchoolBlog.View_Models
{
    class ConversationModel
    {
        public ICommand OpenChatCommand { get; private set; }

        public ConversationModel()
        {
            OpenChatCommand = new Command<string>(OpenChat);
        }

        private void OpenChat(string username)
        {
            // Logic to navigate to the chat page using the selected username
            // You can pass the selected username as a parameter to the chat page or store it in a shared property

            // Example navigation logic using Shell navigation:
            Shell.Current.GoToAsync($"chatpage?username={username}");
        }
    }
}
