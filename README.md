# Đề bài : liệt kê tất cả các file và thư mục;

# Bài 1: Liệt kê thư mục và file
Trong Linux có một ứng dụng nổi tiếng có tên là tree để liệt kê toàn bộ thư mục và thư mục con + file

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

Hãy viết một ứng dụng bằng C# nhận vào tham số là đường dẫn thư mục sau đó liệt kê toàn bộ nội dung thư mục đó.
Chú ý nếu tham số là
- . liệt kê thư mục hiện thời
- .. liệt kê thư mục cha
- ~ liệt kê thư mục người dùng 
# Solution:


