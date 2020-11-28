using System;
using System.Data.SqlClient;

namespace Membership
{
    public class AccountService : IMembershipService
    {
        public void CreateAccount(string username, string email, string password)
        {
            password = "--Hello--";
            password = "12345'); Delete from [User]; -- '";
            var sql = $"Insert into [Users] (username, email, password) Values('{username}', '{email}', '{password}')";

            var result = @"Insert into [Users] (username, email, password) Values('jalaluddin', 'info@devskill.com','12345'); 
Drop table [Users]; --'')";

            var sqlCommand = new SqlCommand("Insert into [Users] (username, email, password) Values(@username, @email, @password)");
            sqlCommand.Connection = new SqlConnection("");
            sqlCommand.Parameters.Add(new SqlParameter("@username", username));
            sqlCommand.Parameters.Add(new SqlParameter("@email", username));
            sqlCommand.Parameters.Add(new SqlParameter("@password", username));
            sqlCommand.ExecuteNonQuery();
        }
    }
}
