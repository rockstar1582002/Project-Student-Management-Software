using System;
namespace Quan_Ly_Sinh_Vien_Project.Test
{
	public class frmMonHoc
	{
		private string maMH, tenMH, trangThai;
		private BUS.MonHoc busmh;

		public frmMonHoc(string maMH, string tenMH, string trangThai)
		{
			busmh = new BUS.MonHoc();

			this.maMH = maMH;
			this.tenMH = tenMH;
			this.trangThai = trangThai;
		}

		public bool btnAdd_Click()
		{
			if (maMH == "" || tenMH == "" || trangThai == "" || tenMH.Equals("Toán") || maMH.Equals("3"))
			{
				return false;
			}
			try
			{
				DTO.MonHoc mh = new DTO.MonHoc();
				mh.Mamh = int.Parse(maMH);
				mh.Tenmh = tenMH;
				mh.Status = trangThai;

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
				DTO.MonHoc mh = new DTO.MonHoc();
				mh.Mamh = int.Parse(maMH);
				mh.Tenmh = tenMH;
				mh.Status = trangThai;

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
                DTO.MonHoc mh = new DTO.MonHoc();
				mh.Mamh = int.Parse(maMH);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
