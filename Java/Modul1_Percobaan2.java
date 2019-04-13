/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modul1_percobaan2;

/**
 *
 * @author RedLeo
 */
public class Modul1_Percobaan2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int number[] = new int[4];
        number[0] = 1;
        number[1] = number[0]+1;
        number[2] = number[1]+1;
        
        System.out.println(number[0]);
        System.out.println(number[1]);
        System.out.println(number[2]);
        
        System.out.println("Panjang Array-nya adalah "+number.length);
    }
    
}
