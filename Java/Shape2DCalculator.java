/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shape2dcalculator;
import java.util.Scanner;
/**
 *
 * @author RedLeo
 */
public class Shape2DCalculator {

    /**
     * @param args the command line arguments
     */
    
    static double persegi(double a, double b){
       double c;
       if(a==b){
           return c=a*a;
       } 
       return c=a*b;
    }
    
    static double jajargenjang(double a, double b){
       double c;
       return c=a*b;
    }
    
    static double segitiga(double a, double b){
        double c = (a * b) * 0.5;
        return c;
    }
    
    static double lingkaran(double a, double b){
        final double phi=3.14;
        double c;
        if(a==0){
            b=b*0.5; 
        }
        return c=phi*b*b;
    }
    
    static double layang(double a, double b){
        final double set=0.5;
        double c=set*a*b;
        return c;
    }
    
    public static void main(String[] args) {
        double x, y, z;
        boolean loop=true;
        String header="Welcome to 2D Shape Calculator\n", option="[1]segitiga\n[2]Persegi\n[3]Jajar-genjang\n[4]Lingkaran\n[5]Layang-layang\n[0]Exit", wrong="Inputan Salah!", tinput="Masukan nilai ", A="Alas = ", A1="Atas = ", T="Tinggi = ", P="Panjang = ", L="Lebar = ", D1="Diagonal 1 = ", D2="Diagonal 2", r="Jari-jari", R="Diameter";
        Scanner usrinpt = new Scanner(System.in);
        System.out.println(header);
        System.out.println(option);
        // TODO code application logic here
        int choose;
        while(loop){
            choose = usrinpt.nextInt();
            switch(choose){
                case 1:
                    System.out.println(tinput+A);
                    x = usrinpt.nextDouble();
                    System.out.println(tinput+T);
                    y = usrinpt.nextDouble();
                    System.out.println(segitiga(x, y));
                    break;
                case 2:
                    System.out.println(tinput+P);
                    x = usrinpt.nextDouble();
                    System.out.println(tinput+L);
                    y = usrinpt.nextDouble();
                    System.out.println(persegi(x, y));
                    break;
                case 3:
                    System.out.println(tinput+A);
                    x = usrinpt.nextDouble();
                    System.out.println(tinput+T);
                    y = usrinpt.nextDouble();
                    System.out.println(jajargenjang(x, y));
                    break;
                case 4:
                    System.out.println("[0]Diameter\n[1]Jari-jari");
                    x = usrinpt.nextDouble();
                    if(x==0){
                        System.out.println(tinput+R);
                        y = usrinpt.nextDouble();
                    }else{
                        System.out.println(tinput+r);
                        y = usrinpt.nextDouble();
                    }
                    System.out.println(lingkaran(x, y));
                    break;
                case 5:
                    System.out.println(tinput+D1);
                    x = usrinpt.nextDouble();
                    System.out.println(tinput+D2);
                    y = usrinpt.nextDouble();
                    System.out.println(layang(x, y));
                    break;
                case 0:
                    loop=false;
                    break;
                default :
                    System.out.println(wrong);
                    break;
            }
            if(loop){
                System.out.println(option);
            }
        }
    }
    
}
