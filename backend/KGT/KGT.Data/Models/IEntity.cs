namespace KGT.Data.Models
{
    public interface IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        TPrimaryKey Id { get; set; }
    }
}
