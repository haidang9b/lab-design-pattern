using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public abstract class Xe
    {
        public string HieuXe { get; set; }
        public string DongXe { get; set; }
        public int DoiXe { get; set; }
        public string MauXe { get; set; }
        public int ChoNgoi { get; set; }
        public int NamBH { get; set; }
        public int KmBaoHanh { get; set; }
        public double DungTich { get; set; }
        public int GiaTien { get; set; }

        public abstract int TinhTien();

    }

    public class XeMacDinh : Xe
    {
        public override int TinhTien()
        {
            return GiaTien;
        }
    }

    public abstract class DoChoiXe : Xe
    {
        protected Xe xeObj { get; set; }
        protected string HangSX { get; set; }
        protected string MoTa { get; set; }
        protected string LoaiHang { get; set; }
        protected int GiaBan { get; set; }
        protected string ThongTinBH { get; set; }

        public DoChoiXe(Xe xeObj, string HangSX, string MoTa, string LoaiHang, int GiaBan, string ThongTinBH)
        {
            this.xeObj = xeObj;
            this.HangSX = HangSX;
            this.MoTa = MoTa;
            this.LoaiHang = LoaiHang;
            this.GiaBan = GiaBan;
            this.ThongTinBH = ThongTinBH;
        }

    }

    public class CameraHanhTrinh : DoChoiXe
    {
        public CameraHanhTrinh(Xe xeObj, string HangSX, string MoTa, string LoaiHang, int GiaBan, string ThongTinBH)
            : base(xeObj,  HangSX,  MoTa,  LoaiHang,  GiaBan, ThongTinBH)
        {

        }
        public override int TinhTien()
        {
            return xeObj.TinhTien() + GiaBan;
        }
    }

    public class CuaTuDong : DoChoiXe
    {
        public CuaTuDong(Xe xeObj, string HangSX, string MoTa, string LoaiHang, int GiaBan, string ThongTinBH)
            : base(xeObj, HangSX, MoTa, LoaiHang, GiaBan, ThongTinBH)
        {

        }
        public override int TinhTien()
        {
            return xeObj.TinhTien() + GiaBan;
        }
    }

    public class CameraLui : DoChoiXe
    {
        public CameraLui(Xe xeObj, string HangSX, string MoTa, string LoaiHang, int GiaBan, string ThongTinBH)
            : base(xeObj, HangSX, MoTa, LoaiHang, GiaBan, ThongTinBH)
        {

        }
        public override int TinhTien()
        {
            return xeObj.TinhTien() + GiaBan;
        }
    }

    public class KinhChinhDien : DoChoiXe
    {
        public KinhChinhDien(Xe xeObj, string HangSX, string MoTa, string LoaiHang, int GiaBan, string ThongTinBH)
            : base(xeObj, HangSX, MoTa, LoaiHang, GiaBan, ThongTinBH)
        {

        }
        public override int TinhTien()
        {
            return xeObj.TinhTien() + GiaBan;
        }
    }
}
