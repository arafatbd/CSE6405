
package unittest;

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;


public class FactorialTest {
    Factorial test;
    
    public FactorialTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
        test = new Factorial();
    }
    
    @After
    public void tearDown() {
        test = null;
    }

   
    @Test
    public void testFact() {
        int f;

        f = test.fact(0);
        assertEquals(1,f);
        f = test.fact(-1);
        assertEquals(1,f);
        f = test.fact(5);
        assertEquals(120,f);

    }

}
