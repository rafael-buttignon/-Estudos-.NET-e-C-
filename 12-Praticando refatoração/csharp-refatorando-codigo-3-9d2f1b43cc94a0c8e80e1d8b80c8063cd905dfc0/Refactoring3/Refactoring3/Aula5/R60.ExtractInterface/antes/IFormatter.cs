namespace refatoracao.R60.ExtractInterface.antes
{
    public interface IFormatter
    {
        bool CanBeFormatted(string value);
        string Format(string value);
        bool IsFormatted(string value);
        string Unformat(string value);
    }
}