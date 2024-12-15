#Cho mảng 1 chiều a đã có thứ tự chứa n số nguyên,viết hàm theo kỹ thuật đệ quy

def nhap_mang(n):
    if n == 0:
        return []
    else:
        x = int(input("Nhập phần tử: "))
        return [x] + nhap_mang(n - 1)

print("Nhập mảng bằng đệ quy")
n = int(input("Nhập số lượng phần tử trong mảng: "))
mangnhap = nhap_mang(n)
print("Mảng đã nhập:", mangnhap)


#a. Nhập xuất mảng bằng đệ quy

def xuat_mang(mang, i=0):
    if i == len(mang):
        return
    print(mang[i], end=' ')
    xuat_mang(mang, i + 1)

print("Xuất mảng bằng đệ quy")
xuat_mang(mangnhap)

#b.    tìm kiếm số x trên a theo thuật toán tìm kiếm nhị phân bằng kỹ thuật đệ quy.
def sap_xep(mang,n):
    for i in range(n):
        min_idx = i
        for j in range(i+1, n):
            if mang[j] < mang[min_idx]:
                min_idx = j
        mang[i], mang[min_idx] = mang[min_idx], mang[i]


def tim_kiem_nhi_phan(mang, trai, phai, x):
    if phai >= trai:
        giua = trai + (phai - trai) // 2  

        if mang[giua] == x:
            return giua

        elif mang[giua] > x:
            return tim_kiem_nhi_phan(mang, trai, giua - 1, x)

        else:
            return tim_kiem_nhi_phan(mang, giua + 1, phai, x)

    else:
        return -1

print()
x = int(input("Nhập phần tử cần tìm trong mảng: ")) # Phần tử cần tìm

sap_xep(mangnhap,n)

xuat_mang(mangnhap)
# Gọi hàm tìm kiếm nhị phân
print()
vitritimkiem = tim_kiem_nhi_phan(mangnhap, 0, n - 1, x)

if vitritimkiem != -1:
    print(f"Phần tử {x} được tìm thấy tại chỉ số {vitritimkiem}.")
else:
    print(f"Phần tử {x} không tồn tại trong mảng.")

    
#c.   Tìm max chẵn trong a
def tim_max_chan(mang, n):
    if n < 0:
        return None  
    max_cua_phan_con_lai = tim_max_chan(mang, n - 1)
    
    if mang[n] % 2 == 0:
        if max_cua_phan_con_lai is None or mang[n] > max_cua_phan_con_lai:
            return mang[n]
    
    return max_cua_phan_con_lai

max_chan = tim_max_chan(mangnhap, n - 1)

if max_chan is not None:
    print(f"Số chẵn lớn nhất trong mảng là: {max_chan}")
else:
    print("Không có số chẵn nào trong mảng.")

#c.    Tính tổng lẻ trong a

def tinh_tong_le(mang, n):
    if n < 0:
        return 0  # Điều kiện dừng: Nếu mảng đã duyệt hết, trả về 0
    
    # Kiểm tra nếu phần tử hiện tại là số lẻ
    if mang[n] % 2 != 0:
        return mang[n] + tinh_tong_le(mang, n - 1)
    else:
        return tinh_tong_le(mang, n - 1)

# Ví dụ sử dụng
a = [3, 7, 2, 8, 1, 10, 5, 12, 6]
tong_le = tinh_tong_le(mangnhap, n - 1)

print(f"Tổng các số lẻ trong mảng là: {tong_le}")

#e.   Xuất các số ở vị trí lẻ


def xuat_so_vi_tri_le(mang, index):
    if index >= len(mang):
        return []  
    
    if index % 2 != 0:
        return [mang[index]] + xuat_so_vi_tri_le(mang, index + 1)
    else:
        return xuat_so_vi_tri_le(mang, index + 1)
    
mang_le = xuat_so_vi_tri_le(mangnhap, 0)

print(f"Các số ở vị trí lẻ trong mảng là: {mang_le}")