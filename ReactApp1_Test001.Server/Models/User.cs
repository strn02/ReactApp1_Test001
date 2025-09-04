namespace ReactApp1_Test001.Server.Models
{
    public class User
    {
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public string NameKana { get; set; }
        public string Department { get; set; }
        public string TelNo { get; set; }
        public string MailAddress { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string AccountLevel { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime RetireDate { get; set; }
        public Boolean DeleteFlag { get; set; }
        // パスワードのハッシュ化や検証のためのメソッドを追加することもできます
    }
}
