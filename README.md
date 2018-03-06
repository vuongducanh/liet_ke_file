# Đề bài : liệt kê tất cả các file và thư mục;

# Bài 1: Liệt kê thư mục và file
Trong Linux có một ứng dụng nổi tiếng có tên là tree để liệt kê toàn bộ thư mục và thư mục con + file
```
$ tree .
.
 ├──[folderA]
  │    └──[folderA1]
  │         ├──[fodlerA11]
  │         │    └──[folder!!!]
  │         │         └──New Text Document.txt
  │         └──New Text Document.txt
  ├──[folderB]
  └──New Text Document.txt
```
Hãy viết một ứng dụng bằng C# nhận vào tham số là đường dẫn thư mục sau đó liệt kê toàn bộ nội dung thư mục đó.
Chú ý nếu tham số là
- . liệt kê thư mục hiện thời
- .. liệt kê thư mục cha
- ~ liệt kê thư mục người dùng 
# Solution:  tham số truyền vào là đường dẫn của folder và khoảng cách để vẽ;

## Bước một chúng ta phải lấy folder và file trong thư muc cha lơn nhất ta dùng câu lệnh:
```
Directory.GetDirectories(<tham số truyền vào>)
Directory.GetFiles(<tham số truyền vào>)
```
##  Sau đó chúng ta phải kiểm tra trong folder cha đó có chứa file hay folder không nếu có thì chạy vòng lặp duyệt qua các phần tử ở trong 
### Chúng ta dùng lệnh này để loại bỏ đi các phần không cần thiết mà chỉ lấy tên và thư mục hiện thời
```
 Path.GetFileName
```
### Đối với bài này thì chúng ta nên dùng đệ quy gọi lại chính cái hàn function của mình để liệt kê tất cả các file và folder
```
tree();
```
## Đến phần Vẽ thì mỗi lần mà tìm đến thư mục con thì sẽ cách lề một khoảng cách 


