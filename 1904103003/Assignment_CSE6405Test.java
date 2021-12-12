/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment_cse6405;

import java.math.BigInteger;
import org.junit.AfterClass;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Mehedi Hasan
 */
public class Assignment_CSE6405Test {
    
    public Assignment_CSE6405Test() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }

    /**
     * Test of Factorial method, of class Assignment_CSE6405.
     */
    @Test
    public void testFactorial() {
        System.out.println("Factorial");
        int n = 0;
        BigInteger expResult = BigInteger.ONE;
        BigInteger result = Assignment_CSE6405.Factorial(n); 
        assertEquals(expResult, result);
        
        expResult = new BigInteger("2432902008176640000");
        result = Assignment_CSE6405.Factorial(20);
        assertEquals(expResult, result);
        
        expResult = null;
        result = Assignment_CSE6405.Factorial(-1);
        assertEquals(expResult, result);
    }

    /**
     * Test of main method, of class Assignment_CSE6405.
     */
    @Test
    public void testMain() {
        System.out.println("main");
        String[] args = null;
        Assignment_CSE6405.main(args);
    }
    
}
