namespace SoChiTieu.Models;

public class ChiTieu
{
    public int MaCT { get; set; }
    public DateTime NgayChi { get; set; }
    public string NoiDung { get; set; } = string.Empty;
    public string LoaiChi { get; set; } = string.Empty;
    public decimal SoTien { get; set; }
    public string? GhiChu { get; set; }
}
