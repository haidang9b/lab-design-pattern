public class Workstation extends Node {
    public Workstation(String name, Node next){
        super(name, next);
    }

    public Workstation(String name){
        super(name);
    }

    public void accept(Packet p) {
        if(p.isDestination(this)){
            if(nextNode() !=null){
                nextNode().accept(p);
            }
            return;
        }
    }
    
}
