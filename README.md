# framework_IS220.M11.HTCL_2
<br>Đây là project được phát triển bởi UIT_OTD Team, mục đích phát triển website  bán các sản phẩm công nghệ như Laptop, Điện thoại, Tablet...</br>
<br>Dự án này được truyền cảm hứng từ OTDGang và các website đang hoạt động chuyên cung cấp các sản phẩm công nghệ như CellphoneS hay HoangHaMoblie.</br>
<br> Người dùng có thể xem và lựa chọn những sản phẩm chất lượng, chính hãng phù hợp với bản thân. </br>
<br>Đồng thời, cho phép các quản trị viên theo dõi việc mua bán, các đơn hàng diễn ra trên web, cũng như quản lý các sản phẩm.<br>

# Cấu hình cần thiết:
<br> Trước khi tiến hành cài đặt đồ án này, hãy đảm bảo máy bạn đã cài đặt sẵn các ứng dụng sau: <br>
<br> Máy người dùng cần được cài đặt sẵn các ứng dụng sau: 
<h3> Microsoft Visual Studio </h3>
<br> Khuyến nghị cài đặt phiên bản 2017 hoặc các bản mới hơn </br>
<h3> Microsoft SQL Sever </h3>
<br> Khuyến nghị cài bản đặt bản từ 14 trở lên </br> 

# Cài đặt: 
<br> Để tiến hành cài đặt trên máy của người dùng, đầu tiên, người dùng tiến hành tải database về tại đường dẫn bên dưới:</br>
<br> **https://drive.google.com/drive/folders/1QmcPsLa4IKVFtwelo83XeGADOxa-Z7n7** </br>
<br> Sau khi người dùng tải về và giải nén được file, cần tiến hành di chuyển các file nhận được khi giải nén tới đường dẫn sau:</br>
<br> **C:\Program Files\Microsoft SQL Server\MSSQLXX.MSSQLSERVER\MSSQL\DATA** </br>
<br> Sau đó tiến hành mở ứng dụng MSSQL Sever, vào mục **Database** -> **Attach** -> Chọn file **OTDStore** và  tiến hành cài đặt</br>
<br> Bước tiếp theo, Mở Visual Studio, tại phần phần **Get started** bên phải, chọn  **Clone a repository** </br>
![image](https://user-images.githubusercontent.com/96718467/147855558-3a16c453-bd18-461d-96a4-242e8540ca3d.png)
<br> Tại dòng **Repository location**, người dùng gán đường dẫn của git này vào</br>
<br> **https://github.com/luutrananhkhoa/framework_IS220.M11.HTCL_2**</br>
<br> Sau khi hoàn thành gán đường dẫn đến file git, tại phần path, người dùng tạo một thư mục mới để clone git trên máy.</br>
<br> Hoàn tất bước trên, chọn **Clone**</br>
<br> <h3> Khi máy đã clone xong, tại bảng **Solution** thu được sau đó, người dùng chọn vào file**OTD.sln**</h3></br>
<br>![image](https://user-images.githubusercontent.com/96718467/147855737-b28da396-077b-4f19-bd0f-1050173347a9.png) </br>
<br> Sau khi mở file **OTD.sln**, sổ file **Domain**, mở rộng tab **OTDStore.Data** và chọn file appsetting.json</br>
<br>![image](https://user-images.githubusercontent.com/96718467/147855813-6f5f147e-c16a-4232-88d9-c4659a3ffb36.png) </br>
<br>Thay đổi **sever** theo như ứng dụng MSSQL Sever trên máy của bạn </br>
<br>![image](https://user-images.githubusercontent.com/96718467/147855866-320981bc-14db-487b-81e6-cdd8484f1482.png) </br>
<br> Làm tương tự với hai file: </br>
<br> **OTDStore.AdminApp/appsettings.Development.json**</br>
<br> Và</br>
<br> **OTDStore.BackendApi/appsettings.Development.json**</br>
<br> <h3>Tiếp theo, chuột phải vào thanh **Solution** mở **Property** </h3> </br>
<br> Chọn **Multiple startup projects**</br>
<br> **Start** các **project** sau: </br>
<br> **OTDStore.WebApp</br>
<br> OTDStore.AdminApp</br>
<br> OTDStore.BackendApi** (và đưa project này lên đầu danh sách)</br>
<br>![image](https://user-images.githubusercontent.com/96718467/147856049-07507cba-8965-42ea-bbd0-62bf73c6c0cc.png) </br>
<br> Và **OK**</br>
<br> Trước khi **RUN** project, chỉnh lại sao cho phương thức **Startup Projects** được thiết lập với **Debug Properties** tương ứng  </br>
<br>![image](https://user-images.githubusercontent.com/96718467/147856153-90577978-2a6d-480b-9976-7240e95d75d3.png) </br>
<br>![image](https://user-images.githubusercontent.com/96718467/147856166-10f84e29-c4d5-4835-adec-f87d8c144a65.png) </br>
<br>![image](https://user-images.githubusercontent.com/96718467/147856170-5a57c4ce-e66a-4587-85af-6fbd28a52907.png) </br>
<br> </br>


# About Us:
<br>Luu Tran Anh Khoa - 19520636</br>
<br>https://www.facebook.com/anhkhoa.luutran.3</br>
<br>Nguyen Thai Duong - 19521410</br>
<br>https://www.facebook.com/supernova.ntd.1812</br>
<br>Tran Thanh Trung - 19521065</br>
<br>https://www.facebook.com/trung18052001</br>
<br>Nguyen Thanh Dat - 19521340</br>
<br>https://www.facebook.com/JokerOfNever.Land/<br>
