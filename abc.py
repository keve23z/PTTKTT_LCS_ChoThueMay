# Hỏi người dùng chọn cách nhập dữ liệu
print("Chọn cách nhập dữ liệu:")
print("1. Nhập từ file")
print("2. Nhập tay")
mode = int(input("Lựa chọn của bạn (1/2): "))

# Khởi tạo biến s1 và s2
s1, s2 = "", ""

# Nhập dữ liệu từ file
if mode == 1:
    file_name = input("Nhập tên file (mặc định: Bai2.inp): ").strip()
    if file_name == "":
        file_name = "Bai2.inp"  # Tên file mặc định nếu không nhập tên
    with open(file_name, "r") as f:
        s1 = f.readline().strip()
        s2 = f.readline().strip()

# Nhập dữ liệu từ bàn phím
elif mode == 2:
    s1 = input("Nhập chuỗi thứ nhất: ").strip()
    s2 = input("Nhập chuỗi thứ hai: ").strip()

else:
    print("Lựa chọn không hợp lệ. Vui lòng chạy lại chương trình.")
    exit()

# Tạo bảng để lưu độ dài của xâu con chung
dp = [[0] * (len(s2) + 1) for _ in range(len(s1) + 1)]
chuoidainhat = []
sl_chuoi = 0

# Duyệt qua các phần tử của 2 xâu và tính độ dài xâu con chung tại mỗi ô của bảng
for i in range(1, len(s1) + 1):
    for j in range(1, len(s2) + 1):
        if s1[i - 1] == s2[j - 1]:  # Nếu hai ký tự giống nhau
            dp[i][j] = dp[i - 1][j - 1] + 1  # Cộng thêm 1 vào độ dài của xâu con chung
            if dp[i][j] > sl_chuoi:
                sl_chuoi = dp[i][j]  # Cập nhật lại sl_chuoi
                chuoidainhat = [s1[i - sl_chuoi:i]]  # Cập nhật danh sách xâu con chung dài nhất
            elif dp[i][j] == sl_chuoi:
                chuoidainhat.append(s1[i - sl_chuoi:i])  # Thêm vào nếu có xâu con chung khác cùng độ dài

# In ra kết quả
print(f"Độ dài của xâu con chung dài nhất: {sl_chuoi}")
print("Các xâu con chung dài nhất:")
for s in chuoidainhat:
    print(s)

# Hỏi xem người dùng có muốn ghi ra file không
output_file = int(input("Bạn có muốn ghi kết quả ra file không? (1.có/2.không): "))

if output_file == 1:
    output_file_name = input("Nhập tên file xuất (mặc định: Bai2.out): ").strip()
    if output_file_name == "":
        output_file_name = "Bai2.out"  # Tên file mặc định nếu không nhập tên

    # Ghi kết quả ra file
    with open(output_file_name, "w") as f:
        f.write(str(sl_chuoi) + "\n")
        f.write("\n".join(chuoidainhat) + "\n")

        f.write("Ma trận dp:\n")
        for row in dp:
            f.write(" ".join(map(str, row)) + "\n")
    print(f"Kết quả đã được ghi vào file {output_file_name}")
else:
    print("Không ghi kết quả ra file.")
