namespace CodeforcesApiWrapper
{
    public class ResponseContainer<T>
    {
        public string Status { get; set; }
        public string Comment { get; set; }
        public T Result { get; set; }
    }
}