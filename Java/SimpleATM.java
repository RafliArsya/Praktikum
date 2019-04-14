/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package simpleatm;
import java.util.Scanner;

/**
 *
 * @author RedLeo
 */
public class SimpleATM {

    /**
     * @param args the command line arguments
     */
    public static double deposits(double a, double b){
        double mybalance=a+b;
        return mybalance;
    }
    public static double withdraws(double a, double b){
        double mybalance=b-a;
        return mybalance;
    }
    public static void check(double a){
        String info3="Tabungan anda = Rp";
        System.out.print(info3+a+",-\n");
    }
    
    public static void main(String[] args) {
        // TODO code application logic here
        double balance=0, withdraw, Deposit;
        boolean loop=true;
        String salam="Selamat Datang di Banktut", info0="Pilih Layanan\n[W]ithdraw\n[D]eposit\n[C]heck\n[E]xit", info1="Masukan Nominal = \n", info2="Uang tidak mencukupi\n", infosalah="Pilihan salah!";
        Scanner input = new Scanner(System.in);
        System.out.println(salam+"\n");
        System.out.println(info0);
        String pilihan;
        while(loop==true){
            pilihan = input.next();
            switch(pilihan){
                case ("D"):
                case ("d"):
                    System.out.println(info1);
                    Deposit = input.nextDouble();
                    balance = deposits(balance, Deposit);
                    break;
                case ("W"):
                case ("w"):
                    System.out.println(info1);
                    withdraw = input.nextDouble();
                    if(withdraw>balance){
                        System.out.println(info2);
                        break;
                    }
                    balance=withdraws(withdraw, balance);
                    break;
                case ("C"):
                case ("c"):
                    check(balance);
                    break;
                case ("E"):
                case ("e"):
                    loop=false;
                    break;
                default :
                    System.out.println(infosalah);
                    break;
            }
            if(loop){
                System.out.println(info0);
            }
        }
    }
}
