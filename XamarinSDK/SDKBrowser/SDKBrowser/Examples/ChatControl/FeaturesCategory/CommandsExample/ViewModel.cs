﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Telerik.XamarinForms.ConversationalUI;
using Xamarin.Forms;

namespace SDKBrowser.Examples.ChatControl.FeaturesCategory.CommandsExample
{
    public class ViewModel
    {
        // >> chat-commands-viewmodel
        public ViewModel()
        {
            this.Items = new ObservableCollection<ChatItem>();
            this.NewMessageCommand = new Command(NewMessageCommandExecute);

            this.MessagesLog = new ObservableCollection<string>();
        }

        public ObservableCollection<string> MessagesLog { get; set; }
        public ICommand NewMessageCommand { get; set; }
        public IList<ChatItem> Items { get; set; }
        // << chat-commands-viewmodel

        // >> chat-commands-executemethod
        private void NewMessageCommandExecute(object obj)
        {
            var newMessage = (string)obj;
            //any additional logic you need to implement    
            this.MessagesLog.Add("You just added a new message with text " + newMessage);
        }
        // << chat-commands-executemethod
    }
}
