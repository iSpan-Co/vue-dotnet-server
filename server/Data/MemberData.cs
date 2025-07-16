using server.Model;

namespace server.Data
{
    public class MemberData
    {
        public List<MemberDto> datas = new()
        {
            new MemberDto { id = 1, name = "小橘", account = "orange", password = "1234", isvip = true },
            new MemberDto { id = 1, name = "小花", account = "flower", password = "1234", isvip = false },
        };
    }
}
