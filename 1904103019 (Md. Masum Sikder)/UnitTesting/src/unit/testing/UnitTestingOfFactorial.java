package unit.testing;

import static org.junit.Assert.*;

import org.junit.Test;

public class UnitTestingOfFactorial {
	
	FactorialCalculation obj = new FactorialCalculation();

	@Test
	public void testFactOfZeroEqualOne() {
		long output = obj.factorial(0);
		assertEquals(1,output);
	}
	
	@Test
	public void testFactOfNegNumEqualOne() {
		long output = obj.factorial(-6);
		assertEquals(1,output);
	}
	
	
	@Test
	public void testFactOfOneEqualOne() {
		long output = obj.factorial(1);
		assertEquals(1,output);
	}
	@Test
	public void testFactOf4Equal24() {
		long output = obj.factorial(4);
		assertEquals(24,output);
	}
	
	@Test
	public void testFactOf10Equal3628800() {
		long output = obj.factorial(10);
		assertEquals(3628800,output);
	}
	

}
