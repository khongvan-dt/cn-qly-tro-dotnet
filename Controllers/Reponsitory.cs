using quanLyTro.Models;
using Microsoft.AspNetCore.Mvc;
using IRepository.Controllers;
using quanLyTro.Data;

namespace quanLyTro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Repository<T> : ControllerBase, IRepository<T> where T : class
    {
        DataContext dc;
        public Repository(DataContext dc2)
        {
            dc = dc2;
        }
        [HttpGet]
        public IEnumerable<T> Index()
        {
            return dc.Set<T>().ToList();
        }
        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return dc.Set<T>().Find(id);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = dc.Set<T>().Find(id);
            dc.Set<T>().Remove(item);
            var save = dc.SaveChanges();
            if (save > 0)
            {
                return Ok("Xóa Dữ Liệu Thành Công");
            }
            return NotFound("Xóa Thất bại");
        }
        [HttpPost]
        // public IActionResult Create( [FromBody]T[] value)
        // //chuyền 1 mảng có FromBody
        // {
        //     Console.WriteLine(value);
        //     dc.Set<T>().AddRange(value);

        //     var save = dc.SaveChanges();
        //     if (save > 0)
        //     {
        //         return Ok("Thêm Dữ Liệu Thành Công");
        //     }
        //     return NotFound("Thêm Thất bại");
        // }
        public IActionResult Create(T value)
        {
            // Lặp qua tất cả các thuộc tính của value
            foreach (var prop in typeof(T).GetProperties())
            {
                // Kiểm tra nếu thuộc tính là kiểu DateTime và giá trị của nó là mặc định (null)
                if (prop.PropertyType == typeof(DateTime?) && prop.GetValue(value) == null)
                {
                    // Set giá trị cho thuộc tính là thời gian hiện tại
                    prop.SetValue(value, DateTime.Now);
                }
            }

            dc.Set<T>().AddRange(value);

            var save = dc.SaveChanges();
            if (save > 0)
            {
                return Ok("Thêm Dữ Liệu Thành Công");
            }
            return NotFound("Thêm Thất bại");
        }
        [HttpPut]
        public IActionResult Update(T value)
        {
            dc.Set<T>().Update(value);
            var save = dc.SaveChanges();
            if (save > 0)
            {
                return Ok("Cập Nhật Dữ Liệu Thành Công");
            }
            return NotFound("Cập Nhật Thất bại");
        }
    }
}
