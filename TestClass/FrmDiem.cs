using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Quan_Ly_Sinh_Vien_Project.Test
{
	public class FrmDiem
	{
		private Dictionary<string, string> monHoc = new Dictionary<string, string>
		{
			["1"] = "Vật Lý",
			["2"] = "Hóa Học"
		};

		private string maKQ, maMH, tenMH, diem15p, diem45p, diemHK, hocKy;

		BUS.Diem busdiem;

		public FrmDiem(string maKQ, string maMH, string tenMH, string diem15p, string diem45p, string diemHK, string hocKy)
		{
			busdiem = new BUS.Diem();

			this.maKQ = maKQ;
			this.maMH = maMH;
			this.tenMH = tenMH;
			this.diem15p = diem15p;
			this.diem45p = diem45p;
			this.diemHK = diemHK;
			this.hocKy = hocKy;
		}

		public bool btnADD_Click()
		{
			if (maKQ == "" || maMH == "" || tenMH == "" || diem15p == "" || diem45p == "" || diemHK == "" || maKQ.Equals("KQ06"))
			{
				return false;
			}

			else if (!Regex.IsMatch(maKQ, "^KQ[0-9]{2,}$"))
				return false;

			else if (!monHoc[maMH].Equals(tenMH))
				return false;
			
			try
			{
				DTO.Diem diem = new DTO.Diem();


				diem.Makq = maKQ;
				diem.Mamh = int.Parse(maMH);
				diem.Tenmh = tenMH;

				float a = diem.diemkt15p = float.Parse(diem15p);
				float b = diem.diemkt45p = float.Parse(diem45p);
				float c = diem.diemhk = float.Parse(diemHK);

				diem.diemtb = ((a * 1 + b * 2 + c * 3) / 6);

				diem.Hocky = hocKy;

				return true;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		public bool btnEdit_Click()
		{
			DTO.Diem diem = new DTO.Diem();
			diem.Makq = maKQ;
			diem.Mamh = int.Parse(maMH);
			diem.Tenmh = tenMH;
		
			diem.diemkt15p = float.Parse(diem15p);
			diem.diemkt45p = float.Parse(diem45p);
			diem.diemhk = float.Parse(diemHK);
			diem.Hocky = hocKy;

			return true;
		}

        public bool btnDelete_Click()
        {
            try
            {
                DTO.Diem kq = new DTO.Diem();
                kq.Makq = maKQ;
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
                DTO.Diem kq = new DTO.Diem();
                kq.Makq = maKQ;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
