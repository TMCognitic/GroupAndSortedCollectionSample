namespace SortedCollectionSample
{
    public class DataViewModel
    {
        public string Text { get; init; }
        public int Value { get; init; }
        public DataViewModel(string text, int value)
        {
            Text = text;
            Value = value;
        }
    }
}