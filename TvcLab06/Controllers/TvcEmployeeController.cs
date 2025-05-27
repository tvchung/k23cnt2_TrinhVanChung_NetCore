using Microsoft.AspNetCore.Mvc;
using TvcLab06.Models;

namespace TvcLab06.Controllers
{
    public class TvcEmployeeController : Controller
    {
        private static List<TvcEmployee> tvcListEmployee = new List<TvcEmployee>()
        {
            new TvcEmployee { TvcId = 1, TvcName = "Trịnh Văn Chung", TvcBirthDay = new DateTime(1979, 1, 1), TvcEmail = "chungtrinhj@gmail.com", TvcPhone = "0978611889", TvcSalary = 12000000, TvcStatus = true },
            new TvcEmployee { TvcId = 2, TvcName = "Trần Thị B", TvcBirthDay = new DateTime(1992, 5, 15), TvcEmail = "b@example.com", TvcPhone = "0912233445", TvcSalary = 15000000, TvcStatus = true },
            new TvcEmployee { TvcId = 3, TvcName = "Lê Văn C", TvcBirthDay = new DateTime(1988, 9, 20), TvcEmail = "c@example.com", TvcPhone = "0922123456", TvcSalary = 11000000, TvcStatus = false },
            new TvcEmployee { TvcId = 4, TvcName = "Phạm Thị D", TvcBirthDay = new DateTime(1995, 3, 10), TvcEmail = "d@example.com", TvcPhone = "0933445566", TvcSalary = 13000000, TvcStatus = true },
            new TvcEmployee { TvcId = 5, TvcName = "Đỗ Văn E", TvcBirthDay = new DateTime(1991, 7, 25), TvcEmail = "e@example.com", TvcPhone = "0944567890", TvcSalary = 10000000, TvcStatus = false }

        };

        public IActionResult TvcIndex()
        {
            return View(tvcListEmployee);
        }

        // Action GET: /TvcEmployee/HvtCreate
        public IActionResult TvcCreate()
        {
            return View();
        }
        // POST: /TvcEmployee/TvcCreate
        [HttpPost]
        public IActionResult TvcCreate(TvcEmployee model)
        {
            if (ModelState.IsValid)
            {
                // Tự động tăng ID
                int newId = tvcListEmployee.Any() ? tvcListEmployee.Max(e => e.TvcId) + 1 : 1;
                model.TvcId = newId;

                tvcListEmployee.Add(model);

                // Chuyển hướng về trang danh sách
                return RedirectToAction("TvcIndex");
            }

            // Nếu dữ liệu không hợp lệ, hiển thị lại form
            return View(model);
        }
    }
}
