using System;
namespace ConsoleApp1
{
    class Program
    {
        // ======== Input ========
        static void Input(BST PhoneBook)
        {
            Console.Write("Nhập id (4 kí tự): ");
            string id = Console.ReadLine();
            Console.Write("Nhập tên: ");
            string name = Console.ReadLine();
            Console.Write("Nhập số điện thoại: ");
            string numphone = Console.ReadLine();
            Console.Write("Nhập Gmail: ");
            string gmail = Console.ReadLine();
            Console.Write("Nhập Facebook: ");
            string face = Console.ReadLine();
            Console.Write("Nhập năm sinh (dd/mm/yyyy): ");
            string date = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            string sex = Console.ReadLine();
            PhoneBook.Insert(new DanhBa(id, name, numphone, gmail, face, date, sex));
        }
        
        static void Main(string[] args)
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Title = " Đồ Án CTDL & GT";
            Console.WriteLine("                                                  ĐỒ ÁN CẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT");
            Console.WriteLine("                                               NHÓM THỰC HIỆN: AN, HƯNG, KHÔI, KIỆN, THÁI");
            Console.WriteLine("                                                             *************");
            BST PhoneBook = new BST();
            PhoneBook.Insert(new DanhBa("DL24", "Linh", "0932-1111", "hoailinh@gmail.com", "facebook.com/linh14ty", "13/12/1969", "Nam"));
            PhoneBook.Insert(new DanhBa("K23K", "An", "0947-2222", "annguyn2@gmail.com", "facebook.com/annguyn23", "23/03/2002", "Nam"));
            PhoneBook.Insert(new DanhBa("K23A", "Anh", "0955-3344", "tramanh@gmail.com", "facebook.com/tramanh40s", "29/02/1979", "Nu"));
            PhoneBook.Insert(new DanhBa("KS23", "Yen", "0947-4444", "yenvo@gmail.com", "facebook.com/yenvomodel", "12/10/1989", "Nu"));
            PhoneBook.Insert(new DanhBa("SAOE", "Hung", "0537-9991", "hungnguyen@gmail.com", "facebook.com/hung12", "12/08/2002", "Nam"));
            PhoneBook.Insert(new DanhBa("MSK5", "Khoi", "0947-7722", "dangkhoi@gmail.com", "facebook.com/khoigialai", "01/05/1996", "Nam"));
            PhoneBook.Insert(new DanhBa("ST01", "Kien", "0947-4406", "kienlam@gmail.com", "facebook.com/kienlam", "16/04/2002", "Nam"));
            PhoneBook.Insert(new DanhBa("FB15", "My", "0947-1744", "mynguyen@gmail.com", "facebook.com/mynguyen", "23/02/2002", "Nu"));
            PhoneBook.Insert(new DanhBa("NT30", "Tam", "0947-4888", "nhutam@gmail.com", "facebook.com/nhutam30", "30/11/2002", "Nu"));
            PhoneBook.Insert(new DanhBa("YU34", "Y", "9425-6653", "lieuy1205@gmail.com", "facebook.com/lieuy12", "12/05/2002", "Nu"));
            PhoneBook.Insert(new DanhBa("MH37", "Thai", "1878-2225", "thaidui@gmail.com", "facebook.com/thaiquoc", "30/04/2011", "Nam"));
            PhoneBook.Insert(new DanhBa("DDHG", "Thanh", "0980-2225", "thanhzui@gmail.com", "facebook.com/thanhcute", "02/09/1992", "Nam"));
            Console.WriteLine();
            Console.WriteLine("                                               _____________Danh bạ của tôi___________");
            Console.WriteLine("                                           ID:           TÊN:           SĐT:    (NĂM SINH)");
            PhoneBook.Output(PhoneBook.Root);
            Console.WriteLine("                                                        ==================");     
            Console.WriteLine();
            Console.WriteLine("Phím 1: Đếm số liên hệ hiện có."); 
            Console.WriteLine("Phím 2: Thêm liên hệ vào danh bạ.");
            Console.WriteLine("Phím 3: In danh bạ.");
            Console.WriteLine("Phím 4: Xóa liên hệ khỏi danh bạ (theo tên).");
            Console.WriteLine("Phím 5: Tìm kiếm thông tin (theo Tên).");
            Console.WriteLine("Phím 6: Tìm kiếm thông tin (theo ID).");
            Console.WriteLine("Phím 7: Tìm kiếm thông tin (theo SĐT).");
            Console.WriteLine("Phím 8: Tìm kiếm thông tin (theo Ngày/Tháng/Năm).");
            Console.WriteLine("Phím 9: Lọc theo giới tính.");
            Console.WriteLine("Phím 10: Xóa toàn bộ danh bạ.");
            Console.WriteLine(">>> Phím 0: Thoát khỏi chương trình");
        teamA:
            Console.Write(">>> Vui lòng chọn yêu cầu của bạn: ");
            int yeucau = int.Parse(Console.ReadLine());
            switch (yeucau)
            {
                case 1:
                    Console.WriteLine("================== Số liên hệ trong danh bạ ============ ");
                    Console.WriteLine("Danh bạ có tổng cộng: {0} contact", PhoneBook.CountNode(PhoneBook.Root));
                    Console.WriteLine("=================");
                    break;
                case 2:
                    Console.WriteLine("================== Thêm liên hệ ============ ");
                    Console.Write("Nhập số người muốn thêm vào danh bạ: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Input(PhoneBook);
                        Console.WriteLine("=================");
                    }
                    break;
                case 3:
                    Console.WriteLine("                                           ================== In danh bạ ============ ");
                    Console.WriteLine("                                              ID:        TÊN:           SĐT:    (NĂM SINH)");
                    PhoneBook.Output(PhoneBook.Root);
                    Console.WriteLine("                                                           =================");
                    break;
                case 4:
                    Console.WriteLine("                                           ================== Xóa liên hệ ============ ");
                    Console.Write("Nhập tên cần xóa:  ");
                    string name = Console.ReadLine();
                    PhoneBook.Remove(name);
                    Console.WriteLine($"                              ============== Đã xóa {name.ToUpper()} ra khỏi danh bạ ==================");                    
                    break;
                case 5:
                    Console.WriteLine("                                           ===================== Tim kiếm theo Tên =================== ");
                    Console.Write("Nhập tên bạn muốn kiếm trong danh bạ: ");
                    string timkiem = Console.ReadLine();
                    if (PhoneBook.FindName(timkiem) != null)
                    {
                        Console.WriteLine($"{PhoneBook.FindName(timkiem).Data}|    {PhoneBook.FindName(timkiem).Data.GetFaceBook(),25}|    {PhoneBook.FindName(timkiem).Data.GetEmail(),25}|    {PhoneBook.FindName(timkiem).Data.GetSex(),4}");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy thông tin của {0}", timkiem);
                    }
                    Console.WriteLine("                                                                 =================");
                    break;
                case 6:
                    Console.WriteLine("                                           ====================== Tim kiếm theo ID ===================");
                    Console.Write("Nhap id: ");
                    string id = Console.ReadLine();
                    PhoneBook.FindId(PhoneBook.Root, id);
                    Console.WriteLine("                                                                  =================");
                    break;
                case 7:
                    Console.WriteLine("                                           ====================== Tim kiếm theo SĐT ================== ");
                    Console.Write("Nhập Sđt: ");
                    string sđt = Console.ReadLine();
                    PhoneBook.FindPhonenumber(PhoneBook.Root, sđt);
                    Console.WriteLine("                                                                  ==================");
                    break;
                case 8:
                    Console.WriteLine("                                           ================== Tim kiếm theo Ngày/Tháng/Năm ============ ");
                    Console.Write("Nhap ngay (thang hoac nam): ");
                    string date = Console.ReadLine();
                    PhoneBook.BirthFilter(PhoneBook.Root, date);
                    Console.WriteLine("                                                                  =================");
                    break;
                case 9:
                    Console.WriteLine("                                           ========================= Lọc giới tính ====================");
                    Console.Write("Nhập giới tính: ");
                    string sex = Console.ReadLine();
                    PhoneBook.Sexfilter(PhoneBook.Root, sex);
                    Console.WriteLine("                                                                   =================");
                    break;
                case 10:
                    Console.WriteLine("                                           ====================== Xóa toàn bộ danh bạ ===================");
                    PhoneBook.DeleteAllTree(PhoneBook.Root);
                    
                    break;

                case 0: Console.WriteLine("Nhấn bất kì để thoát khỏi chương trình"); return;
            }
            goto teamA;
        }
    }
}
