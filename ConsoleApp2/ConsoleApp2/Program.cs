// See https://aka.ms/new-console-template for more information

/*
    Vòng lặp (Loop): giống Java
        - Thực hiện 1 khối lệnh được lặp lại nhiều lần
        - 3 loại vòng lặp: for, while, do - while
        - for:
            + Cấu trúc
                for(tham số 1; tham số 2; tham số 3){
                    code block;
                }
            + Tham số 1: thời điểm bắt đầu vòng lặp: xác định xem vòng lặp bắt đầu từ đâu
                Nếu thiếu tham số 1: Lỗi cú pháp
            + Tham số 2: Điều kiện duy trì vòng lặp: xác định xem khi nào vòng lặp dừng
                Nếu thiếu tham số 2: Vòng lặp vô hạn
            + Tham số 3: Bước nhảy vòng lặp: thay đổi điều kiện bắt đầu của vòng lặp tiếp theo
                Nếu thiếu tham số 3: Vòng lặp vô hạn
            + Vòng lặp for: kiểm tra trước, thực hiện sau: kiểm tra tham số 2 trước, rồi mới thực hiện khối lệnh
                => Vòng lặp for có thể được thực hiện 0 hoặc n lần
                => Vòng lặp for được dùng khi biết trước số lần lặp
        - while:
            + Cấu trúc:
                tham số 1;
                while(tham số 2){
                    code block;
                    tham số 3;
                }
            + Vòng lặp while: kiểm tra trước, thực hiện sau: kiểm tra tham số 2 trước, rồi mới thực hiện khối lệnh
                => Vòng lặp while có thể được thực hiện 0 hoặc n lần
                => Vòng lặp while được dùng khi biết trước số lần lặp hoặc không biết trước số lần lặp
        - do - while:
            + Cấu trúc:
                tham số 1;
                do {
                    code block;
                    tham số 3;
                } while(tham số 2);
                
                do {
                    tham số 1;
                    code block;
                } while(tham số 2);
            + Vòng lặp do - while: thực hiện trước, kiểm tra sau: thực hiện code block, rồi mới kiểm tra tham số 2
                => Vòng lặp do - while: luôn thực hiện ít nhất 1 lần
                => Vòng lặp do - while được dùng khi biết trước số lần lặp hoặc không biết trước số lần lặp
*/

/* 
    1. In các số từ 1 đến 10
*/
int i = 1;
Console.WriteLine("-- for --");
for (i = 1; i <= 10; i++)
{
    Console.Write(i + "\t");
}
Console.WriteLine("-----------------");
Console.WriteLine("-- while --");
i = 1;
while (i <= 10)
{
    Console.Write(i + "\t");
    i++;
}
Console.WriteLine("-----------------");
Console.WriteLine("-- do while --");
i = 1;
do
{
    Console.Write(i + "\t");
    i++;
} while (i <= 10);
Console.WriteLine("-------------------");

/*
    Mảng (array): Giống Java
        - Là 1 tập hợp các phần tử có cùng kiểu dữ liệu
        - Các phần tử được phân biệt bằng 1 số nguyên được gọi là chỉ số index
        - index bắt đầu từ 0
        - Khai báo mảng:
            data_type[] array_name = new data_type[number_element];
        - Truy xuất 1 phần tử trong mảng:
            array_name[index];
        - Truy xuất lần lượt từng phần tử trong mảng: dùng vòng lặp chạy theo index
            => vòng lặp chạy từ 0 đến number_element - 1
*/

/*
    2. Nhập mảng số nguyên có n phần tử. Hiển thị những phần tử của mảng
*/

//Khai báo n
int n;
//Nhập n
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
//Khai báo mảng
int[] arr = new int[n];
//Nhập lần lượt các phần tử của mảng
for (i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//Hiển thị các phần tử của mảng
Console.WriteLine("Mảng sau khi nhập:");
for (i = 0; i < n; i++)
{
    Console.WriteLine("arr[" + i + "] = " + arr[i]);
}