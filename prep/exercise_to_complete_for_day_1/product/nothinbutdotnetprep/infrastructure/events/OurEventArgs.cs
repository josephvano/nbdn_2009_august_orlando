using System;

namespace nothinbutdotnetprep.infrastructure.events
{
    public class OurEventArgs<Sender,Item> :EventArgs
    {
        public Sender sender { get; private set; }
        public Item event_data { get; private set; }

        public OurEventArgs(Sender sender, Item event_data)
        {
            this.sender = sender;
            this.event_data = event_data;
        }
    }
}