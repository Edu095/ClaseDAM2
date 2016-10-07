public class Finestra {
	private Integer amplada;
	private Integer alcada;
	private String material;
	private Boolean obrir;
	
	public Integer getAmplada() { return amplada; }
	public Integer getAlcada() { return alcada; }
	public String getMaterial() { return material; }
	public Boolean getObrir() { return obrir; }
	
	public void setAmplada(int a) { amplada=a; }
	public void setAlcada(int a) { alcada=a; }
	public void setMaterial(String m) { material=m; }
	public void setObrir(Boolean o) { obrir=o; }
	
	public Finestra() {
		amplada=20;
		alcada=35;
		material="fusta";
		obrir=true;
	}
	public Finestra(int am, int al, String m, Boolean o) {
		amplada=am;
		alcada=al;
		material=m;
		obrir=o;
	}
	public Finestra(Finestra f) {
		amplada=f.getAmplada();
		alcada=f.getAlcada();
		material=f.getMaterial();
		obrir=f.getObrir();
	}
	
	public static void main(String []args) {
		Finestra f= new Finestra();
		Finestra f2= new Finestra(15, 34, "Alumini", false);
		Finestra f3= new Finestra(f);
		
		System.out.println(f.getAmplada());
		System.out.println(f2.getAlcada());
		f3.setMaterial("Carbono");
		System.out.println(f3.getMaterial());
	}
}
