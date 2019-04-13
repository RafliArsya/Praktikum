/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modul1_percobaan1_51;
import java.util.*;
/**
 *
 * @author RedLeo
 */
public class Modul1_Percobaan1_51 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        String salam = "Halo\nSelamat datang Praktikan DKP 2019";
        System.out.println(salam);
        
        Scanner input= new Scanner(System.in);
        System.out.print("nama : ");
        String nama = input.next();
        System.out.print("Umur : ");
        int umur = input.nextInt();
        System.out.println("Halo "+nama+"! \nUmur Kamu "+umur+" Tahun!");
    }
    
}
