using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using FirstWebMVC.Data;
using FirstWebMVC.Models;
using FirstWebMVC.Models.Process;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstWebMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbcontext _context;
        private ExcelProcess _excelProcess = new ExcelProcess();
        public PersonController(ApplicationDbcontext context){
            _context = context;
        }
        public async Task<IActionResult> Index(int? page, int? PageSize){
            ViewBag.PageSize = new List<SelectListItem>()
            {
                new SelectListItem() {Value="3", Text="3"},
                new SelectListItem() {Value="5", Text="5"},
                new SelectListItem() {Value="10", Text="10"},
                new SelectListItem() {Value="15", Text="15"},
                new SelectListItem() {Value="25", Text="25"},
                new SelectListItem() {Value="50", Text="50"},
            };
            int pageSize = (PageSize ?? 3);
            ViewBag.psize = pageSize;
            var model =  _context.Person.ToList().ToPagedList(page ?? 1,pageSize);
            return View(model);
        }
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID, FullName, Address, PhoneNumber")] Person person){
            if(ModelState.IsValid){
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
        public async Task<IActionResult> Edit(string id){
            if(id == null || _context.Person == null){
                return NotFound();
            }
            var person = await _context.Person.FindAsync(id);
            if(person == null){
                return NotFound();
            }
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,[Bind("PersonID, FullName, Address, PhoneNumber")] Person person){
            if(id != person.PersonID){
                return NotFound();
            }
            if(ModelState.IsValid){
                try{
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException){
                    if(!PersonExists(person.PersonID)){
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(person);
        }
        public async Task<IActionResult> Delete(string id){
            if( id == null || _context.Person == null){
                return NotFound();
            }
            var person = await _context.Person.FirstOrDefaultAsync(m => m.PersonID == id);
            if(person == null){
                return NotFound();
            }
            return View(person);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id){
            if(_context.Person == null){
                return Problem("Entity set 'ApplicationDbcontext.Person' is null.");
            }
            var person = await _context.Person.FindAsync(id);
            if(person != null){
                _context.Person.Remove(person);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool PersonExists(string id){
            return (_context.Person?.Any(e => e.PersonID == id)).GetValueOrDefault();
        }
        public IActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file!=null)
                {
                    string fileExtension = Path.GetExtension(file.FileName);
                    if (fileExtension != ".xls" && fileExtension != ".xlsx")
                    {
                        ModelState.AddModelError("", "Please choose excel file to upload!");
                    }
                    else
                    {
                        //rename file when upload to server
                        var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", "File" + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Millisecond + fileExtension);
                        var fileLocation = new FileInfo(filePath).ToString();
                        if (file.Length > 0)
                        {
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                //save file to server
                                await file.CopyToAsync(stream);
                                //read data from file and write to database
                                var dt = _excelProcess.ExcelToDataTable(fileLocation);
                                for(int i = 0; i < dt.Rows.Count; i++)
                                {
                                    var ps = new Person();
                                    ps.PersonID = dt.Rows[i][0].ToString();
                                    ps.FullName = dt.Rows[i][1].ToString();
                                    ps.Address = dt.Rows[i][2].ToString();
                                    ps.PhoneNumber = dt.Rows[i][3].ToString();
                                    _context.Add(ps);
                                }
                                await _context.SaveChangesAsync();
                                return RedirectToAction(nameof(Index));
                            }
                        }
                    }
                }
            
            return View();
        }
    }

    internal class BlindAttribute : Attribute
    {
        private string v;

        public BlindAttribute(string v)
        {
            this.v = v;
        }
    }
}