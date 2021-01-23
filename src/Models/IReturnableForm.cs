namespace SeewoHelper
{
    /// <summary>
    /// 带返回结果的 <see cref="System.Windows.Forms.Form"/>
    /// </summary>
    /// <typeparam name="TResult">返回结果类型</typeparam>
    public interface IReturnableForm<TResult>
    {
        /// <summary>
        /// 无参数获取结果
        /// </summary>
        TResult GetResult();
    }

    /// <summary>
    /// 带返回结果的 <see cref="System.Windows.Forms.Form"/>
    /// </summary>
    /// <typeparam name="TResult">返回结果类型</typeparam>
    /// <typeparam name="T">传入参数类型</typeparam>
    public interface IReturnableForm<TResult, T>
    {
        /// <summary>
        /// 需传入 1 个参数获取结果
        /// </summary>
        /// <param name="arg">参数</param>
        TResult GetResult(T arg);
    }

    /// <summary>
    /// 带返回结果的 <see cref="System.Windows.Forms.Form"/>
    /// </summary>
    /// <typeparam name="TResult">返回结果类型</typeparam>
    /// <typeparam name="T1">传入参数 1 类型</typeparam>
    /// <typeparam name="T2">传入参数 2 类型</typeparam>
    public interface IReturnableForm<TResult, T1, T2>
    {
        /// <summary>
        /// 需传入 2 个参数获取结果
        /// </summary>
        /// <param name="arg1">参数 1</param>
        /// <param name="arg2">参数 2</param>
        /// <returns></returns>
        TResult GetResult(T1 arg1, T2 arg2);
    }

    /// <summary>
    /// 带返回结果的 <see cref="System.Windows.Forms.Form"/>
    /// </summary>
    /// <typeparam name="TResult">返回结果类型</typeparam>
    /// <typeparam name="T1">传入参数 1 类型</typeparam>
    /// <typeparam name="T2">传入参数 2 类型</typeparam>
    /// <typeparam name="T3">传入参数 3 类型</typeparam>
    public interface IReturnableForm<TResult, T1, T2, T3>
    {
        /// <summary>
        /// 需传入 3 个参数获取结果
        /// </summary>
        /// <param name="arg1">参数 1</param>
        /// <param name="arg2">参数 2</param>
        /// <param name="arg3">参数 3</param>
        /// <returns></returns>
        TResult GetResult(T1 arg1, T2 arg2, T3 arg3);
    }
}
