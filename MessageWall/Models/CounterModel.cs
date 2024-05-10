namespace MessageWall.Models
{
    public class CounterModel(int count)
    {
        public int Counter { get; set; } = count;
    }
}
