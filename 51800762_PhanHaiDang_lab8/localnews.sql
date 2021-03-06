USE [51800762_Lab8DesignPattern]
GO
SET IDENTITY_INSERT [dbo].[NewsCategory] ON 

INSERT [dbo].[NewsCategory] ([categoryId], [categoryName]) VALUES (1, N'Thế giới')
INSERT [dbo].[NewsCategory] ([categoryId], [categoryName]) VALUES (2, N'Thể thao')
INSERT [dbo].[NewsCategory] ([categoryId], [categoryName]) VALUES (3, N'Pháp luật')
INSERT [dbo].[NewsCategory] ([categoryId], [categoryName]) VALUES (4, N'Khoa học')
INSERT [dbo].[NewsCategory] ([categoryId], [categoryName]) VALUES (5, N'Giải trí')
SET IDENTITY_INSERT [dbo].[NewsCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[NewsLocal] ON 

INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (1, N'Bản thảo của Albert Einstein giá 13 triệu USD
', N'Bản thảo hiếm của Albert Einstein, nhà khoa học từng đoạt giải Nobel, được bán đấu giá ở Paris với tổng giá trị lên tới 13 triệu USD.

Bản thảo 54 trang do Einstein, nhà vật lý học người Mỹ gốc Đức, và kỹ sư Thụy Sĩ Michele Besso, bạn thâm niên và cũng là người cộng tác duy nhất của ông, viết tay để chuẩn bị cho thuyết tương đối rộng của Einstein, ý tưởng đã thay đổi cách hiểu của con người về vũ trụ và được mô tả là thuyết đẹp nhất trong vật lý. Einstein thường vứt các bản thảo, nhưng nhờ Besso, bản thảo hiếm này đã được giữ lại.

Bản thảo được bán với giá gần 11,5 triệu USD cho một người giấu tên trong cuộc đấu giá do Christie''s, nhà đấu giá hàng đầu thế giới, tổ chức ở Paris, Pháp hôm 23/11. Sofia Hame, phát ngôn viên Christie''s, cho biết cộng thêm các khoản phí, tổng giá thành bản thảo lên tới hơn 13 triệu USD.', 1)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (2, N'Đa số dân Mỹ không hài lòng cách Biden điều hành đất nước
', N'Khảo sát CBS News/YouGov cho thấy đa số người dân không đồng tình cách Biden điều hành đất nước và chỉ 4% tin mọi thứ ở Mỹ đang rất tốt.

Theo kết quả khảo sát công bố hôm 21/11, khoảng 44% người được hỏi ủng hộ cách Tổng thống Mỹ Joe Biden làm việc. Cuộc khảo sát cũng chỉ ra ông chủ Nhà Trắng đang bị đánh giá tiêu cực về các vấn đề lạm phát, nhập cư, kinh tế, chính sách đối ngoại và sắc tộc.

Đối với vấn đề tiêm chủng Covid-19, Tổng thống Mỹ nhận được quan điểm tích cực hơn, với 53% người tham gia khảo sát ủng hộ ông.', 1)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (3, N'Mỹ, Anh quyết vớt xác tiêm kích F-35 trước Nga
', N'Quan chức Mỹ, Anh cam kết thu hồi tiêm kích F-35B rơi xuống Địa Trung Hải, cho biết không lo ngại khả năng Nga tiếp cận xác máy bay.

"Chúng tôi sẽ thu hồi nó trước, tôi hứa như vậy", tướng Simon Doran, chỉ huy lực lượng Mỹ trên tàu sân bay Anh HMS Queen Elizabeth, nói với các phóng viên hôm qua, đề cập tới nỗ lực tìm kiếm và trục vớt xác tiêm kích tàng hình F-35B lao xuống Địa Trung Hải giữa tuần trước.

"Chúng tôi không lo lắng về quá trình thu hồi máy bay và đang xử lý vấn đề. Rõ ràng có lo ngại khi chiến đấu cơ rơi xuống biển. Điều quan trọng nhất là phi công đã an toàn", tướng Tim Radford, Phó tư lệnh tối cao Lực lượng Đồng minh tại châu Âu, nói thêm.', 1)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (4, N'Messi nhớ thuở cạnh tranh với Ronaldo ở La Liga
', N'Trong cuộc phỏng vấn dài với tờ Marca (Tây Ban Nha), Lionel Messi đã nói về Cristiano Ronaldo, Kylian Mbappe, cuộc sống mới ở Paris hay khát khao vô địch World Cup.
- Anh có biết mình đang giữ kỷ lục La Liga khi giành tám giải thưởng Vua phá lưới Pichichi?

- Đoạt được quá nhiều Pichichi thật sự điên rồ. Có cảm giác như không ai có thể chạm vào kỷ lục cũ sáu Pichichi của Telmo Zarra, chứ chưa nói đến việc vượt qua ông ấy. Kỷ lục này thực sự ngoạn mục.

- Anh có nghĩ sẽ không có ai phá được kỷ lục này của anh, và nhiều thành tích khác nữa tại La Liga?

- Tôi đang ở Paris, và tôi không đánh giá quá cao giá trị của các kỷ lục này. Chúng tôi chơi mỗi trận cách ba ngày, và không có thời gian để nghĩ về điều đó. Mọi người tập trung vào trận tiếp theo, cố gắng đạt được mục tiêu và vượt qua thử thách đã đặt ra. Khi giải nghệ, tôi mới bắt đầu nhìn lại tất cả kỷ lục mà tôi may mắn lập được. Khi đó tôi sẽ công nhận giá trị thực sự của chúng. Khi điểm lại những kỷ lục này, tôi mới thấy những gì mình làm được thật phi thường.', 2)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (5, N'Barca nguy cơ đá Europa League
', N'Barca chiếm ưu thế với 66% thời lượng kiểm soát bóng, dứt điểm 14 lần và ba cú trúng đích. Nhưng họ không thể tìm thấy đường vào khung thành Benfica.

Trận hòa tại Camp Nou khiến Barca lâm nguy. Thầy trò HLV Xavi vẫn đứng thứ hai bảng E với bảy điểm, hơn Benfica hai điểm. Barca buộc phải thắng khi làm khách trước Bayern - đội giành 15 điểm tuyệt đối qua năm trận - ở lượt cuối để tự định đoạt số phận.', 2)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (6, N'Cảnh sát ''đạo diễn'' vụ cướp Bitcoin trị giá 37 tỷ đồng
', N'TP HCMNguyễn Quốc Dũng (40 tuổi, cảnh sát) được xác định đã lên kế hoạch cho đồng phạm vờ đụng ôtô của doanh nhân rồi tấn công, cướp tiền ảo giá hơn 37 tỷ.

Ngày 23/11, hành vi của Dũng, Hồ Ngọc Tài (32 tuổi) và 14 người khác được VKSND Tối cao nêu trong cáo trạng truy tố về tội Cướp tài sản theo khoản 4 Điều 168 Bộ luật Hình sự, khung hình phạt 18-20 năm hoặc tù chung thân.', 3)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (7, N'Phan Sào Nam bị buộc quay lại nhà tù
', N'TAND Cấp cao chấp nhận kháng nghị của VKSND Cấp cao về việc hủy hai quyết định giảm 22 tháng tù cho cựu chủ tịch VTC Online Phan Sào Nam.

Phán quyết được đưa trong phiên giám đốc thẩm do TAND Cấp cao tại Hà Nội mở vài ngày trước. Theo đó, Toà Cấp cao đã chấp nhận toàn bộ kháng nghị của VKS và cho rằng quyết định giảm thời gian chấp hành án với phạm nhân Phan Sào Nam là không đủ điều kiện và không có căn cứ pháp luật. Cựu chủ tịch VTC Online vì thế phải chấp hành hết phần bản án còn lại - thụ án tiếp 22 tháng tù.

Ngày 21/11, luật sư của Nam cho biết thân chủ chưa nhận được các quyết định hay thông báo nào về việc này.

Trong vụ án tổ chức đánh bạc qua game bài có bảo kê của hai tướng công an, Nam bị TAND Cấp cao tại Hà Nội phạt 5 năm tù về tội Tổ chức đánh bạc và Rửa tiền; thời hạn tính từ ngày bị bắt (tháng 10/2017), thi hành án tại Trại giam Quảng Ninh.

Ngày 29/4/2020, TAND tỉnh Quảng Ninh chấp nhận đề nghị của trại Trại giam Quảng Ninh này về việc giảm thời hạn chấp hành án phạt tù 19 tháng cho Nam. Ngày 4/2, TAND tỉnh Quảng Ninh lần thứ hai chấp nhận đề nghị của trại, giảm hết thời hạn chấp hành án phạt tù còn lại là 3 tháng 7 ngày. Nam ra tù ngày 6/2, sớm 22 tháng so với thời hạn.

Hơn hai tháng sau, ngày 14/4, VKSND Cấp cao tại Hà Nội ra quyết định kháng nghị giám đốc thẩm về hai quyết định nêu trên của TAND tỉnh Quảng Ninh. Viện đánh giá hai quyết định đưa ra là "không đủ điều kiện và không có căn cứ".', 3)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (8, N'Hỗn chiến trước mặt cảnh sát
', N'Đỗ Hoàng Lâm (38 tuổi), Hà Vĩnh Phát (26 tuổi) cùng 2 người đến quán nhậu ở chung cư Nhiêu Lộc C (phường Tân Quý) ăn uống, chiều 21/11. Nhân viên đưa menu cho chọn món, nhưng nhóm khách yêu cầu "chủ quán phải ra tiếp bàn này". Nhân viên cho biết "chủ quán không có ở đây" và từ chối phục vụ.

Lâm đứng dậy đánh anh này, bị nhiều người trong quán vác gậy, thanh sắt xông đến đánh trả. Công an phường, bảo vệ dân phố sau đó đến can ngăn, song hai bên vẫn rượt đuổi đánh nhau khiến nhiều người bị thương.

Cảnh sát đã tạm giữ một số người liên quan để điều tra.', 3)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (9, N'NASA phóng tàu làm chệch hướng tiểu hành tinh
', N'Tàu vũ trụ của NASA sẽ đâm thẳng vào một tiểu hành tinh bay gần Trái Đất, giúp giới nghiên cứu phát triển chiến lược bảo vệ hành tinh trước những thiên thể nguy hiểm.', 4)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (10, N'Người đàn ông nhầm thiên thạch 17 kg là khối vàng
', N'Một cư dân ở Australia giữ tảng đá kỳ lạ trong nhiều năm vì nghi ngờ nó chứa đầy vàng nhưng sự thật nằm ngoài mong đợi.

Năm 2015, khi đang dò tìm kim loại trong Công viên Vùng Maryborough gần thành phố Melbourne, thủ phủ bang Victoria của Australia, David Hole tình cờ phát hiện một khối đá bất thường: nó rất nặng, có màu nâu đỏ với một số đốm vàng, và đặc biệt khiến máy dò kêu lên.

Nghi ngờ có vàng bên trong, người đàn ông đã mang vật thể về nhà và thử mọi cách để mở nó ra, nhưng dù dùng cưa, máy khoan, máy mài, búa tạ hay thậm chí là ngâm trong axit, anh cũng không thể phá vỡ cấu trúc tảng đá.

Sau nhiều nỗ lực không thành, Hole gần đây quyết định mang "kho báu" của mình đến Bảo tàng Melbourne để nhận dạng và nhờ đó, biết được sự thật bất ngờ. Tảng đá mà anh nghĩ chứa đầy vàng hóa ra là một khối thiên thạch.

"Nó có vẻ ngoài trông như được đục đẽo và mãi giũa. Đó là do thiên thạch tan chảy khi ma sát với bầu khí quyển của Trái Đất", nhà địa chất Dermot Henry từ Bảo tàng Melbourne nói với tờ Sydney Morning Herald.

Henry cho biết thêm rằng ông đã phân tích rất nhiều tảng đá mà mọi người nghĩ là thiên thạch, nhưng suốt 37 năm làm việc tại bảo tàng, chỉ có hai mẫu vật trong đó thực sự là thiên thạch. Phát hiện của David Hole là một trong hai.

Mảnh thiên thạch này ước tính 4,6 tỷ năm tuổi và nặng tới 17 kg. "Nếu thử nâng một tảng đá trên Trái Đất có kích thước tương tự, bạn sẽ thấy nó không nặng như vậy", nhà địa chất Bill Birch tại Bảo tàng Melbourne, người cũng tham gia phân tích thiên thạch, chia sẻ.', 4)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (11, N'Chu Diệp Anh: ''Em cố gắng vừa học vừa đóng phim''
', N'Sao nhí Chu Diệp Anh, 10 tuổi, mang máy tính để tranh thủ học online trên phim trường "Thương ngày nắng về".

- Cảnh nhân vật của em - Hoa - khóc khi phải xa mẹ lay động khán giả, em cảm thấy thế nào?

- Em được mẹ cho đọc nhiều bình luận trên mạng xã hội về phim và thấy rất vui khi mọi người nhận xét diễn đạt vai Hoa. Ông bà nội mong em cố gắng phát huy. Trong một buổi học, cô giáo hỏi: "Bạn nào xem phim của Diệp Anh chưa?", nhiều bạn nói xem rồi và khen hay. Có bạn lớp khác thì chụp ảnh Hoa trên tivi rồi gửi qua Facebook. Em thấy hạnh phúc, muốn sau này đóng nhiều phim hơn nữa để được mọi người khen.

', 5)
INSERT [dbo].[NewsLocal] ([newsId], [newsTitle], [newsContent], [categoryId]) VALUES (12, N'Cựu công chúa Nhật mặc thoải mái sau lấy chồng
', N'Mako - cựu công chúa Nhật - chuyển sang những món đồ cơ bản, năng động sau khi kết hôn với thường dân.

Vợ chồng Mako xuống phố ở Mỹ hôm 20/11 với bộ đồ giản dị. Mako diện áo phông, quần jeans xắn gấu, kết hợp bốt quân đội màu đen. Cô hoàn thiện vẻ ngoài bằng áo khoác lông xanh lục, nhấn bằng túi tote vàng. Hình ảnh phóng khoáng, tự do của Mako khác xa thời còn làm công chúa ở Nhật với váy áo thanh lịch, được may đo chuẩn mực, toát lên nét nghiêm nghị.

Chồng cô - Kei Komuro - diện áo khoác màu xám, quần kaki xanh tím than và sneakers. Mái tóc anh bắt đầu dài hơn so với hôm cưới, chải ngôi giữa. Kiểu tóc của Komuro từng khiến người dân Nhật Bản tranh cãi.', 5)
SET IDENTITY_INSERT [dbo].[NewsLocal] OFF
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202111240315192_init', N'Bai2.Migrations.Configuration', 0x1F8B0800000000000400D559CD6EE33610BE17E83B083AB545D672924B1BD8BBC83A49613489833859F41630D2D8214A912A49A5368A3E590F7DA4BE4287FA97285BB237D96C914B24CE7C331C7E339C91FFFDFB9FD18755C89C67908A0A3E760F0743D701EE8B80F2E5D88DF5E2DD8FEE87F7DF7E333A0FC295F329973B3672A8C9D5D87DD23A3AF13CE53F4148D420A4BE144A2CF4C017A14702E11D0D873F7987871E20848B588E33BA8DB9A621240FF83811DC8748C7845D890098CADEE3CA3C4175AE49082A223E8CDD8F841E0D5231D7396594A00B73600BD7219C0B4D343A7872AF60AEA5E0CB79842F08BB5B4780720BC214648E9F94E27DF7303C327BF04AC51CCA8F9516E18E8087C75950BCA6FA5EA1758BA061D8CE31BC7A6D769D846EEC5EC31F6A42342C855CBB4ED3E0C98449235C8BEEA0AA73E098958382014814F377E04C62A66309630EB196841D3837F123A3FE2FB0BE13BF011FF398B1AA6BE81CAED55EE0AB1B2922907A7D0B8BCC613F333C0D5CC7ABEB7B4D8042BD4537DDD694EBE323D7B94667C8238382099510CCB590F0337090A81DDC10AD41E2414E0348626979B1C1A679CAAD2205318D5CE78AAC2E812FF51326CE1013E782AE20C8DF649EDC738A59874A5AC66019BB26CF7499F8D9306BCEE852F8C424C32DB044443DD128CD8941B1FC5027C08514E1AD6055809AC4C31D914BD0B811B1556C2E62E937DC1D7925FB3A399960EE42C844E18BB391A3E57D9898EB7D29161A7B7754B357A0608B252CDB1AFDDA620BFF7D015BFDF37997B429B3E1251327CF888EC4C9F3AB4FE29C2A257C9A78D8CC9CBA77F5CD9FF3C0E9E76A7A7AB56DE329622AD10893073D1ABB3F58B1ED842F4A481DBE8C65DDC2A1DB4CC3193F03061A9C533FBD542744F924B08F19E316D4DF60E682342943189254612DA05CDB694EB94F23C27AEDA3A1BDE3A565BC2CEC3557CE20026E32BCD7797DBE2385BD4618BBA236F22A54B44BBB2907A801B29A64A644AC744B85C7162D2BF22AAB024D7E19CC39E86AC129B853664A2BB52CAEDA5819CD5B81B2B5064A65F325D4A6425111DE5E529AA7D33B6D8B4DD5F6639D76EF3C6DE06D0CA6578F434B012B8850F6F15EDAC8E70DBFB7A1E31F5D9128C24BA43201646F9C79DAFE4FDECD776F8FC314C3F3554B975C785B58C23B982CA1B18AA6D1D30B2A953E239A3C1273DF4C82D012ABD27E030D734B2DCCB68F2FE767AE64FE4F153735EB2D252253BEC08D85A6D0247D46E5C4B7AB27831861446EB9982782C521EF2E3FDD68690BDD8697AED88823AFB13FABE45961B46E90FAD1F43EB834ED3EE7D45A117A1ED906DD4D11CEDBD16A6CDB5BDB2E94ACC96C0265AF77C32ADAC8265AB1B03B877663E4ABF2C7AA8A4D91C27A511D1B55709455A4EE8F2356894A455C07C3F44C03539EE66BA5211C1881C1FC7736613409712E7045385D80D2E9BCE41E0D0F8F1A9F59BE9E4F1E9E5201DBE1BBC79B7F86A026D29D235ED754D3E3CB037F26D27F22D21EFC4A707BF2DA63727FB359FA5542698DCFFBC5B1D7B49C437F1792D5F7BBE26DA096D5644FB1CD5F8DDD3F13B51367FAEB43A979E0CC2426FC893374FEEA88D4AB4EA665A3F91693624B7BBCEF44BCF7D0B9A56F7BFD19F3FF334FDAFDF7F629AFCEA18E8931BD28C76EF028F0FCD34CD869A6AC1065DB4CB9C94EFE11F72B98399B31B307845E53A6A5DE3E55BFC838693748C8BECA6F4C487F45972584F9C589835FE35D2133E50B91A740C3A35CA4518EAF40930049792A355D105FE3B20F4A255F433F1116A3C879F808C194CF621DC51AB70CE123AB05D2A4D136FBC9CC5CF779348B92CF962FB1057493E21660C63FC6940585DF172DB7C10608939FD9656CCE529B4B79B92E90AE05EF099485AF282B7710460CC1D48CCFC933ECE3DBBD824B58127F9DF7B99B41BA0FA21EF6D119254B4942956194FAF8881C0EC2D5FBFF004CEEAEC26A1D0000, N'6.4.4')
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202111240317311_init2', N'Bai2.Migrations.Configuration', 0x1F8B0800000000000400D559CD6EE33610BE17E83B083AB545D672924B1BD8BBC83A49613489833859F41630D2D8214A912A49A5368A3E590F7DA4BE4287FA97285BB237D96C914B24CE7C331C7E339C91FFFDFB9FD18755C89C67908A0A3E760F0743D701EE8B80F2E5D88DF5E2DD8FEE87F7DF7E333A0FC295F329973B3672A8C9D5D87DD23A3AF13CE53F4148D420A4BE144A2CF4C017A14702E11D0D873F7987871E20848B588E33BA8DB9A621240FF83811DC8748C7845D890098CADEE3CA3C4175AE49082A223E8CDD8F841E0D5231D7396594A00B73600BD7219C0B4D343A7872AF60AEA5E0CB79842F08BB5B4780720BC214648E9F94E27DF7303C327BF04AC51CCA8F9516E18E8087C75950BCA6FA5EA1758BA061D8CE31BC7A6D769D846EEC5EC31F6A42342C855CBB4ED3E0C98449235C8BEEA0AA73E098958382014814F377E04C62A66309630EB196841D3837F123A3FE2FB0BE13BF011FF398B1AA6BE81CAED55EE0AB1B2922907A7D0B8BCC613F333C0D5CC7ABEB7B4D8042BD4537DDD694EBE323D7B94667C8238382099510CCB590F0337090A81DDC10AD41E2414E0348626979B1C1A679CAAD2205318D5CE78AAC2E812FF51326CE1013E782AE20C8DF649EDC738A59874A5AC66019BB26CF7499F8D9306BCEE852F8C424C32DB044443DD128CD8941B1FC5027C08514E1AD6055809AC4C31D914BD0B811B1556C2E62E937DC1D7925FB3A399960EE42C844E18BB391A3E57D9898EB7D29161A7B7754B357A0608B252CDB1AFDDA620BFF7D015BFDF37997B429B3E1251327CF888EC4C9F3AB4FE29C2A257C9A78D8CC9CBA77F5CD9FF3C0E9E76A7A7AB56DE329622AD10893073D1ABB3F58B1ED842F4A481DBE8C65DDC2A1DB4CC3193F03061A9C533FBD542744F924B08F19E316D4DF60E682342943189254612DA05CDB694EB94F23C27AEDA3A1BDE3A565BC2CEC3557CE20026E32BCD7797DBE2385BD4618BBA236F22A54B44BBB2907A801B29A64A644AC744B85C7162D2BF22AAB024D7E19CC39E86AC129B853664A2BB52CAEDA5819CD5B81B2B5064A65F325D4A6425111DE5E529AA7D33B6D8B4DD5F6639D76EF3C6DE06D0CA6578F434B012B8850F6F15EDAC8E70DBFB7A1E31F5D9128C24BA43201646F9C79DAFE4FDECD776F8FC314C3F3554B975C785B58C23B982CA1B18AA6D1D30B2A953E239A3C1273DF4C82D012ABD27E030D734B2DCCB68F2FE767AE64FE4F153735EB2D252253BEC08D85A6D0247D46E5C4B7AB27831861446EB9982782C521EF2E3FDD68690BDD8697AED88823AFB13FABE45961B46E90FAD1F43EB834ED3EE7D45A117A1ED906DD4D11CEDBD16A6CDB5BDB2E94ACC96C0265AF77C32ADAC8265AB1B03B877663E4ABF2C7AA8A4D91C27A511D1B55709455A4EE8F2356894A455C07C3F44C03539EE66BA5211C1881C1FC7736613409712E7045385D80D2E9BCE41E0D0F8F1A9F59BE9E4F1E9E5201DBE1BBC79B7F86A026D29D235ED754D3E3CB037F26D27F22D21EFC4A707BF2DA63727FB359FA5542698DCFFBC5B1D7B49C437F1792D5F7BBE26DA096D5644FB1CD5F8DDD3F13B51367FAEB43A979E0CC2426FC893374FEEA88D4AB4EA665A3F91693624B7BBCEF44BCF7D0B9A56F7BFD19F3FF334FDAFDF7F629AFCEA18E8931BD28C76EF028F0FCD34CD869A6AC1065DB4CB9C9CED73372364366CF07BD864C4BBD7D872F324DDAFD1192AFF21313B25FD16509617E70E2E0D76857C84CF942E419D0F028176954E32BD024404E9E4A4D17C4D7B8EC8352C9C7D04F84C528721E3E4230E5B35847B1C62D43F8C86A813459B4CD7E3232D77D1ECDA2E4ABE54B6C01DDA4B80598F18F316541E1F745CB65B001C2A46776179BB3D4E64E5EAE0BA46BC17B0265E12BAACA1D8411433035E373F20CFBF876AFE01296C45FE76DEE6690EE83A8877D7446C95292506518A53E3E22878370F5FE3F24485C0C691D0000, N'6.4.4')
GO
