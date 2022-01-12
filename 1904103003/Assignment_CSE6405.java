/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment_cse6405;

import java.math.BigInteger;
import java.util.Scanner;

/**
 *
 * @author Mehedi Hasan
 */
public class Assignment_CSE6405 {

    public static BigInteger Factorial(int n){
        if(n == 0)
            return BigInteger.ONE;
        else if(n < 0)
            return null;
        BigInteger fact = BigInteger.ONE;
        for (int i = n; i >= 1; i--)
            fact = fact.multiply(BigInteger.valueOf(i));
               
        return fact;
    }
    
    public static void main(String[] args) {
        int n = 0;
        Scanner input = new Scanner(System.in);
        while(input.hasNextLine()){
            n = input.nextInt();
            break;
        }
        System.out.println(Factorial(n));
    }
    
}
