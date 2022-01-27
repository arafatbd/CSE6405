/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package unittest;


public class Factorial {
    public static void main(String args[]){
    }
    int fact(int n){
        int i,f=1; 
        if (n==0)
            f = 1;
        else if(n<0)
            f = 1;
        else
            for(i=1;i<=n;i++)   
                f=f*i; 
        return f;
    }
    
        
 
}
    
