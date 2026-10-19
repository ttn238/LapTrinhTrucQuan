using Microsoft.EntityFrameworkCore;

namespace SoChiTieu.Models;

// DbContext ánh xạ bảng ChiTieu trong SQL Server.
public class QLChiTieuContext : DbContext
{
    public QLChiTieuContext(DbContextOptions<QLChiTieuContext> options) : base(options) { }
    public DbSet<ChiTieu> ChiTieu => Set<ChiTieu>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTieu>(entity =>
        {
            entity.ToTable("ChiTieu");
            entity.HasKey(e => e.MaCT);
            entity.Property(e => e.MaCT).UseIdentityColumn();
            entity.Property(e => e.NgayChi).HasColumnType("date");
            entity.Property(e => e.NoiDung).HasMaxLength(100).IsRequired();
            entity.Property(e => e.LoaiChi).HasMaxLength(30).IsRequired();
            entity.Property(e => e.SoTien).HasColumnType("decimal(18,0)");
            entity.Property(e => e.GhiChu).HasMaxLength(200);
        });
    }
}
