namespace SeewoHelper
{
    public interface IReturnableForm<TResult>
    {
        TResult GetInfo();
    }

    public interface IReturnableForm<TResult, T>
    {
        TResult GetInfo(T arg);
    }

    public interface IReturnableForm<TResult, T1, T2>
    {
        TResult GetInfo(T1 arg1, T2 arg2);
    }
}
