public class Cotxe
{
    private String matricula, marca;
    private int km;
    private Boolean ac;

    public static void main(String []args)
    {

     Cotxe f=new Cotxe();
     System.out.println(f.getMarca());
     System.out.println(f.getMatricula());

     Cotxe f2=new Cotxe("00000ZZZ",100000,"Volvo", false);     
     System.out.println("Matricula:"+f2.getMatricula());
     System.out.println("a/c:"+f2.getAc());
     f2.setAc(true);
     System.out.println("a/c:"+f2.getAc());

    }

    Cotxe()
    {
       matricula="12345HHH";
       km=10;
       marca="Ferrari";
       ac=true;
    }

    Cotxe(String m, int km, String marca, Boolean ac) 
    {
      matricula=m;
      this.km=km;
      this.marca= marca;
      this.ac=ac;
    }

    public void setAc(Boolean ac)
    {
       this.ac=ac;
    }

    public void setMatricula(String m)
    {
      matricula=m;
    }

    public void setKm(int km)
    //                int k
    {
      // km=k;
      this.km=km;
    }

    public void setMarca(String m)
    {
      marca=m;
    }


    public String getMatricula()
    {
       return matricula;
    }

    public int getKm()
    {
       return km;
    }

    public String getMarca()
    {
      return marca;
    }

    public Boolean getAc()
    {
       return ac;
    }

}
