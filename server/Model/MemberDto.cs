namespace server.Model
{
    public class MemberDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string account { get; set; }
        public string password { get; set; }
        public bool isvip { get; set; }
    }

    public class LoginDto
    {
        public string account { get; set; }
        public string password { get; set; }
    }
}
