/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pengkondisian_switchcase_51;
import java.util.Scanner;
/**
 *
 * @author RedLeo
 */
public class Pengkondisian_switchcase_51 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);
        System.out.println("Masukan angka 1-2 yang diinginkan = ");
        int i = sc.nextInt();
        
        switch(i){
            case (1):
                System.out.println("Angka yang anda masukan bernilai A");
                break;
            case (2):
                System.out.println("Angka yang anda masukan bernilai B");
                break;
            default:
                System.out.println("Angka yang anda masukan tak bernilai A ataupun B");
                break;
        }
        System.out.println("Program END!!!!!!!!!!!!!!!!!");
    }
    
}
