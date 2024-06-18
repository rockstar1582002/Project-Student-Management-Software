using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Quan_Ly_Sinh_Vien_Project.Test
{ 
	public class FrmHocPhi
	{
		private Dictionary<string, string> hocSinh = new Dictionary<string, string>
		{
			["HS01"] = "Nông A Xuyến",
			["HS05"] = "Trần Bá Chung",
			["HS07"] = "Lâm Thanh Nhàn"
		};

		private string maHP, maHS, tenHS, maLop, soTiet, tienHoc, tongTien;

		public FrmHocPhi(string maHP, string maHS, string tenHS, string maLop, string soTiet, string tienHoc)
		{
			this.maHP = maHP;
			this.maHS = maHS;
			this.tenHS = tenHS;
			this.maLop = maLop;
			this.soTiet = soTiet;
			this.tienHoc = tienHoc;
			this.tongTien = "";
		}

		public FrmHocPhi(string maHP, string maHS, string tenHS, string maLop, string soTiet, string tienHoc, string tongTien)
		{
			this.maHP = maHP;
			this.maHS = maHS;
			this.tenHS = tenHS;
			this.maLop = maLop;
			this.soTiet = soTiet;
			this.tienHoc = tienHoc;
			this.tongTien = tongTien;
		}

		public bool btnAdd_Click()
		{
			if (maHP == "" || soTiet == "" || tienHoc == ""
				|| maLop == "" || maHS == "" || tenHS == "" || !maHP.Equals("HP01"))
			{
				return false;
			}

			else if (!Regex.IsMatch(maHP, "^HP[0-9]{2,}$"))
				return false;

			else if (!hocSinh[maHS].Equals(tenHS))
				return false;

			try
			{
				DTO.HocPhi lp = new DTO.HocPhi();

				lp.MaHP = maHP;
				lp.IDHS = maHS;
				lp.TenHS = tenHS;
				lp.Malop = int.Parse(maLop);

				float sotiet = lp.Sotiet = int.Parse(soTiet);
				float TienHoc = lp.TienHoc = float.Parse(tienHoc);

				if (sotiet < 0f)
					return false;

				if (!tongTien.Equals("") && float.Parse(tongTien) != Math.Round(sotiet * TienHoc))
					return false;

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
				DTO.HocPhi lp = new DTO.HocPhi();
				lp.MaHP = maHP;
				lp.IDHS = maHS;
				lp.TenHS = tenHS;
				lp.Malop = int.Parse(maLop);
				float sotiet = lp.Sotiet = int.Parse(soTiet);
				float TienHoc = lp.TienHoc = float.Parse(tienHoc);
				lp.TongTien = (sotiet * TienHoc);

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
                DTO.HocPhi hp = new DTO.HocPhi();
				hp.MaHP = maHP;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
