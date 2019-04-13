/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package limas_segitiga;
import java.util.Scanner;
/**
 *@author RedLeo
 **/
public class Limas_Segitiga {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
       double V, L, a, l, t, T;
       final double set = 0.5, sep = 0.33;
       String nama="YUSUF RAFLI B", nim="21120118130101";
       int shift = 4, kelompok = 51;
       
       System.out.println("Saya "+nama+" dengan NIM "+nim+".\nKelompok "+kelompok+", Shift "+shift+".\n");
       
       Scanner input = new Scanner(System.in);
       System.out.println("Alas = ");
       a = input.nextDouble();
       System.out.println("Tinggi Segitiga = ");
       t = input.nextDouble();
       System.out.println("Tinggi Limas = ");
       T = input.nextDouble();
       L=set*a*t;
       V=sep*L*T;
       
       System.out.println("Luas Segitiga = 1/2 * a * t\nLuas Segitiga = 1/2 * "+a+" * "+t+" = " +L);
       System.out.println("Volume Segitiga = 1/3 * Luas alas * Tinggi Limas\nVolume Segitiga = 1/3 * "+L+" * "+T+" = "+V);
    }
    
}
