namespace Membership
{
    public interface IMembershipService
    {
        void CreateAccount(string username, string email, string password);
    }
}