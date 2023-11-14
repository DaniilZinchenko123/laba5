namespace Task1
{
    public interface ISearchable<T>
    {
        List<T> Search(Func<T, bool> criteria);
    }

}