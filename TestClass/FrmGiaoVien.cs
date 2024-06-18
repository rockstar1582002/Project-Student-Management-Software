using Quan_Ly_Sinh_Vien_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Quan_Ly_Sinh_Vien_Project.Test
{
	public class FrmGiaoVien
	{
		private Dictionary<string, string> monHoc = new Dictionary<string, string>
		{
			["1"] = "Vật Lý",
			["2"] = "Hóa Học",
			["6"] = "Công nghệ"
		};

		private string maGV, tenGV, maMH, tenMH, sdt, email, diaChi, chucVu;

		private BUS.GiaoVien busgv;

		public FrmGiaoVien(string maGV, string tenGV, string maMH, string tenMH, string sdt, string email, string diaChi, string chucVu)
		{
			busgv = new BUS.GiaoVien();

			this.maGV = maGV;
			this.tenGV = tenGV;
			this.maMH = maMH;
			this.tenMH = tenMH;
			this.sdt = sdt;
			this.email = email;
			this.diaChi = diaChi;
			this.chucVu = chucVu;
		}

		private bool checkValidationgmail(string gm)
		{
			return Regex.IsMatch(gm, @"^[a-zA-Z0-9_.]{3,25}@gmail.com(.vn|)$");
		}
		public bool btnADD_Click()
		{
			if (maGV == "" || tenGV == "" || tenMH == "" || diaChi == "" || email == ""
				|| sdt == "" || maMH == "" && chucVu == "" || maGV.Equals("5"))
			{
				return false;
			}
			else if (tenGV.Equals("!@#$%^&*()_-+={[}]|><./?") || sdt.Equals("!@#$%^&*()_-+={[}]|><./?") || diaChi.Equals("!@#$%^&*()_-+={[}]|><.?"))
			{
				return false;
			}
			else if (!checkValidationgmail(email))
			{
				return false;
			}
			else if (!monHoc[maMH].Equals(tenMH))
				return false;
			try
			{
				DTO.GiaoVien gv = new DTO.GiaoVien();
				gv.Magv = int.Parse(maGV);
				gv.Tengv = tenGV;
				gv.Mamh = int.Parse(maMH);
				gv.Tenmh = tenMH;
				gv.Email = email;
				gv.DienThoai = sdt;
				gv.DiaChi = diaChi;
				gv.Status = chucVu;

				return true;	   
			}
			catch (FormatException)
			{
				return false;
			}
		}

		public bool btnEdit_Click()
		{
			try
			{
				DTO.GiaoVien gv = new DTO.GiaoVien();
				gv.Magv = int.Parse(maGV);
				gv.Tengv = tenGV;
				gv.Mamh = int.Parse(maMH);
				gv.Tenmh = tenMH;
				gv.Email = email;
				gv.DienThoai = sdt;
				gv.DiaChi = diaChi;
				gv.Status = chucVu;

				return true;
			}
			catch (FormatException)
			{
				return false;
			}
		}

        public bool btnDelete_Click()
        {
            try
            {
                DTO.GiaoVien gv = new DTO.GiaoVien();
				gv.Magv = int.Parse(maGV);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool btnTimkiem_Click()
        {
            try
            {
                DTO.GiaoVien gv = new DTO.GiaoVien();
                gv.Magv = int.Parse(maGV);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
