namespace Silicon_Blazor_Main_App.Data
{
    public class UserProfile
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? ProfileImage { get; set; }
        public string? Biography { get; set; }
    }
}