using System.Threading.Tasks;

namespace HuaweiMobileServices.Utils
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Id;

    public static class AsyncUtils
    {
        public static Task<T> AsAsync<T>(this ITask<T> iTask)
        {
            var task = new TaskCompletionSource<T>();
            iTask
                .AddOnSuccessListener((result) => task.SetResult(result))
                .AddOnFailureListener((error) => task.SetException(error));
            return task.Task;
        }
    }
}
