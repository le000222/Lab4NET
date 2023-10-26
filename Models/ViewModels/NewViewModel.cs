namespace Lab4NET.Models.ViewModels
{
    public class NewViewModel
    {
        public IEnumerable<SportClub> SportClubs { get; set; }
        public IEnumerable<Fan> Fans { get; set; }
        public IEnumerable<Subscription> Subscriptions { get; set; }
    }
}
