public sealed class  soma : operacoes
{
    private static soma ?instance = null;
    private static readonly object locker = new object();
    private soma(){
        Console.WriteLine("Iniciando classe soma");
    }
    public static soma Instance{
        get{
            lock(locker)
            if(instance == null){
                instance = new soma();

            }
            return instance;
        }

    }
   public override double oper(double a, double b){
    return a + b;
   }
}