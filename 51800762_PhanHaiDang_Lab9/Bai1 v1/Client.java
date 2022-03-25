import java.util.ArrayList;
import java.util.Date;
import java.util.Timer;
import java.util.TimerTask;

public class Client {
    private int interval = 3000;
    private Timer timer;
    private RSSService service;
    private Date lastPull;

    public Client(RSSService service){
        this.service = service;
        lastPull = new Date();
        timer = new Timer();
        timer.schedule(new FetchTask(), interval);
    }
    
    public class FetchTask extends TimerTask{

        @Override
        public void run() {
            // TODO Auto-generated method stub
            if(service.hasNewPost(lastPull)){
                ArrayList<Post> posts = service.getPost();
                lastPull = new Date();
                refreshGUI(posts);
            }
        }
    }

    public void refreshGUI(ArrayList<Post> posts){
        System.out.println("Refresh GUI");
        for(Post post : posts){
            System.out.println("Title : " + post.getTitle() + " | Content: " + post.getContent());
        }
    }
}
