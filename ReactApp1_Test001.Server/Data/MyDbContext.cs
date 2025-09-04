using Microsoft.EntityFrameworkCore;
using ReactApp1_Test001.Server.Models;

namespace ReactApp1_Test001.Server.Data
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // モデルの構成をここで行うことができます
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("MST_USER");
                entity.Property(e => e.EmployeeNo).HasColumnName("employee_no");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.NameKana).HasColumnName("name_kana");
                entity.Property(e => e.Department).HasColumnName("department");
                entity.Property(e => e.TelNo).HasColumnName("tel_no");
                entity.Property(e => e.MailAddress).HasColumnName("mail_address");
                entity.Property(e => e.Age).HasColumnName("age");
                entity.Property(e => e.Gender).HasColumnName("gender");
                entity.Property(e => e.Position).HasColumnName("position");
                entity.Property(e => e.AccountLevel).HasColumnName("account_level");
                entity.Property(e => e.RegisterDate).HasColumnName("register_date");
                entity.Property(e => e.UpdateDate).HasColumnName("update_date");
                entity.Property(e => e.RetireDate).HasColumnName("retire_date");
                entity.Property(e => e.DeleteFlag).HasColumnName("delete_flag");

            });
            // 他のエンティティの設定もここで行うことができます
        }
    }
    
}

