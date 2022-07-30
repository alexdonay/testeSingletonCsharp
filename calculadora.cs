public delegate double operacao(double a, double b);
public sealed class calculadora
{
    private static calculadora ?instance = null;
    private static readonly object locker = new object();
    private calculadora(){}
    public static calculadora Instance{
        get{
            lock(locker)
            if(instance == null){
                instance = new calculadora();

            }
            return instance;
        }

    }
    public double calcular(double a, double b, operacao Operacao){
        return Operacao(a, b);
    }
}