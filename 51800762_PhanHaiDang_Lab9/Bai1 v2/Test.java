public class Test {
    public static void main(String[] args){
        RSSService service = new RSSService();
        IObserver client1 = new Client();
        IObserver client2 = new Client();

        service.registerObserver(client1);
        service.registerObserver(client2);
        
        Post p1 = new Post("Post 1 title","Post 1 content");
        service.addPost(p1);
        Post p2 = new Post("Post 2 title","Post 2 content");
        service.addPost(p2);
    }
}
