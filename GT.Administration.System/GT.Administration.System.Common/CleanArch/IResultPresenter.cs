namespace GT.Administration.System.Common.CleanArch
{
    public interface IResultPresenter<TResponse> : MediatR.INotificationHandler<Result<TResponse>>
    { }
}
