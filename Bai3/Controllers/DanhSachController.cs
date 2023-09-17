using Microsoft.AspNetCore.Mvc;
using Bai3.Models;
namespace Bai3.Controllers
{
    public class DanhSachController : Controller
    {
        public static List<ModelDanhSach> products = new List<ModelDanhSach>();
        public IActionResult Index(bool? check = false)
        {
            if ((bool)check)
            {
                products.Clear();
            }
            else
            {
                return View(products.ToList());
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(string tensanpham, int soluong, int dongia, int giamGia)
        {
            var homeProduct = new ModelDanhSach(tensanpham, soluong, dongia, giamGia);
            products.Add(homeProduct);
            return View(products);
        }

        public IActionResult RemoveProduct(int position)
        {
            products.RemoveAt(position - 1);
            return RedirectToAction("Index", "Home");
        }
    }
}
