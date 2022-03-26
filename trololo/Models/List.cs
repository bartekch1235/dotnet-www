namespace trololo.Models
{
    public class ListFizzBuzz
    {
        public List<FizzBuzz> lista;
        public ListFizzBuzz()
        {
            lista = new List<FizzBuzz>();
        }
        public void add(FizzBuzz fizz)
        {
            lista.Add(fizz);
        }
        public List<FizzBuzz> give()
        {
            return lista;
        }

    }
}
