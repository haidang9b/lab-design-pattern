public class Client implements IObserver{

    @Override
    public void update(Post post) {
        // TODO Auto-generated method stub
        System.out.println("Title : " + post.getTitle() + " | Content: " + post.getContent());
    }
    
}
