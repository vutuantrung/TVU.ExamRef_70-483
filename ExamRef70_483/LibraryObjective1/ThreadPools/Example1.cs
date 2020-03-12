using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryObjective1.ThreadPools
{
    public class Example1 : IExample
    {
        public void ThreadProc(object data)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread callback: {0}", data);
                Thread.Sleep(1000);
            }
        }

        public void Main()
        {
            // The maximum number of worker threads in the thread pool.
            int workerThread;
            // The maximum number of asynchronous I/O threads in the thread pool.
            int completionPortThread;
            ThreadPool.GetMaxThreads(out workerThread, out completionPortThread);

            ThreadPool.QueueUserWorkItem(ThreadProc);
            ThreadPool.QueueUserWorkItem(ThreadProc, "this is a testing message");
        }

        public void Example_Execute() => Main();

        // Bạn có thể tưởng tượng thread pool giống như một hàng đợi hay phòng bán vé với mặc định là 25 người làm việc,
        // khi một người hoàn tất công việc bán vé cho khách thì khách hàng tiếp theo sẽ đến bắt đầu một giao dịch mới.

        // Threadpool already existed so we don't need create an instance Threadpool
        // All the threads in threadpool is set background threads
        // Task will be added when there is an available thread is waiting

        // Để sử dụng thread pool, bạn chỉ sử dụng phương thức tĩnh QueueUserWorkItem() của lớp ThreadPool.
        // Phương thức này nhận tham số là một phương thức callback hoặc delegate,
        // có thể dùng overload thứ hai để truyền thêm tham số cho phương thức cần thực thi.
        // Sau khi được truyền vào thread pool, tác vụ đó được đặt vào hàng đợi và sẵn sàng thực thi bất cứ lúc nào có thread ở trạng thái sẵn sàng.
    }
}
