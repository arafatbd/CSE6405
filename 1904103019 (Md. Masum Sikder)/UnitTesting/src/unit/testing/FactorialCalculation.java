package unit.testing;

public class FactorialCalculation {
	
	public long factorial (int n) {
		
		int i;
		long fact=1;  
		if (n<=0)
			return fact;
		else {
			for(i=1;i<=n;i++){    
				fact=fact*i;    
			}    
			return fact;
		}	
	}
}
