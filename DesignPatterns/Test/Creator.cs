namespace DesignPatterns.Test
{
    public class Creator
    {
        public IDataModeling CreateInstance<T>() where T : class, new()
        {
            IDataModeling data = null;

            data = (IDataModeling)new T();

            return data;
        }
    }
}
