import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.Test;

public class Testfunction {

    @Test
    public void factorialchecker()
    {
           int expected = 122;
           
           int actual=MainFunction.factorial(5);
           assertEquals(expected,actual,"value is incorrect");
         
    }
    
}
