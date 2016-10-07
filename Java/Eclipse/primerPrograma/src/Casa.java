public class Casa 
{
	private Double superficie;
	private String direccio;
	private Integer numPlantes, numFinestres;
	private Boolean piscina;
	
	public Casa() {
		superficie=5.3;
		direccio="Ctra. Almacelles, s/n";
		numPlantes=6;
		numFinestres=9;
		piscina=true;
	}
	
	public Casa(String d, Double s, int nF, int nP, Boolean p) {
		superficie=s;
		direccio=d;
		numFinestres=nF;
		numPlantes=nP;
		piscina=p;
	}
	
	public Casa(Casa c){
		superficie=c.getSuperficie();
		direccio=c.getDireccio();
		numFinestres=c.getNumF();
		numPlantes=c.getNumP();
		piscina=c.getPiscina();
	}
	
	public void setPiscina(Boolean p) {
		piscina=p;
	}
	
	public String getDireccio() {
		return direccio;
	}
	public Double getSuperficie() {
		return superficie;
	}
	public Integer getNumF() {
		return numFinestres;
	}
	public Integer getNumP() {
		return numPlantes;
	}
	public Boolean getPiscina() {
		return piscina;
	}
	
	public static void main(String []args) {
		Casa c=new Casa();
		System.out.println("Casa1");
		System.out.println("Direcció: "+ c.getDireccio());
		System.out.println("Superficie: "+ c.getSuperficie());
		System.out.println("Piscina: "+ c.getPiscina());
		
		Casa c2= new Casa("Calle Mayor", 8.3, 12, 7, true);
		System.out.println("Casa2");
		System.out.println("Direcció: "+ c2.getDireccio());
		System.out.println("Superficie: "+ c2.getSuperficie());
		System.out.println("Piscina: "+ c2.getPiscina());
		c2.setPiscina(false);
		System.out.println("CORRECCIÓ Piscina: "+ c2.getPiscina());
		System.out.println("Numero de finestres: "+ c2.getNumF());
		System.out.println("Numero de plantes: "+ c2.getNumP());
		
		Casa cCop= new Casa(c);
		System.out.println("Aixó es una copia de Casa c: "+ cCop.getDireccio());
		
		
	}
	
}