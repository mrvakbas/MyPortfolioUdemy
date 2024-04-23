using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.todoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            var value = context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(value);
        }
    }
}
