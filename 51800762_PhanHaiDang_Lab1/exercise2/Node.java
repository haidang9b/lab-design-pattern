public abstract class Node{
    private Node next;
    private String name;
    
    public Node(String name,Node next){
        this.name = name;
        this.next = next;
    }

    public Node(String name){
        this.name = name;
        this.next = null;
    }

    public Node(){
        this.name = "";
        this.next = null;
    }

    public abstract void accept(Packet p);

    public String getName(){
        return this.name;
    }

    public void insertNode(Node node){
        next.insertNode(node);
        this.next = node;
    }

    public void addLast(Node node){
        Node current = this;
        while(current.next != null){
            current = current.next;
        }
    }
    public Node nextNode(){
        return this.next;
    }
}