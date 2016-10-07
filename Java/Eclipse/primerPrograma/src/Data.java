
public class Data
{
 private int dia;
 private int mes;
 private int any;

 //Constructor buit
 Data()
 {
   dia=1;
   mes=1;
   any=2015;
 }

 Data(int d, int m, int a)
 {
  dia=d;
  mes=m;
  any=a;
 }

 //Constructor copiador

 Data(Data d)
 {
    dia=d.getDia();
    mes=d.getMes();
    any=d.getAny();
 }

 public int getDia()
 {
   return dia;
 }
 
 public int getMes()
 {
   return mes;
 }

 public int getAny()
 {
   return any;
 }

 public void setDia(int d)
 {
   dia=d;
 }

 public void setMes(int m)
 {
  mes=m;
 }

 public void setAny(int a)
 {
  any=a;
 }

 public void dema()
 {
   if(dia < 31)
   {
     dia++;
   }
   else
   {
     dia=1;
     mes++;
   }

 }

 public static void main(String [] args)
 {
   Data d=new Data();
   Data d2=new Data(1,10,2015);
   Data d3=new Data(d2);
   
   d3.dema(); //2
   d3.dema(); //3

   System.out.println( d3.getDia() );
   System.out.println( d2.getDia() );
   System.out.println( d.getDia() );
  
 }


}