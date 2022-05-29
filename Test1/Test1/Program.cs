using System;

namespace Test1
{
    // Lớp Creator khai báo phương thức gốc được cho là trả về
    // một đối tượng của lớp Sản phẩm. Các lớp con của Người sáng tạo thường cung cấp
    // việc thực hiện phương thức này.
    abstract class Creator
    {
        // Lưu ý rằng Người tạo cũng có thể cung cấp một số triển khai mặc định của
        // phương thức factory.
        public abstract IProduct FactoryMethod();

        // Cũng xin lưu ý rằng, mặc dù có tên như vậy nhưng
        // trách nhiệm chính của Người sáng tạo không phải là tạo ra sản phẩm. Thông thường, nó chứa một số
        // logic kinh doanh cốt lõi dựa trên các đối tượng Sản phẩm, được trả về bởi
        // phương thức nhà máy. Các lớp con có thể gián tiếp thay đổi logic nghiệp vụ đó
        // bằng cách ghi đè phương thức gốc và trả về một kiểu khác
        // sản phẩm từ nó.
        public string SomeOperation()
        {
            // Gọi phương thức factory để tạo một đối tượng Sản phẩm.
            var product = FactoryMethod();
            // Bây giờ, hãy sử dụng sản phẩm.
            var result = "Client: Cung mot ma cua nguoi tao vua lam viec voi "
                + product.Operation();

            return result;
        }
    }

    // Concrete Creators ghi đè phương thức factory để thay đổi
    // loại sản phẩm kết quả.
    class ConcreteCreator1 : Creator
    {
        // Lưu ý rằng chữ ký của phương thức vẫn sử dụng kiểu sản phẩm trừu tượng,
        // mặc dù sản phẩm cụ thể thực sự được trả về từ phương thức.
        // Bằng cách này, Creator có thể độc lập với các lớp sản phẩm cụ thể.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }

    // Giao diện Sản phẩm khai báo các hoạt động mà tất cả các sản phẩm cụ thể phải thực hiện.
    public interface IProduct
    {
        string Operation();
    }

    // Concrete Products cung cấp nhiều cách triển khai khác nhau của giao diện Sản phẩm.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Ket qua cua ConcreteProduct1}";
        }
    }

    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Ket qua cua ConcreteProduct2}";
        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Chay voi ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Chay voi ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        // Mã máy khách hoạt động với một phiên bản của trình tạo cụ thể,
        // mặc dù thông qua giao diện cơ sở của nó.
        // Miễn là khách hàng tiếp tục làm việc với người sáng tạo thông qua giao diện cơ sở,
        // bạn có thể chuyển nó vào bất kỳ lớp con nào của người tạo.
       
        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client: Toi khong biet class cua nguoi tao, " +
                 "nhung no van hoat đong.\n" + creator.SomeOperation());
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
