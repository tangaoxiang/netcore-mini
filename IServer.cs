    public interface IServer
    {
        Task StartAsync(RequestDelegate handler);
    }