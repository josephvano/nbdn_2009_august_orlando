namespace nothinbutdotnetprep.infrastructure.events
{
    public delegate void OurEventHandler<Sender,Data>(OurEventArgs<Sender,Data> args);
}