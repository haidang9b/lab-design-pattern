using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2.DAO
{
    public class ThanhNienService
    {
        public List<TNCat> getCategories()
        {
            return new List<TNCat>
            {
                new TNCat {id = 1, title =  "Thời sự"},
                new TNCat {id = 2, title = "Dân sinh"},
                new TNCat {id = 3, title= "Phóng sự điều tra"}
            };
        }

        public List<TNNews> getNewsList(int idCate)
        {

            var db = new Dictionary<int, List<TNNews>>
            {
                {1, new List<TNNews>
                {
                    new TNNews{ id = 1, title = "Cựu cán bộ công an có vai trò gì trong vụ cướp tiền ảo trên cao tốc?", content = "Hai bị can cựu cán bộ Công an TP.HCM có tham gia vụ dàn cảnh tông xe, cướp tiền ảo trên cao tốc TP.HCM - Dầu Giây, ban đầu thừa nhận hành vi nhưng sau đó kêu oan, cho rằng không liên quan vụ cướp tài sản.Liên quan vụ dàn cảnh tông xe, cướp 37 tỉ đồng tiền ảo trên cao tốc TP.HCM - Dầu Giây, có 2 cựu cán bộ Công an TP.HCM bị truy tố về tội cướp tài sản. Đáng chú ý, hai bị can đều kêu oan, cho rằng không biết và không liên quan đến vụ cướp này."},
                    new TNNews {id = 2 , title = "Chủ tịch phường lên Facebook kêu gọi 'giải cứu' cá", content ="Vẫn còn nhiều hộ nuôi cá lồng bè ở vịnh Mân Quang (Q.Sơn Trà, TP.Đà Nẵng) chưa kịp tháo dỡ do tồn đọng hơn 6 tấn cá không thể bán được, một Chủ tịch UBND phường lên Facebook rao bán cá"},
                } },

                {2, new List<TNNews>
                {
                    new TNNews{id=3, title="Sở Y tế TP.HCM trình 6 chiến lược lớn để kiểm soát dịch bệnh Covid-19", content = "Ngày 24.11, Sở Y tế TP.HCM cho biết vừa có tờ trình UBND TP.HCM về việc phê duyệt Chiến lược y tế trong giai đoạn thích ứng an toàn, linh hoạt, kiểm soát hiệu quả dịch Covid-19 trên địa bàn TP.HCM. Theo tờ trình, Sở Y tế TP.HCM đề xuất triển khai thực hiện 6 chiến lược lớn để kiểm soát dịch Covid-19."},
                    new TNNews{id=4, title = "Hậu Giang phòng dịch Covid-19: Người đi chợ phải được tiêm đủ 2 mũi vắc xin", content="Theo UBND tỉnh Hậu Giang, tình hình dịch bệnh tại các địa phương trong tỉnh đang diễn biến phức tạp. Nhằm tăng cường biện pháp ngăn chặn sự lây lan, thích ứng an toàn, linh hoạt, kiểm soát hiệu quả dịch Covid-19, Chủ tịch UBND tỉnh Hậu Giang quy định đối với việc tổ chức đám tang, hiếu, hỷ phải đảm bảo an toàn phòng, chống dịch bệnh, hạn chế tập trung đông người (không quá 20 người tại một thời điểm); chính quyền địa phương tăng cường tuyên truyền vận động người dân tổ chức theo hình thức đơn giản, không triển khai ăn uống và thực hiện đúng quy định về số người hiện diện. Những hoạt động tập trung thể dục, thể thao ngoài trời được thực hiện nhưng phải tuân thủ tiêu chí người tham gia đã tiêm đủ 2 liều vắc xin, thực hiện quy định 5K, đảm bảo các quy định an toàn phòng, chống dịch và không tập trung quá 10 người trong cùng một thời điểm, địa điểm. Đối với các xã, phường, thị trấn, ấp, khu vực có dịch Covid-19 cấp độ 3 trở lên thì thực hiện việc phát phiếu đi chợ cho người dân không quá 15 lần/tháng, quy định giờ đi chợ hợp lý, đảm bảo giãn cách 2 m, không tập trung đông người, người đi chợ phải được tiêm đủ 2 mũi vắc xin ngừa Covid-19."}
                } },
                {3, new List<TNNews>
                {
                    new TNNews{id=5, title="Nghề Việt - Nét Việt: Gốm việt chuyện ngàn năm", content="Trong suốt hàng ngàn năm lịch sử của đất Việt, nghề tồn tại lâu đời và tiếp biến liên tục nhất chính là gốm. Mỗi thời kỳ, gốm Việt xuất hiện với diện mạo, bản sắc, cốt cách rất riêng, rất rõ, nhưng... Trải dọc chiều dài đất nước, từ cổ kim vùng miền nào cũng có nghề gốm, lò gốm. Từ những dòng gốm kinh kỳ phục vụ hoàng triều như Thiên Trường (Nam Định), Thăng Long (Hà Nội), cho đến các làng nghề gốm Bát Tràng, Phù Lãng, Hương Canh, Chu Đậu, Thổ Hà… đến miền Trung có Phước Tích (Huế), Châu Ổ (Quảng Ngãi), Gò Sành (Bình Định), Quảng Đức (Phú Yên), Bàu Trúc (Ninh Thuận)… và gốm miền Nam với Cây Mai, Sài Gòn, Biên Hòa, Lái Thiêu…; mỗi địa danh về gốm là một nét tiêu biểu về tạo hình, men thuốc trên cốt gốm, định hình sự đa dạng, phong phú trên bản đồ phát triển gốm Việt. Nhưng qua ngàn năm, gốm Việt từng nhiều thời rực rỡ, giờ lại đang loay hoay trong ao làng."},
                    new TNNews{id = 6, title="Dựng 'nhà' cho chim", content="“Con chim quý, phải ở lầu son” (nhạc sĩ Nhật Ngân)… Muốn biết “lầu” cho chim có giá trị “son” đến cỡ nào, hành trình tìm về các làng nghề lồng chim sẽ là cơ hội gặp gỡ những nhân vật tạo ra giá trị phi phàm cho “lầu son” nuôi chim quý ấy. Vài trăm triệu, một tỉ, đôi ba tỉ… là những câu chuyện truyền miệng của giới chơi chim khi bàn đến chuyên môn đầy tốn kém, đó là lồng chim. Tính trong nghề lồng chim ở phạm vi cả châu Á, thợ nghề Việt Nam được giới chơi kính nể bởi có thể tạo tác những tuyệt phẩm giá trị tiền tỉ, mà ở đó có thể thấy rõ phong cách nghệ thuật chạm trổ của vùng miền, của nét văn hóa truyền thống, của những tích truyện, điển cố mà nay phần nhiều đã bị lãng quên. Giá trị trang trí ấy khiến cho chiếc lồng chim vượt khỏi công năng ban đầu là phục vụ thú chơi chim, trở thành tác phẩm nghệ thuật đặc biệt."}
                } }

            };
            return db[idCate];
        }
    }
}