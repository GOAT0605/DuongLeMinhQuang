using Microsoft.AspNetCore.Mvc;

namespace Bai3.Models
{
    public class ModelDanhSach : Controller
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public float TamTinh { get; set; }
        public float GiamGia { get; set; }
        public double TienDaGiam { get; set; }
        public ModelDanhSach() { }
        public ModelDanhSach(string tenSanPham, int soLuong, int gia, float giamGia)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = gia;
            GiamGia = giamGia;
            TamTinh = soLuong * gia;
            TienDaGiam = soLuong*gia*giamGia/100 ;
            
        }

    }
}

