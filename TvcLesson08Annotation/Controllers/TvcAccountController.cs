using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TvcLesson08Annotation.Models;

namespace TvcLesson08Annotation.Controllers
{
    

    public class TvcAccountController : Controller
    {
        private static List<TvcAccount> tvcListAccount = new List<TvcAccount>()
        {
            new TvcAccount
                {
                    TvcId = 230022113,
                    TvcFullName = "Trịnh Văn Chung",
                    TvcEmail = "chungtrinhj@gmail.com",
                    TvcPhone = "0978611889",
                    TvcAddress = "Lớp K23CNT2",
                    TvcAvatar = "chungtrinhj.jpg",
                    TvcBirthday = new DateTime(1979, 5, 25),
                    TvcGender = "Nam",
                    TvcPassword = "0978611889",
                    TvcFacebook = "https://facebook.com/deveduvn"
                },
                new TvcAccount
                {
                    TvcId = 2,
                    TvcFullName = "Trần Thị B",
                    TvcEmail = "tranthib@example.com",
                    TvcPhone = "0987654321",
                    TvcAddress = "456 Đường B, Quận 3, TP.HCM",
                    TvcAvatar = "avatar2.jpg",
                    TvcBirthday = new DateTime(1992, 8, 15),
                    TvcGender = "Nữ",
                    TvcPassword = "password2",
                    TvcFacebook = "https://facebook.com/tranthib"
                },
                new TvcAccount
                {
                    TvcId = 3,
                    TvcFullName = "Lê Văn C",
                    TvcEmail = "levanc@example.com",
                    TvcPhone = "0911222333",
                    TvcAddress = "789 Đường C, Quận 5, TP.HCM",
                    TvcAvatar = "avatar3.jpg",
                    TvcBirthday = new DateTime(1988, 12, 1),
                    TvcGender = "Nam",
                    TvcPassword = "password3",
                    TvcFacebook = "https://facebook.com/levanc"
                },
                new TvcAccount
                {
                    TvcId = 4,
                    TvcFullName = "Phạm Thị D",
                    TvcEmail = "phamthid@example.com",
                    TvcPhone = "0909876543",
                    TvcAddress = "321 Đường D, Quận 7, TP.HCM",
                    TvcAvatar = "avatar4.jpg",
                    TvcBirthday = new DateTime(1995, 3, 10),
                    TvcGender = "Nữ",
                    TvcPassword = "password4",
                    TvcFacebook = "https://facebook.com/phamthid"
                },
                new TvcAccount
                {
                    TvcId = 5,
                    TvcFullName = "Hoàng Văn E",
                    TvcEmail = "hoangvane@example.com",
                    TvcPhone = "0933444555",
                    TvcAddress = "654 Đường E, Quận 10, TP.HCM",
                    TvcAvatar = "avatar5.jpg",
                    TvcBirthday = new DateTime(1991, 7, 22),
                    TvcGender = "Nam",
                    TvcPassword = "password5",
                    TvcFacebook = "https://facebook.com/hoangvane"
                }
        };
        // GET: TvcAccountController
        public ActionResult TvcIndex()
        {
            return View(tvcListAccount);
        }

        // GET: TvcAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TvcAccountController/Create
        public ActionResult TvcCreate()
        {
            var tvcModel = new TvcAccount();
            return View(tvcModel);
        }

        // POST: TvcAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TvcAccount tvcModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Giả sử bạn có DbContext tên _context đã được Inject trong Controller
                    //_context.TvcAccounts.Add(tvcModel);
                    //_context.SaveChanges();
                    tvcListAccount.Add(tvcModel);
                    return RedirectToAction(nameof(Index));
                }

                // Nếu dữ liệu không hợp lệ, trả về View để người dùng sửa
                return View(tvcModel);
            }
            catch (Exception ex)
            {
                // Bạn có thể log lỗi ở đây nếu cần
                ModelState.AddModelError("", "Có lỗi xảy ra khi thêm mới: " + ex.Message);
                return View(tvcModel);
            }
        }

        // GET: TvcAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TvcAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: TvcAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TvcAccountController/Delete/5
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
