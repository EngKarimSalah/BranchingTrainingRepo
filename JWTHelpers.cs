namespace School
{
    public class JWTHelpers
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string GenerateToken()
        { return ""; }

        public bool ValidateToken(string token)
        { return true; }

    }
}
