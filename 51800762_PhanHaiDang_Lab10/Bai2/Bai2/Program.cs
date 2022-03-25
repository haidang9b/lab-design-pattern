using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Xe kia_sorento = new XeMacDinh { ChoNgoi =7, DoiXe=2020,DongXe="Sorento",KmBaoHanh=20000,DungTich=2.0, GiaTien=1100, HieuXe="Kia", MauXe="Đen", NamBH=2021 };
            DoChoiXe go_pro_hero_6 = new CameraHanhTrinh(kia_sorento, "Go Pro", "Mo ta go pro hero 6", "Camera GoPro Hero 6", 13, "Bao Hanh 5 Nam");

            Console.WriteLine("Gia Ban Kia Sorento + Gopro Hero 6 : " + go_pro_hero_6.TinhTien());
            DoChoiXe cua_hit = new CuaTuDong(go_pro_hero_6, "Cua hit Trung Hoa", "Mo ta Cua hit Trung Hoa", "Cua hit Trung Hoa sieu cap vip", 20, "Bao Hanh 3 Nam");
            Console.WriteLine("Gia Ban Kia Sorento + Gopro Hero 6 + Cua Hit Trung Hoa : " + cua_hit.TinhTien());

            DoChoiXe kinh_chinh_dien = new KinhChinhDien(cua_hit, "Kinh Chinh dien ABC XYZ", "Mo ta Kinh Chinh dien ABC XYZ", "Kinh Chinh dien ABC XYZ sieu cap vip", 5, "Bao Hanh 3 Nam");
            Console.WriteLine("Gia Ban Kia Sorento + Gopro Hero 6 + Cua Hit Trung Hoa + Kinh Chinh dien ABC XYZ : " + kinh_chinh_dien.TinhTien());

            DoChoiXe camera_lui = new CameraLui(kinh_chinh_dien, "Camera Lui Trung Quoc Sieu net", "Mo ta Camera Lui Trung Quoc Sieu net", "Camera Lui Trung Quoc Sieu net sieu cap vip", 10, "Bao Hanh 5 Nam");
            
            Console.WriteLine("Gia Ban Kia Sorento + Gopro Hero 6 + Cua Hit Trung Hoa + Kinh Chinh dien ABC XYZ + Camera Lui Trung Quoc Sieu net : " + camera_lui.TinhTien());

            Console.ReadLine();
        }
    }
}
