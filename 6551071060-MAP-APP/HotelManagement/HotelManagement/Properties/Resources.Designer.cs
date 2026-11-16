#nullable enable
namespace HotelManagement.Properties
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {
        private static global::System.Resources.ResourceManager? resourceMan;
        private static global::System.Globalization.CultureInfo? resourceCulture;

        internal Resources() { }

        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    var temp = new global::System.Resources.ResourceManager("HotelManagement.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo? Culture
        {
            get => resourceCulture;
            set => resourceCulture = value;
        }

        private static System.Drawing.Bitmap GetBitmap(string name)
            => (System.Drawing.Bitmap)ResourceManager.GetObject(name, resourceCulture)!;

        internal static System.Drawing.Bitmap DangNhap => GetBitmap(nameof(DangNhap));
        internal static System.Drawing.Bitmap pictureIcon => GetBitmap(nameof(pictureIcon));
        internal static System.Drawing.Bitmap HotelBanner => GetBitmap(nameof(HotelBanner));
        internal static System.Drawing.Bitmap Menu => GetBitmap(nameof(Menu));
        internal static System.Drawing.Bitmap user => GetBitmap(nameof(user));
        internal static System.Drawing.Bitmap MenuTrangChu => GetBitmap(nameof(MenuTrangChu));
        internal static System.Drawing.Bitmap MenuSoDoPhong => GetBitmap(nameof(MenuSoDoPhong));
        internal static System.Drawing.Bitmap MenuPhong => GetBitmap(nameof(MenuPhong));
        internal static System.Drawing.Bitmap MenuLoaiPhong => GetBitmap(nameof(MenuLoaiPhong));
        internal static System.Drawing.Bitmap MenuDatPhong => GetBitmap(nameof(MenuDatPhong));
        internal static System.Drawing.Bitmap MenuDanhSachHoaDon => GetBitmap(nameof(MenuDanhSachHoaDon));
        internal static System.Drawing.Bitmap MenuQuanLyDichVu => GetBitmap(nameof(MenuQuanLyDichVu));
        internal static System.Drawing.Bitmap MenuTienNghi => GetBitmap(nameof(MenuTienNghi));
        internal static System.Drawing.Bitmap MenuQuanLyKhachHang => GetBitmap(nameof(MenuQuanLyKhachHang));
        internal static System.Drawing.Bitmap MenuQuanLyNhanVien => GetBitmap(nameof(MenuQuanLyNhanVien));
        internal static System.Drawing.Bitmap MenuQuanLyTaiKhoan => GetBitmap(nameof(MenuQuanLyTaiKhoan));
        internal static System.Drawing.Bitmap MenuThongKe => GetBitmap(nameof(MenuThongKe));
        internal static System.Drawing.Bitmap search => GetBitmap(nameof(search));
        internal static System.Drawing.Bitmap Phong => GetBitmap(nameof(Phong));
        internal static System.Drawing.Bitmap edit => GetBitmap(nameof(edit));
        internal static System.Drawing.Bitmap delete => GetBitmap(nameof(delete));
        internal static System.Drawing.Bitmap Giuong => GetBitmap(nameof(Giuong));
        internal static System.Drawing.Bitmap details => GetBitmap(nameof(details));
    }
}
