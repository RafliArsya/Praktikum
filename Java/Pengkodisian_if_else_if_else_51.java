/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pengkodisian_if_else_if_else_51;
import java.util.Scanner;

/**
 *
 * @author RedLeo
 */
public class Pengkodisian_if_else_if_else_51 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        System.out.println("Masukan angka = ");
        int i = sc.nextInt();
        if (i==0){
            System.out.println("Angka Yang di masukan adalah "+i);
        }else if (i>0){
            System.out.println("Bilangan bulat positif yaitu "+i);
        }else {
            System.out.println("Bilangan bulat negatif yaitu "+i);
        }
    }
}
