using exercise1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace exercise1.Factory
{
    public class SinhVienService
    {
        private DatabaseFactory factory { get; }
        public SinhVienService(DatabaseFactory factory)
        {
            this.factory = factory;
        }

        private string returnConnectString()
        {
            if(LoadData.typeData == 1)
            {
                return LoadData.connecstring1;
            }
            return LoadData.connecstring2;
        }
        public List<Student> getList()
        {
            var connStr = returnConnectString();
            var conn = factory.CreateConnection(connStr);
            conn.Open();
            var cmd = factory.CreateCommand("Select * from sinhvien", conn);
            var adapter = factory.CreateDataAdapter(cmd);
            var tbsv = new DataTable();
            var kq = new List<Student>();

            adapter.Fill(tbsv);

            foreach(DataRow row in tbsv.Rows)
            {
                var sv = new Student
                {
                    MSSV = (int)row["MSSV"],
                    HoTen = row["HoTen"].ToString(),
                    NgaySinh = row["NgaySinh"].ToString(),
                    Lop = row["Lop"].ToString()

                };
                kq.Add(sv);
            }
            conn.Close();
            return kq;
        }

        public bool Add(Student student)
        {
            var connStr = returnConnectString();
            var conn = factory.CreateConnection(connStr);
            conn.Open();
            var cmd = factory.CreateCommand("INSERT INTO sinhvien  (HoTen,NgaySinh,Lop)  VALUES (@HoTen ,@NgaySinh,@Lop)", conn);
            var paramNgaySinh = factory.CreateParameter("@NgaySinh", student.NgaySinh);
            var paramLop = factory.CreateParameter("@Lop", student.Lop);
            var paramHoTen = factory.CreateParameter("@HoTen", student.HoTen);
            cmd.Parameters.Add(paramHoTen);
            cmd.Parameters.Add(paramNgaySinh);
            cmd.Parameters.Add(paramLop);
            
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(int id, Student student)
        {

            var connStr = returnConnectString();
            var conn = factory.CreateConnection(connStr);
            conn.Open();
            var cmd = factory.CreateCommand("UPDATE SINHVIEN SET HoTen =@HoTen ,NgaySinh = @NgaySinh,Lop = @Lop WHERE MSSV=@MSSV", conn);
            var paramMSSV = factory.CreateParameter("@MSSV", id);
            var paramNgaySinh = factory.CreateParameter("@NgaySinh", student.NgaySinh);
            var paramLop = factory.CreateParameter("@Lop", student.Lop);
            var paramHoTen = factory.CreateParameter("@HoTen", student.HoTen);
            cmd.Parameters.Add(paramHoTen);
            cmd.Parameters.Add(paramNgaySinh);
            cmd.Parameters.Add(paramLop);
            cmd.Parameters.Add(paramMSSV);
            return cmd.ExecuteNonQuery() > 0;
        }

        public Student getByID(int id)
        {
            var connStr = returnConnectString();
            var conn = factory.CreateConnection(connStr);
            conn.Open();

            var cmd = factory.CreateCommand("Select * from sinhvien WHERE MSSV=@MSSV");
            var param = factory.CreateParameter("@MSSV", id);
            cmd.Parameters.Add(param);
            cmd.Connection = conn;
            var reader = factory.CreateDataReader(cmd);
            reader.Read();
            if (reader.HasRows)
            {
                var ordMSSV = reader.GetOrdinal("MSSV");
                var ordHoTen = reader.GetOrdinal("HoTen");
                var ordNgaySinh = reader.GetOrdinal("NgaySinh");
                var ordLop = reader.GetOrdinal("Lop");

                return new Student { MSSV = reader.GetInt32(ordMSSV), HoTen = reader.GetString(ordHoTen), NgaySinh = reader.GetString(ordNgaySinh), Lop = reader.GetString(ordLop) };
            }
            return null;
            
        }

        public bool Delete(int Id)
        {
            var connStr = returnConnectString();
            var conn = factory.CreateConnection(connStr);
            conn.Open();
            var cmd = factory.CreateCommand("DELETE FROM sinhvien WHERE MSSV=@MSSV", conn);
            var param = factory.CreateParameter("@MSSV", Id);
            cmd.Parameters.Add(param);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}