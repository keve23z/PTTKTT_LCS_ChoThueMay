def lcs_length(X, Y):
    # Bước 1: Xác định độ dài của hai chuỗi X và Y
    n = len(X)  # Độ dài chuỗi X
    m = len(Y)  # Độ dài chuỗi Y

    # Bước 2: Khởi tạo ma trận c với kích thước (n+1) x (m+1)
    c = [[0 for _ in range(m+1)] for _ in range(n+1)]

    # Bước 3: Tính toán độ dài LCS
    for i in range(1, n+1):
        for j in range(1, m+1):
            if X[i-1] == Y[j-1]:
                c[i][j] = c[i-1][j-1] + 1
            else:
                c[i][j] = max(c[i-1][j], c[i][j-1])

    # Bước 4: Trả về ma trận c và chuỗi con chung dài nhất
    lcs = []
    i, j = n, m
    while i > 0 and j > 0:
        if X[i-1] == Y[j-1]:
            lcs.append(X[i-1])  # Thêm ký tự vào chuỗi LCS
            i -= 1
            j -= 1
        elif c[i-1][j] >= c[i][j-1]:
            i -= 1
        else:
            j -= 1

    # Vì chuỗi con chung dài nhất được tìm theo thứ tự ngược, ta đảo lại chuỗi
    lcs.reverse()

    # In ma trận LCS
    print("Ma trận c:")
    for row in c:
        print(row)

    # In chuỗi con chung dài nhất
    print("\nChuỗi con chung dài nhất (LCS): " + "".join(lcs))
    lcs_length = c[n][m]
    print(f"\nĐộ dài của chuỗi con chung dài nhất: {lcs_length}")


# Ví dụ sử dụng
X = "ABCDCAE"
Y = "DACDBA"

# Gọi hàm và tính toán LCS
lcs_length(X, Y)
