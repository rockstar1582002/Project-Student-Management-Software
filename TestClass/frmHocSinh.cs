using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Quan_Ly_Sinh_Vien_Project.Test
{
	public class frmHocSinh
	{
		private string maHS, tenHS, diaChi, danToc, ngaySinh, maLop, tenLop, maKQ, tenDN;
		private bool gioiTinhNam, gioiTinhNu;

		private BUS.HocSinh bushocsinh;

		public frmHocSinh(string maHS, string tenHS, string diaChi, string danToc, string ngaySinh, string gioiTinh,
			string tenLop, string maKQ, string tenDN)
		{
			bushocsinh = new BUS.HocSinh();

			this.maHS = maHS;
			this.tenHS = tenHS;
			this.diaChi = diaChi;
			this.danToc = danToc;
			this.ngaySinh = ngaySinh;

			this.gioiTinhNam = gioiTinh.Equals("Nam");
			this.gioiTinhNu = gioiTinh.Equals("Nữ");

			this.tenLop = tenLop;
			this.maKQ = maKQ;
			this.tenDN = tenDN;
		}

		public frmHocSinh(string maHS, string tenHS, string diaChi, string danToc, string gioiTinh)
		{
			bushocsinh = new BUS.HocSinh();

			this.maHS = maHS;
			this.tenHS = tenHS;
			this.diaChi = diaChi;
			this.danToc = danToc;
			this.ngaySinh = "04/22/2002";

			this.gioiTinhNam = gioiTinh.Equals("Nam");
			this.gioiTinhNu = gioiTinh.Equals("Nữ");

			this.tenLop = "C1";
			this.maKQ = "KQ01";
			this.tenDN = "mike305";
		}

		public bool btnADD_Click()
		{
			if (maHS == "" || tenHS == "" || danToc == "" || diaChi == "" || ngaySinh == null || tenLop == ""
				|| danToc == "" || gioiTinhNam==false&&gioiTinhNu==false||maLop==""||maKQ==""||tenDN=="")
			{
				return false;
			}
			else if (tenHS.Equals("!@#$%^&*()_-+={[}]|><./?") || danToc.Equals("!@#$%^&*()_-+={[}]|><./?"))
			{
				return false;

			}
			else if(diaChi.Length<10||diaChi.Equals("!@#$%^&*()_+=-_"))
			{
				return false;
			}

			else if (!Regex.IsMatch(maHS, "^HS[0-9]{2,}$"))
				return false;

			try
			{
				DTO.HocSinh hs = new DTO.HocSinh();
				hs.IDHS = maHS;
				hs.TenHS = tenHS;
				hs.DiaChi = diaChi;
				hs.NgaySinh = DateTime.Parse(ngaySinh);

				hs.GioiTinh = gioiTinhNam ? "Nam" : "Nữ";
				hs.TenDanToc = danToc;
				hs.Tenlop = tenLop;
				hs.Makq = maKQ;
				hs.TenDN = tenDN;

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
				DTO.HocSinh hs = new DTO.HocSinh();
				hs.IDHS = maHS;
				hs.TenHS = tenHS;
				hs.DiaChi = diaChi;
				hs.NgaySinh = DateTime.Parse(ngaySinh);

				hs.GioiTinh = gioiTinhNam ? "Nam" : "Nữ";
				hs.TenDanToc = danToc;
				hs.Malop = int.Parse(maLop);
				hs.Tenlop = tenLop;
				hs.Makq = maKQ;
				hs.TenDN = tenDN;

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
                DTO.HocSinh hs = new DTO.HocSinh();
                hs.IDHS = maHS;
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
                DTO.HocSinh hs = new DTO.HocSinh();
                hs.IDHS = maHS;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }
}
