
def main():
    # Nhập mảng thứ nhất
    m = int(input("Nhập số phần tử của mảng thứ nhất: "))
    s1 = []
    print("Nhập các phần tử của mảng thứ nhất:")
    for i in range(m):
        s1.append(int(input(f"Phần tử {i+1}: ")))

    # Nhập mảng thứ hai
    n = int(input("Nhập số phần tử của mảng thứ hai: "))
    s2 = []
    print("Nhập các phần tử của mảng thứ hai:")
    for i in range(n):
        s2.append(int(input(f"Phần tử {i+1}: ")))

    # Tạo bảng dp để lưu độ dài của mảng con chung
    dp = [[0] * (n + 1) for _ in range(m + 1)]
    max_length = 0  # Lưu độ dài của mảng con chung dài nhất

    # Duyệt qua các phần tử của mảng thứ nhất và mảng thứ hai
    for i in range(1, m + 1):
        for j in range(1, n + 1):
            if s1[i - 1] == s2[j - 1]:  # Nếu phần tử giống nhau
                dp[i][j] = dp[i - 1][j - 1] + 1  # Cộng thêm 1 vào độ dài của mảng con chung
                if dp[i][j] > max_length:
                    max_length = dp[i][j]  # Cập nhật độ dài của mảng con chung dài nhất

    # In ma trận dp
    print("\nMa trận dp:")
    for row in dp:
        print(" ".join(map(str, row)))

    # In kết quả
    print(f"\nĐộ dài của mảng con chung dài nhất: {max_length}")

    print("\nCác mảng con chung dài nhất:")
    # Tìm và in các mảng con chung dài nhất
    for i in range(m):
        for j in range(n):
            if s1[i] == s2[j] and dp[i + 1][j + 1] == max_length:
                print(f"Mảng con chung: {s1[i:i + max_length]} (tại vị trí s1[{i}] và s2[{j}])")

if __name__ == "__main__":
    main()
