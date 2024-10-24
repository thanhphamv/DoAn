using DoAn.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    public class SinhVienService
    {
        public List<SinhVien> GetAll()
        {
            Model1 context = new Model1();
            return context.SinhViens.ToList();
        }

        public SinhVien TimSinhVienTheoID(int sinhVienID)
        {
            Model1 context = new Model1();
            var student = context.SinhViens.Find(sinhVienID);
            if (student == null)
            {
                throw new Exception("Student not found");
            }
            return student;
        }

        public void ThemSinhVien(SinhVien sinhVien)
        {
            Model1 context = new Model1();
            context.SinhViens.AddOrUpdate(sinhVien); // AddOrUpdate yêu cầu Entity Framework Extensions
            context.SaveChanges();
        }

        public void XoaSinhVien(int sinhVienID)
        {
            Model1 context = new Model1();
            var sinhVien = context.SinhViens.FirstOrDefault(p => p.MaSinhVien == sinhVienID);
            if (sinhVien != null)
            {
                context.SinhViens.Remove(sinhVien);
                context.SaveChanges();
            }
        }
        // Hàm sửa sinh viên
        public void SuaSinhVien(SinhVien updatedStudent)
        {
            Model1 context = new Model1();
            // Kiểm tra xem sinh viên có tồn tại hay không
            var existingStudent = context.SinhViens.Find(updatedStudent.MaSinhVien);
            if (existingStudent == null)
            {
                throw new Exception("Student not found");
            }

            // Cập nhật thông tin sinh viên
            existingStudent.TenSV = updatedStudent.TenSV;
            existingStudent.NgaySinh = updatedStudent.NgaySinh;
            existingStudent.GioiTinh = updatedStudent.GioiTinh;
            existingStudent.DiaChi = updatedStudent.DiaChi;
            existingStudent.Email = updatedStudent.Email;

            // Lưu thay đổi vào cơ sở dữ liệu
            context.SaveChanges();
        }
    }
}

