namespace Namespace;
public static class RandomNumberGenerator
{
    private static Random random = new Random(DateTime.Now.Millisecond);
    public static int Generate(){
        return random.Next(10, 1000);
    }

    public static int find(){
        return 1;
    }
}
