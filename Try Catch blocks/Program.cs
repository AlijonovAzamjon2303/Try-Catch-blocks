public class Program
{
    private static void Main(string[] args)
    {
        int n;
        try
        {
            n = int.Parse(Console.ReadLine());
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        //catch(DivideByZeroException ex)
        //{
        // Bitta Exception'dan qayta foydalanib bo'lmaydi.
        //}
        finally
        {
            Console.WriteLine("Muammoli qism muvaffaqiyatli tugatildi!");
        }
    }
}