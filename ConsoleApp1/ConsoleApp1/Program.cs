// See https://aka.ms/new-console-template for more information

/* Bien: trong C# giống C++
    - Biến dùng để lưu trữ dữ liệu từ bàn phím hoặc được trả về từ trong phần mềm
    - Đặc điểm:
        + Biến là duy nhất
        + Mỗi biến có 1 kiểu dữ liệu
        + Giá trị của biến có thể thay đổi
    - Khai báo biến:
        + Khai báo biến không có giá trị
            Data_type variable_name;
        + Khai báo biến có giá trị của biến
            Data_type variable_name = value;
    - Quy tắc đặt tên biến:
        + Tên biến chứa ký tự chữ cái (hoa, thường), số, _
        + Tên biến không chứa ký tự đặc biệt
        + Tên biến không được bắt đầu bằng số
        + Tên biến không trùng từ khóa
        + Tên biến phân biệt hoa thường
        + Tên biến không trùng nhau
*/
/* Kiểu dữ liệu (Data type): giống C++
    - Là kiểu của giá trị mà biến đó lưu
    - 1 số kiểu dữ liệu cơ bản
        + Số nguyên: int
        + Số thực: float || double
        + Chuỗi: string 
*/
/* Toán tử (Operator): giống C++
    - Là ký hiệu thể hiện cho các phép toán
    - 1 số loại toán tử:
        + Toán tử số học: +, -, *, /, %
        + Toán tử quan hệ: >, <, >=, <=, ==, !=
        + Toán tử logic: &&, ||, !
        + Toán tử bit
        + Toán tử gán: =, +=, -=, *=, /=, %=
*/
/* Condition (Cấu trúc điều khiển rẽ nhánh): giống C++
    - Thực hiện 1 khối lệnh khi 1 điều kiện nào đó được thỏa mãn
    Cấu trúc:
        if(condition){
            code block;
        }; 
        
        if(codition){
            code block 1;
        } else {
            code block 2
        };
        
        if(condition_1){
            code block 1;
        } elseif (condition_2) {
            code block 2;
        } elseif (condition_3){
            code block 3;
        }
        ... else {
            code block n;
        }
        
        if(condition_1){
            if(condition_2){
                code block 1;
            }
        }
    Cấu trúc lựa chọn switch - case
    Đặc điểm:
        + Chỉ áp dụng khi tất cả các điều kiện đều là so sánh ==
        + Khi tìm thấy case thỏa mãn: thực hiện case đó và tất cả các case  
            được viết bên dưới case thỏa mãn.
        switch(Biến_đang_cần_được_so_sánh){
            case giá_trị:
                code block;
                break;
            ...
            default:
                code block;
                break;
        }
*/
/*
    Nhập xuất cơ bản:
    - Nhập từ bàn phím
    Console.Read(): nhập 1 ký tự từ bàn phím, lưu trữ theo dạng số nguyên
    Console.Readline(): Nhập 1 chuỗi, nhập sao lưu vậy
    - Hiển thị dữ liệu ra màn hình
    Console.Write(): in trên 1 dòng
    Console.WriteLine(): in xong xuống dòng
*/
/*
    Ép kiểu:
    Ép sang int: int.Parse(gia_tri_can_ep)
*/
//int character = Console.Read();
//Console.WriteLine(character);

/*
    1. Nhap 2 so thuc a, b tu ban phim.
    Tinh tong, hieu, tich, thuong cua a, b
*/
//Khai bao a, b
double a;
double b;
//Nhap a, b
Console.Write("a = ");
a = double.Parse(Console.ReadLine());
Console.Write("b = ");
b = double.Parse(Console.ReadLine());
//Tinh
double tong = a + b;
double hieu = a - b;
double tich = a * b;
double thuong = a / b;
//Hien thi ket qua
Console.WriteLine("a + b = " + tong);
Console.WriteLine("a + b = " + hieu);
Console.WriteLine("a + b = " + tich);
Console.WriteLine("a + b = " + thuong);

/*
    2. Nhap so nguyen n tu ban phim. Kiem tra n la so duong hay am
*/
//Khai bao n
int n;
//Nhap n
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
//Kiem tra
if (n < 0)
{
    Console.WriteLine(n + " la so am");
} else if (n > 0)
{
    Console.WriteLine(n + " la so duong");
}
else
{
    Console.WriteLine("n = 0");
}