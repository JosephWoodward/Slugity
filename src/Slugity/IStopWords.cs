namespace SlugityLib
{
    public interface IStopWords
    {
        void Add(params string[] words);

        void Remove(params string[] words);
    }
}
