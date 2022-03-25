public class Server extends Node{
    private Printer[] printers = new Printer[2];
    public Server(String name,Node next){
        super(name,next);
    }

    public Server(){
        super();
    }

    
    public void accept(Packet p ){
        if(p.isDestination(this) || p.isDestination(printers[0].getInstance()) || p.isDestination(printers[1].getInstance())){
            if(nextNode() !=null){
                nextNode().accept(p);
            }
            return;
        }
    }

    public boolean isForMe(Packet p){
        if(this.getName() == p.getDestination() || p.getDestination() == printers[0].getInstance().getName() || p.getDestination() == printers[1].getInstance().getName()){
            return true;
        }
        return false;
    }
}