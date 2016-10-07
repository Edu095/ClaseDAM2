
public class Persona {
	
	private String cosa;// ="huevo";
	private int cantidad;// = 1;
	public String getCosa() {
		return cosa;
	}
	public int getCant() {
		return cantidad;
	}
	
	public void setCant(int h) {
		cantidad = h;
	}
	public void setCosa(String a) {
		cosa = a;
	}
	Persona(String nom, int hue) {
		// TODO Auto-generated constructor stub
		cosa=nom;
		cantidad = hue;
	}
	Persona(Persona p1){
		cosa=p1.getCosa();
	}
	
	public static void main(String[] args){
		//Crear Objecte
		Persona p1 = new Persona("cojones", 2); //si le quitamos los argumentos se debe dar el valor a las variables de arriba comentadas
		System.out.println("Mi amigo me come "+ p1.getCant() +" "+ p1.getCosa());
		System.out.println("En ocasiones me come los "+ (p1.getCant()+1) +" "+ p1.getCosa() +"s");
		p1.setCant(0);
		p1.setCosa("amigo");
		System.out.println("El problema es que tengo "+ p1.getCant()+" "+ p1.getCosa()+"s");
		Persona p2= new Persona(p1);
		System.out.println(p2.cosa);
		
	}
}
