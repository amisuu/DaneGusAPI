namespace Application.Interfaces
{
    public interface IXmlConverter
    {
        public Task<List<T>> Convert<T>(string response) where T : class;
    }
}
