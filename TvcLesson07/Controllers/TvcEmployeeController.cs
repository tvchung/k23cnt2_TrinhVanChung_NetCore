using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TvcLesson07.Models;

namespace TvcLesson07.Controllers
{
    public class TvcEmployeeController : Controller
    {
        // Mock Data:
        private static List<TvcEmployee> tvcListEmployee = new List<TvcEmployee>()
        {
            new TvcEmployee
            {
                TvcId = 23001122,
                TvcName = "Trịnh Văn Chung",
                TvcBirthDay = new DateTime(1979, 5, 25),
                TvcEmail = "chungtrinhj@gmail.com",
                TvcPhone = "0978611889",
                TvcSalary = 12000000m,
                TvcStatus = true
            },
            new TvcEmployee
            {
                TvcId = 2,
                TvcName = "Trần Thị B",
                TvcBirthDay = new DateTime(1992, 8, 15),
                TvcEmail = "tranthib@example.com",
                TvcPhone = "0912345678",
                TvcSalary = 13500000m,
                TvcStatus = true
            },
            new TvcEmployee
            {
                TvcId = 3,
                TvcName = "Lê Văn C",
                TvcBirthDay = new DateTime(1988, 3, 22),
                TvcEmail = "levanc@example.com",
                TvcPhone = "0934567890",
                TvcSalary = 10000000m,
                TvcStatus = false
            },
            new TvcEmployee
            {
                TvcId = 4,
                TvcName = "Phạm Thị D",
                TvcBirthDay = new DateTime(1995, 11, 5),
                TvcEmail = "phamthid@example.com",
                TvcPhone = "0976543210",
                TvcSalary = 15000000m,
                TvcStatus = true
            },
            new TvcEmployee
            {
                TvcId = 5,
                TvcName = "Đỗ Văn E",
                TvcBirthDay = new DateTime(1991, 7, 18),
                TvcEmail = "dovane@example.com",
                TvcPhone = "0981122334",
                TvcSalary = 11000000m,
                TvcStatus = false
            }
        };
        // GET: TvcEmployeeController
        public ActionResult TvcIndex()
        {
            return View(tvcListEmployee);
        }

        // GET: TvcEmployeeController/TvcDetails/5
        public ActionResult TvcDetails(int id)
        {
            var tvcEmployee = tvcListEmployee.FirstOrDefault(x => x.TvcId == id);
            return View(tvcEmployee);
        }

        // GET: TvcEmployeeController/TvcCreate
        public ActionResult TvcCreate()
        {
            var tvcEmployee = new TvcEmployee();
            return View(tvcEmployee);
        }

        // POST: TvcEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TvcCreate(TvcEmployee tvcModel)
        {
            try
            {
                // Thêm mới nhân viên vào list
                tvcModel.TvcId = tvcListEmployee.Max(x => x.TvcId) + 1;
                tvcListEmployee.Add(tvcModel);
                return RedirectToAction(nameof(TvcIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TvcEmployeeController/TvcEdit/5
        public ActionResult TvcEdit(int id)
        {
            var tvcEmployee = tvcListEmployee.FirstOrDefault(x => x.TvcId == id);
            return View(tvcEmployee);
        }

        // POST: TvcEmployeeController/TvcEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TvcEdit(int id, TvcEmployee tvcModel)
        {
            try
            {
                for (int i = 0; i < tvcListEmployee.Count(); i++)
                {
                    if (tvcListEmployee[i].TvcId == id)
                    {
                        tvcListEmployee[i] = tvcModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(TvcIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TvcEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TvcEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
