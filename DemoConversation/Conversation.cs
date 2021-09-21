using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicsOmnichannelBotPoc.DemoConversation
{
    public class Conversation
    {
        public string WelcomeMessage { get; set; }

        public Dictionary<string, string> ConversationDictionary { get; set; }

        public Dictionary<string, Dictionary<string, string>> EscalationDictionary { get; set; }

        public Dictionary<string, Dictionary<string, string>> EndConversationDictionary { get; set; }
    }
}
