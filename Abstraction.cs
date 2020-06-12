using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace AbstractClass
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Your code goes here
       Console.WriteLine("Nama\t\t: Nur Fikri");
       Console.WriteLine("NIM\t\t: 19.11.2790");
       Console.WriteLine("Kelas\t\t: 19 IF 03");
       
       
       Console.WriteLine();
       
       Console.WriteLine("MOBIL");
       
       Console.WriteLine();
       
       Mobil car;
       
       car = new Avanza();
       car.pembuat();
       car.tipe();
       car.harga();
       
       Console.WriteLine();
		 
       car = new Xenia();
       car.pembuat();
       car.tipe();
       car.harga();
       
       
       Console.WriteLine();
       
       Console.WriteLine("KOMPUTER");
       
       Console.WriteLine();
       
       Komputer pc;
       
       pc = new ROG();
       pc.pembuat();
       pc.tipe();
       pc.harga();
       
       Console.WriteLine();
	   
	   pc = new Swift();
       pc.pembuat();
       pc.tipe();
       pc.harga();
       
		 
            }
   }
   
   // Abstract Class 
   public abstract class Mobil {
     public abstract void pembuat();
     public abstract void tipe();
     public abstract void harga();
   }
   
   public class Avanza : Mobil {
     public override void pembuat() {
       Console.WriteLine("Pembuat : Toyota ");
     }
     
     public override void tipe() {
       Console.WriteLine("Tipe : AVANZA G ");
     }
     
     public override void harga() {
       Console.WriteLine("Harga : 100 Juta ");
     }
   }
   
   public class Xenia : Mobil {
     public override void pembuat() {
       Console.WriteLine("Pembuat : Daihatsu ");
     }
     
     public override void tipe() {
       Console.WriteLine("Tipe : XENIA R ");
     }
     
     public override void harga() {
       Console.WriteLine("Harga : 90 Juta ");
     }
   }
   
   // Interface Class Hewan
   
   public interface Komputer{
     void pembuat();
     void tipe();
     void harga();
   }
   
  public class ROG : Komputer {
     public void pembuat() {
       Console.WriteLine("ROG dibuat oleh ASUS ");
     }
   
     public void tipe() {
       Console.WriteLine("- Laptop");
     }
     public void harga() {
       Console.WriteLine("- Harga: 15 Juta ");
     }
     
   } 
   
   
   public class Swift : Komputer {
     public void pembuat() {
       Console.WriteLine("Swift dibuat oleh Acer ");
     }
   
     public void tipe() {
       Console.WriteLine("- Laptop");
     }
     public void harga() {
       Console.WriteLine("- Harga: 10 Juta ");
     }
     
   } 
   
 }