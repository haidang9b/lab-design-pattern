using Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai2.DAO
{
    public class VnExpressService
    {
        public VECat[] retrieveCats()
        {
            var rs = new VECat[] { new VECat { catID = 1, title = "Góc nhìn", content = "Nội dung góc nhìn" }, 
                                  new VECat{catID = 2, title = "Kinh doanh", content = "Nội dung Kinh doanh"},
                                  new VECat{catID = 3, title = "Giáo dục", content = "Nội dung Giáo dục" }
            };
            return rs;
        }

        public VENews[] retrieveNews(int cate)
        {
            var db = new Dictionary<int, VENews[]>
            {
                {1, new VENews[]{ new VENews{id = 1, headline="Tính Việt", content = "Tại một cuộc gặp mặt nhỏ ở Paris, nhà văn Nguyễn Thanh Việt kể lại câu chuyện làm ông cảm động. Tình cờ trong cửa hàng tại Mỹ, ông nghe một người gốc Á nói chuyện điện thoại với con khi đang mua sắm. Nhà văn biết ông ta là người Việt khi nghe câu hỏiNhững lời đó, nói bằng tiếng Anh, không có gì đáng kể, thậm chí còn hơi phiền. Nhưng Nguyễn Thanh Việt nói rằng:" } ,
                                    new VENews{ id = 2, headline= "Tôi đi cách ly", content = "Nhờ những ngày cách ly, tôi phát hiện một người quan tâm tới tôi gấp đôi vợ tôi. Người này ngày nào cũng gọi video hỏi xem hôm nay tôi thấy trong người thế nào, có đau họng, ho hay sốt gì không, thân nhiệt cao hay thấp, rồi còn bắt lia camera quanh phòng xem tôi ở một mình hay cùng ai. Đó là nhân viên của MOM - Bộ Nhân lực Singapore, gọi video qua Whatsapp hàng ngày để theo dõi sức khoẻ và giám sát việc tuân thủ cách ly. Chuyến bay đầu tiên của tôi sau mùa dịch là từ Hà Nội sang Singapore. Cả chuyến bay chỉ khoảng 50 người. Trước khi bay, Cơ quan Quản lý xuất nhập cảnh Singapore (ICA) yêu cầu hành khách phải có xét nghiệm PCR âm tính trong 48 giờ; giấy chứng nhận tiêm đủ hai mũi vaccine thuộc danh sách của WHO tối thiểu 14 ngày."} }},
                {2, new VENews[]{new VENews { id = 3, content = "Gặp Thủ tướng Phạm Minh Chính tại Tokyo, Chủ tịch Tập đoàn Hitachi chia sẻ đang đặc biệt mong muốn đầu tư đường sắt ở Việt Nam. Sáng 24/11, trong khuôn khổ chuyến thăm chính thức Nhật Bản, Thủ tướng Phạm Minh Chính đã tiếp lãnh đạo nhiều tập đoàn kinh tế, trường đại học đang và có ý định đầu tư vào Việt Nam trên nhiều lĩnh vực như giao thông, bất động sản, năng lượng, y tế, giáo dục...", headline="Hitachi ngỏ ý xây đường sắt ở Việt Nam"} ,
                new VENews { id = 4, content = "TP HCMMỗi quả bưởi đỏ vẽ họa tiết thư pháp cho Tết Nguyên đán năm nay sẽ có giá hơn một triệu đồng, tăng 20% so với năm ngoáiÔng Nguyễn Tiến Hải, chủ vựa thu mua và canh tác bưởi đỏ ở Thanh Hóa cho biết, năm nay sẽ bán ra thị trường vài chục nghìn quả bưởi đỏ, trong đó, khoảng 15.000 quả được vận chuyển vào Nam.Theo tính toán của ông Hải, nếu cộng các loại chi phí, giá bán lẻ một quả bưởi loại 1 nặng trên 2 kg có vẽ thư pháp tại TP HCM sẽ lên đến 1-1,2 triệu đồng, tăng 20% so với năm ngoái.", headline="Hơn triệu đồng một quả bưởi đỏ vẽ thư pháp"}
                } },
                {3, new VENews[]{ new VENews { id=5, headline="'Khẩu hiệu Tiên học lễ không cản trở tư duy phản biện'", content="GS Trần Ngọc Thêm đề nghị chấm dứt dùng khẩu hiệu Tiên học lễ hậu học văn để thúc đẩy tư duy phản biện, tuy nhiên, thạc sĩ Phan Thế Hoài đưa ra góc nhìn khác. Thạc sĩ Phan Thế Hoài là giáo viên dạy Ngữ văn tại TP HCM. Dưới đây là bài viết của ông trước đề xuất đang gây tranh luận của GS Trần Ngọc Thêm. Ngày 21/11, Ủy ban Văn hóa, Giáo dục của Quốc hội tổ chức hội thảo giáo dục với chủ đ Văn hóa học đường trong bối cảnh đổi mới giáo dục và đào tạo. Trong tham luận phát biểu tại hội thảo, GS Trần Ngọc Thêm - Trường Đại học Khoa học xã hội và Nhân văn - Đại học Quốc gia TP HCM - nêu quan điểm: Xã hội muốn phát triển thì điều quan trọng là cần phải có con người sáng tạo, mà để có con người sáng tạo thì trước hết phải có con người chủ động."},
                new VENews { id=6, headline="", content=""}
                } }
            };
            
            return db[cate];
        }
    }
}