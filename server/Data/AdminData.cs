using server.Model;

namespace server.Data
{
    public class AdminData
    {
        public List<AdminDto> datas = new()
        {
            new AdminDto { id = 1, name = "管理員1", account = "admin1", password = "password1" },
            new AdminDto { id = 2, name = "管理員2", account = "admin2", password = "password2" },
        };
    }
}
