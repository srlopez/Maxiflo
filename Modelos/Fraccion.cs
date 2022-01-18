
namespace Maxiflo{
public class Fraccion{
    public int num;
    public int denom;

    public Fraccion(int num,int denom){
        this.num=num;
        this.denom=denom;
    }

    public override string ToString()
    {
        return $"{num}/{denom}";
    }
}
}