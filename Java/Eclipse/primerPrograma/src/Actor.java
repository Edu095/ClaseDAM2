
public class Actor extends Persona {
	
	private String buffu;
	
	Actor(String nom, int hue, String b) {
		super(nom, hue);
		this.buffu=b;
		
	}

	public static void main(String []args) {
		Actor a=new Actor("tu", 2, "Abe");
		System.out.println(a.getCosa()+a.getCant()+a.buffu);
	}
}
