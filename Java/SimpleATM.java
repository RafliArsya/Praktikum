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
    public static void main(String[] args) {
        // TODO code application logic here
        double balance=0, withdraw, Deposit;
        String salam="Selamat Datang di Banktut", info0="Pilih Layanan\n[W]ithdraw\n[D]eposit\n[C]heck\n", info1="Masukan Nominal = \n", info2="Uang tidak mencukupi\n", info3="Tabungan anda = Rp", infosalah="Pilihan salah!";
        
        Scanner input = new Scanner(System.in);
        System.out.println(salam+"\n");
        System.out.println(info0);
        String pilihan;
        
        do{
            pilihan = input.next();
            switch(pilihan){
                case ("D"):
                case ("d"):
                    System.out.println(info1);
                    Deposit = input.nextDouble();
                    balance = balance + Deposit;
                    break;
                case ("W"):
                case ("w"):
                    System.out.println(info1);
                    withdraw = input.nextDouble();
                    if (withdraw > balance){
                        System.out.println(info2);
                    }else{
                        balance = balance - withdraw;
                    }
                    break;
                case ("C"):
                case ("c"):
                    System.out.print(info3+balance+",-\n");
                    break;
                default :
                    System.out.println(infosalah);
                    break;
            }
            System.out.println(info0);
        }while((!pilihan.equals("e")) || (!pilihan.equals("E")));
    }
}