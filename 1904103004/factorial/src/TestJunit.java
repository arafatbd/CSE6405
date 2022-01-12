import org.junit.Test;
import static org.junit.Assert.assertEquals;

import java.math.BigInteger;

public class TestJunit {
   // This code only works till 50! After that it returns -1.
   @Test
   public void factZeroIs1() throws Exception{
      assertEquals(BigInteger.valueOf(1),Factorial.factorial(0));
   }
   @Test
   public void factOneIs1() throws Exception{
      assertEquals(BigInteger.valueOf(1),Factorial.factorial(1));
   }
   @Test
   public void fact10Is3628800() throws Exception{
      assertEquals(BigInteger.valueOf(3628800),Factorial.factorial(10));
   }
   @Test
   public void factMinusIs0() throws Exception{
      assertEquals(BigInteger.valueOf(0),Factorial.factorial(-10));
   }
   @Test
   public void fact51IsMinusOne() throws Exception{
      assertEquals(BigInteger.valueOf(-1),Factorial.factorial(51));
   }
}
