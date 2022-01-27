namespace SO.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}