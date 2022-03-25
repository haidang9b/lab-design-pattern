public class Test {
    public static void main(String[] args){
        RSSService service = new RSSService();
        Client client1 = new Client(service);
        Client client2 = new Client(service);

        Post p1 = new Post("Post 1 title","Post 1 content");
        service.addPost(p1);
        Post p2 = new Post("Post 2 title","Post 2 content");
        service.addPost(p2);
    }
}
