using System.Text.RegularExpressions;

namespace Quan_Ly_Sinh_Vien_Project.Test
{
	public class FrmDangKy
	{
		private string username, email, pass1, pass2;

		private BUS.Account busacc;
		private bool flag;

		public FrmDangKy(string username, string pass1, string pass2, string email)
		{
			busacc = new BUS.Account();

			this.username = username;
			this.pass1 = pass1;
			this.pass2 = pass2;
			this.email = email;
		}

		private bool checkValidationgmail(string gm)
		{
			return Regex.IsMatch(gm, @"^[a-zA-Z0-9_.]{3,25}@gmail.com(.vn|)$");
		}
		private bool checkValidationpass(string pa)
		{
			return Regex.IsMatch(pa, "^[a-zA-Z0-9]{6,24}$");
		}

		public string btnEx_Click()
		{
			return "Thoat chuong trinh.";
		}

		public bool btnDK_Click()
		{
			DTO.Account acc = new DTO.Account();

			if (email == "" || pass1 == "" || pass2 == "" || username == "")
			{
				return false;
			}
			else if (!checkValidationpass(pass1))
			{
				return false;
			}
			else if (pass1 != pass2)
			{
				return false;
			}
			else if (!checkValidationgmail(email))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
