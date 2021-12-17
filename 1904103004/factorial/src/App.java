import static org.junit.Assert.assertEquals;
import org.junit.Test;

public class App {
    public static void main(String[] args) throws Exception {
        int fact = factorial(5);
        System.out.println(fact);
    }

    static int factorial(int n){
        int fact = 1;
        for (int i=1; i<=n; i++){
            fact=fact*i;
        }
        return fact;
    }
    @Test
    public void factchecker()
    {
        assertEquals(120,factorial(5));
    }
}
