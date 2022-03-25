public class DemoLogger extends Thread{
    public static void main(String[] args){
        Thread[] threads = new Thread[50];
        for(int i =0 ; i< 50; i++){
            threads[i] = new Thread(new Runnable(){
                public void run(){
                    String msg = Thread.currentThread().getName() + "Xin chao moi nguoi --- \n";
//                    Logger logger = Logger.getInstance();
                    Logger.getInstance().LogMessage(msg);
                }
            });
        }

        for(int i =0;i<50;i++){
            threads[i].start();
        }

        for(int i =0;i<50;i++){
            try{
                threads[i].join();
            }
            catch (Exception e){
            }
        }
    }


}