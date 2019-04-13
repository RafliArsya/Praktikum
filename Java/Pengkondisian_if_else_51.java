/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pengkondisian_if_else_51;
import java.util.Scanner;

/**
 *
 * @author RedLeo
 */
public class Pengkondisian_if_else_51 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        System.out.println("Masukan angka = ");
        int i = sc.nextInt();
        if (i>10){
            System.out.println("Angka lebih besar dari 10 Yaitu "+i);
        }else{
            System.out.println("Angka kurang dari 10 Yaitu "+i);
        }
    }
}