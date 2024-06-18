using System;

namespace Quan_Ly_Sinh_Vien_Project.Test
{
	public class frmLop
	{
		private string maLop, tenLop, ghiChu, maGV, tenGV;

		private BUS.Lop buslop;

		public frmLop(string maLop, string tenLop, string ghiChu, string maGV)
		{
			buslop = new BUS.Lop();

			this.maLop = maLop;
			this.tenLop = tenLop;
			this.ghiChu = ghiChu;
			this.maGV = maGV;
		}

		public bool btnAdd_Click()
		{
			if (maLop == "" || tenLop == "" || ghiChu == "" ||tenGV == "" || maGV == "" || maLop.Equals("7"))
			{
				return false;
			}
			try
			{
				DTO.Lop lp = new DTO.Lop();
				lp.Malop = int.Parse(maLop);
				lp.Tenlop = tenLop;
				lp.ghichu = ghiChu;
				lp.Magv = int.Parse(maGV);
				lp.Tengvcn = tenGV;

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
				DTO.Lop lp = new DTO.Lop();
				lp.Malop = int.Parse(maLop);
				lp.Tenlop = tenLop;
				lp.ghichu = ghiChu;
				lp.Magv = int.Parse(maGV);
				lp.Tengvcn = tenGV;
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
                DTO.Lop lop = new DTO.Lop();
				lop.Malop = int.Parse(maLop);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
