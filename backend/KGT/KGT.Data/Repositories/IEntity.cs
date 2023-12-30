
namespace KGT.Data.Repositories
{
    public interface IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        TPrimaryKey Id { get; set; }
    }
}
