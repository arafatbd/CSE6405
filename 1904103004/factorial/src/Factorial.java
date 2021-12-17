import java.math.BigInteger;

public class Factorial {
    public static void main(String[] args) throws Exception {
        BigInteger fact = factorial(50);
        System.out.println(fact);
    }

    static BigInteger factorial(int n){
        if(n>50)
            return BigInteger.valueOf(-1);
        if(n==0)
            return BigInteger.ONE;
        if(n<0)
            return BigInteger.ZERO;

        BigInteger fact = BigInteger.ONE;
        for (int i=1; i<=n; i++){
            fact=fact.multiply(BigInteger.valueOf(i));
        }
        return fact;
    }
}
