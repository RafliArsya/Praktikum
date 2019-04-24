/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package shapecalc;
import java.util.Scanner;
/**
 *
 * @author RedLeo
 */
public class ShapeCalc {

    /**
     * @param args the command line arguments
     */
    
    static double balok(double a, double b, double c){
       double d;
       if(a==b && b==c){
           return d=Math.pow(a, 3);
       } 
       return d=a*b*c;
    }
    
    static double prisma(double a, double b, double c){
       double d,e;
       final double set = 0.5;
       e = set * a * b;
       return d = set * e * c;
    }
    
    static double limas(double a, double b, double c){
        final double set = 0.5, sep = 0.33;
        double d = set * (a * b);
        double e = sep * d * c;
        return e;
    }
    
    static double tabung(double a, double b){
        final double phi=3.14;
        double c = phi* Math.pow(a, 2);
        double d = c * b;
        return d;
    }
    
    static void printstring(String a){
        System.out.println(a);
    }
    
    static void printthis(double a){
        System.out.println("Hasilnya adalah "+a+" m³");
    }
    
    public static void main(String[] args) {
        // TODO code application logic here
        double x, y, z;
        boolean loop=true;
        String header="Welcome to Shape Calculator\n", option="[1]Balok\n[2]Prisma segitiga\n[3]Tabung\n[4]Limas segitiga\n[0]Exit", wrong="Inputan Salah!", tinput="Masukan nilai ", A="Alas = ", A1="Atas = ", T="Tinggi = ", T1="Tinggi segitiga = ", P="Panjang = ", L="Lebar = ", r="Jari-jari";
        Scanner usrinpt = new Scanner(System.in);
        printstring(header);
        printstring(option);
        // TODO code application logic here
        int choose;
        while(loop){
            choose = usrinpt.nextInt();
            switch(choose){
                case 1:
                    printstring(tinput+P);
                    x = usrinpt.nextDouble();
                    printstring(tinput+L);
                    y = usrinpt.nextDouble();
                    printstring(tinput+T);
                    z = usrinpt.nextDouble();
                    printthis(balok(x, y, z));
                    break;
                case 2:
                    printstring(tinput+A);
                    x = usrinpt.nextDouble();
                    printstring(tinput+T1);
                    y = usrinpt.nextDouble();
                    printstring(tinput+T);
                    z = usrinpt.nextDouble();
                    printthis(prisma(x, y, z));
                    break;
                case 3:
                    printstring(tinput+r);
                    x = usrinpt.nextDouble();
                    printstring(tinput+T);
                    y = usrinpt.nextDouble();
                    printthis(tabung(x, y));
                    break;
                case 4:
                    printstring(tinput+A);
                    x = usrinpt.nextDouble();
                    printstring(tinput+T1);
                    y = usrinpt.nextDouble();
                    printstring(tinput+T);
                    z = usrinpt.nextDouble();
                    printthis(limas(x, y, z));
                    break;
                case 0:
                    loop=false;
                    break;
                default :
                    printstring(wrong);
                    break;
            }
            if(loop){
                printstring(option);
            }
        }
    }
    
}
