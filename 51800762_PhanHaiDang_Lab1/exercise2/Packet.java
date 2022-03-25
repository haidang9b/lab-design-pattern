public class Packet{
    private String originator;
    private String destination;
    public String contents;

    public Packet(String originator, String destination, String contents){
        this.originator = originator;
        this.destination = destination;
        this.contents = contents;
    }
    
    public String getOriginator(){
        return this.originator;
    }

    public String getDestination(){
        return this.destination;
    }
    public String getContents(){
        return this.contents;
    }
    public void setContents(String contents){
        this.contents = contents;
    }
    
    public boolean isOriginator(Node node) {
        return node.getName().equals(originator);
    }

    public boolean isDestination(Node node){
        return node.getName().equals(destination);
    }

    
    
}