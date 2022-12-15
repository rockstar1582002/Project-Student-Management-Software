using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sinh_Vien_Project.DTO
{
    class GiaoVien
    {
    /*[Magv] [int] primary key  NOT NULL,
	[Tengv] [nvarchar] (50) NULL,
	[Ten] [nvarchar] (50) NULL,
	[Dienthoai] [nvarchar] (50) NULL,
	[Email] [nchar] (20) NULL,
	[Diachi] [nvarchar] (250) NULL,
	[Status] [nvarchar] (3) NULL,
	*/
	public int    Magv { get; set; }
	public string Tengv { get; set; }
	public int    Mamh { get; set; }
	public string Tenmh { get; set; }
	public string DienThoai { get; set; }
	public string Email { get; set; }
	public string DiaChi { get; set; }
	public string Status { get; set; }
    }
}
