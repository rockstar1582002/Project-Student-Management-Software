using NUnit.Framework;
using Quan_Ly_Sinh_Vien_Project.DTO;

namespace Quan_Ly_Sinh_Vien_Project.Test
{
	public class FrmDangNhap
	{
		private string username, password;

		private Account ac = new Account();
		private BUS.Account tkbus = new BUS.Account();

		public FrmDangNhap(string username, string password)
		{
			this.username = username;
			this.password = password;
		}

		public string btnEx_Click()
		{
			return "Thoat chuong trinh.";
		}

		public bool btnLogin_Click()
		{
			ac.Username = username;
			ac.Pass = password;

			string laytaikhoan = tkbus.CheckLogin(ac);
			switch (laytaikhoan)
			{
				case "Ten Tai Khoan Bi trong":
					return false;

				case "Mat Khau Bi Trong":
					return false;

				case "Tai Khoan Hoac Mat Khau Khong Dung":
					return false;

				default:
					return true;
			}
		}
	}
}
