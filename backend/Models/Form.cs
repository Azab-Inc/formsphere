namespace backend.Models
{
    public class Form
    {
        public int Id { get; set; }
        public List<TextField> TextFields { get; set; }
        public List<DateField> DateFields { get; set; }
        public List<NumberField> NumberFields { get; set; }
    }

    public class TextField
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class DateField
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public DateTime Value { get; set; }
    }

    public class NumberField
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public int Value { get; set; }
    }
}
