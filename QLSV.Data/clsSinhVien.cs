using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Data
{
    class clsSinhVien
    {
        private string _idSinhVien;
        private string _hoTen;
        private string _ngaySinh;
        private string _gioiTinh;
        private string _diaChi;
        private string _idLop;

        public string idSinhvien { get { return _idSinhVien; } set { _idSinhVien = value; } }
        public string hoTen { get { return _hoTen; } set { _hoTen = value; } }
        public string ngaySinh { get { return _ngaySinh; } set { _ngaySinh = value; } }
        public string diaChi { get { return _diaChi; } set { _diaChi = value; } }
        public string idLop { get { return _idLop; } set { _idLop = value; } }


    }
}
