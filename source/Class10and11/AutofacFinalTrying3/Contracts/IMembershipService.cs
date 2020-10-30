namespace Membership
{
    public interface IMembershipService
    {
        void ProvideMembership(string name, string email, string password);
    }
}