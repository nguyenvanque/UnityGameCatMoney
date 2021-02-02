
public class UserModel 
{
    public string ID { get; set; }

    public string TenTaiKhoan { get; set; }

    public string MatKhau { get; set; }
    public string Level { get; set; }
    public string Diem { get; set; }
    public UserModel(string ID, string TenTaiKhoan,  string MatKhau, string Level, string Diem)
    {
        this.ID = ID;
        this.TenTaiKhoan = TenTaiKhoan;
        this.MatKhau = MatKhau;
        this.Level = Level;
        this.Diem = Diem;
    }

    public UserModel()
    {
     
    }
}
