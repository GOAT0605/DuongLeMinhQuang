using Microsoft.AspNetCore.Mvc;

namespace Bai2.Models
{
    public class ModelDanhSach 
    {
        
            public string TenSanPham { get; set; }
            public int SoLuong { get; set; }
            public int DonGia { get; set; }
            public float TamTinh { get; set; }
            public float GiamGia { get; set; }
        public ModelDanhSach() { }
            public ModelDanhSach(string tenSanPham, int soLuong, int gia, float giamGia)
            {
                TenSanPham = tenSanPham;
                SoLuong = soLuong;
                DonGia = gia;
                GiamGia = giamGia;
            TamTinh = soLuong * gia;
                //TamTinh = soLuong * gia- (soLuong * gia)*giamGia/100;
            }
        
    }
}
