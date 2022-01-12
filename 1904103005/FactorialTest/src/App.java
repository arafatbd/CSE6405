import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class App {
    public static void main(String args[])
	
	{
	
        int n,fact=0;
 
	    n= 5;		   
                  
        fact=factCal(n);
 
        System.out.println("fact="+fact);
 
	}
	
	static int factCal(int x)
	{
	    int fact=1;
	    for(int i=1;i<=x;i++)
	    {
	
	    	fact=fact*i;
 
 	    }
	    return fact;
	}
    @Test
    public void FactNegEq1(){
        assertEquals(1,factCal(-5));
    }
    @Test
    public void FactZeroEq1(){
        assertEquals(1,factCal(0));
    }
    @Test
    public void FactOneEq1(){
        assertEquals(1,factCal(1));
    }
    @Test
    public void FactFiveEq120(){
        assertEquals(120,factCal(5));
    }
    @Test
    public void FactSixEq720(){
        assertEquals(720,factCal(6));
    }
 
}