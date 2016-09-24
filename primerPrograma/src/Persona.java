
public class Persona {
	
	private String cosa ="huevo";
	private int cantidad = 1;
	public String getNom() {
		return cosa;
	}
	public int getEdat() {
		return cantidad;
	}
	
	public static void main(String[] args){
		//Crear Objecte
		Persona p1 = new Persona();
		System.out.println("Mi amigo me come "+ p1.getEdat() +" "+ p1.getNom());
		System.out.println("En ocasiones me come los "+ (p1.getEdat()+1) +" "+ p1.getNom() +"s");
		
	}
}
