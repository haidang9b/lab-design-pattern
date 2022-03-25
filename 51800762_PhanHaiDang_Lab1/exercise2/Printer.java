public class Printer extends Server {
    private static Printer instance;

    private Printer(String name, Node node) {
        super(name, node);
    }
    private  Printer(){
        super();
    }

    public static Printer getInstance(){
        if(instance == null){
            instance = new Printer();
        }
        return instance;
    }

    public void print(Packet p){
        System.out.println(p.contents);
    }

    public void accept(Packet p) {
        System.out.println("accept printer");
    }

}
