namespace EC2202MAC.Servicies
{
    public class Functions : IFunctions
    {
        public string CambiarTexto(string text, int count)
        {
            return $"{text} {count}";
        }
    }
}